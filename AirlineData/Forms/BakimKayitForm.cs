using AirlineData.Classes;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static AirlineData.Classes.Functions;
using static AirlineData.Program;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AirlineData.Forms
{
    public partial class BakimKayitForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        public BakimKayitForm()
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void BakimKayitForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 1, "Kuyruk No...");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 1, "Personel Numarası...");
            bakimDataGrid.DataSource = SqlPullData("SELECT\r\nB.BakimId,\r\nU.KuyrukNo,\r\nU.Model,\r\nP.AdSoyad AS Koordinator,\r\nB.BakimTarihi,\r\nB.YapilanIslem,\r\nB.Sonuc\r\nFROM Bakim_Kayitlari B\r\nINNER JOIN Ucaklar U ON B.UcakID = U.UcakID\r\nINNER JOIN Personel P ON P.PersonelID = B.PersonelID\r\nORDER BY B.BakimTarihi DESC;");
            bakimDataGrid.Columns[0].Visible = false;
            bakimDataGrid.BackgroundColor = Color.FromArgb(64, 64, 64);
            uygulamaYeriCbx.DataSource = SqlPullData("SELECT ICAO, MeydanKodu FROM HavaMeydanlari");
            uygulamaYeriCbx.DisplayMember = "ICAO";
        }

        //Bakım Kayıtlarını Yenile
        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            BakimDataGridRefresh();
        }

        private void BakimDataGridRefresh()
        {
            bakimDataGrid.DataSource = SqlPullData("SELECT B.BakimId, U.UcakID, U.KuyrukNo, U.Model, P.AdSoyad AS Koordinator, B.BakimTarihi, B.YapilanIslem, B.Sonuc FROM Bakim_Kayitlari B INNER JOIN Ucaklar U ON B.UcakID = U.UcakID INNER JOIN Personel P ON P.PersonelID = B.PersonelID ORDER BY B.BakimTarihi DESC;");
            bakimDataGrid.Columns[0].Visible = false;
            bakimDataGrid.BackgroundColor = Color.FromArgb(64, 64, 64);
            currentTableLbl.Text = "Tüm kayıtlar";
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bakimDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                object? myobj = bakimDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                bakimContextMenu.Show(Cursor.Position);
            }
        }

        Personel personel;
        private void qprsSelBtn_Click(object sender, EventArgs e)
        {
            QuickDataViewForm quickForm = new QuickDataViewForm("Personel");
            quickForm.ShowDialog();
            personel = (Personel)QuickDataViewForm.SelectedItem();
            textBox2.Text = personel.AdSoyad;
            quickInfoLbl.Text = "Personel seçildi.";
        }

        int rowIndex = -1;

        private void buUçağınTümKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kuyrukNo = (string)bakimDataGrid.Rows[rowIndex].Cells["KuyrukNo"].Value!;
            //Ucak ucak = new Ucak();

            object? myobj = bakimDataGrid.Rows[rowIndex].Cells[2].Value;

            DataTable dt = SqlPullData($"select\r\nu.KuyrukNo,\r\nu.Model,\r\nb.BakimTarihi,\r\nb.PersonelID,\r\nb.YapilanIslem,\r\nb.Sonuc\r\nfrom Bakim_Kayitlari B\r\ninner join Ucaklar u on u.UcakID = b.UcakID\r\nwhere u.KuyrukNo = '{kuyrukNo}';");
            bakimDataGrid.DataSource = dt;
            bakimDataGrid.BackgroundColor = Color.DarkSlateGray;
            currentTableLbl.Text = kuyrukNo + " kayıtları gösteriliyor";
        }

        private void bakimDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                foreach (var item in bakimDataGrid.Rows)
                {
                    (item as DataGridViewRow).Selected = false;

                }
                bakimDataGrid.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;

                bakimContextMenu.Show(Cursor.Position);
            }
        }

        private void bakimOlustrBtn_Click(object sender, EventArgs e)
        {
            string kuyrukNo = textBox1.Text;
            DateTime dateTime = dateTimePicker1.Value.ToUniversalTime();
            int personeID = personel.Id;
            string yapilanIslem = textBox3.Text;

            //  SqlDataExists($"SELECT COUNT(*) FROM Bakim_Kayitlari WHERE UcakID = (SELECT UcakID FROM Ucaklar WHERE KuyrukNo = '{kuyrukNo}');")
            if (!SqlDataExists($"SELECT COUNT(1) FROM Ucaklar WHERE KuyrukNo='{kuyrukNo}';"))
            {
                MessageBox.Show($"Filoda {kuyrukNo} kuyruk numaralı bir uçak yok.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string query = $"INSERT INTO Bakim_Kayitlari(ucakID, PersonelID, BakimTarihi,\r\nYapilanIslem, UygulamaYeri)" +
                $"VALUES(" +
                $"(SELECT UcakID FROM Ucaklar WHERE KuyrukNo = '{kuyrukNo}'), '{personeID}', '{dateTime}', '{yapilanIslem}', '{uygulamaYeriCbx.ValueMember}');";
            SqlInsertData(query);

            MessageBox.Show("Kayıt başarıyla oluşturuldu."); ;
            BakimDataGridRefresh();
        }

        private void kaydiSilTool_Click(object sender, EventArgs e)
        {
            var bakimId = bakimDataGrid.Rows[rowIndex].Cells["BakimID"].Value;
            SqlInsertData($"DELETE FROM Bakim_Kayitlari WHERE BakimID = '{bakimId}';");
            BakimDataGridRefresh();

        }
    }
}
