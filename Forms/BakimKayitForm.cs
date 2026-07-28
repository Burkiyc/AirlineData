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
        }

        private void BakimKayitForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 1, "Kuyruk No...");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 1, "Personel Numarası...");
            bakimDataGrid.DataSource = SqlPullData("SELECT\r\nB.BakimId,\r\nU.UcakID,\r\nU.KuyrukNo,\r\nU.Model,\r\nP.AdSoyad AS Koordinator,\r\nB.BakimTarihi,\r\nB.YapilanIslem,\r\nB.Sonuc\r\nFROM Bakim_Kayitlari B\r\nINNER JOIN Ucaklar U ON B.UcakID = U.UcakID\r\nINNER JOIN Personel P ON P.PersonelID = B.PersonelID\r\nORDER BY B.BakimTarihi DESC;");
            bakimDataGrid.Columns[0].Visible = false;
            bakimDataGrid.BackgroundColor = Color.FromArgb(64, 64, 64);
            uygulamaYeriCbx.DataSource = SqlPullData("SELECT ICAO, MeydanKodu FROM HavaMeydanlari");
            uygulamaYeriCbx.DisplayMember = "ICAO";
        }

        //Bakım Kayıtlarını Yenile
        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            bakimDataGrid.DataSource = SqlPullData("SELECT\r\nB.BakimId,\r\nU.UcakID,\r\nU.KuyrukNo,\r\nU.Model,\r\nP.AdSoyad AS Koordinator,\r\nB.BakimTarihi,\r\nB.YapilanIslem,\r\nB.Sonuc\r\nFROM Bakim_Kayitlari B\r\nINNER JOIN Ucaklar U ON B.UcakID = U.UcakID\r\nINNER JOIN Personel P ON P.PersonelID = B.PersonelID\r\nORDER BY B.BakimTarihi DESC;");
            bakimDataGrid.Columns[0].Visible = false;
            bakimDataGrid.BackgroundColor = Color.FromArgb(64, 64, 64);
            currentTableLbl.Text = "Tüm kayıtlar";
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            SqlInsertData("INSERT INTO Bakim_Kayitlari ");
            bakimDataGrid.DataSource = SqlPullData("SELECT * FROM Bakim_Kayitlari");
            bakimDataGrid.Columns[0].Visible = false;
        }


        private void tumKayilar_Click(object sender, EventArgs e)
        {

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
            string query = $"insert into Bakim_Kayitlari (ucakID, PersonelID, BakimTarihi,\r\nYapilanIslem, UygulamaYeri)\r\n" +
                $"select ucakID, '{personeID}', '{dateTime}', '{yapilanIslem}', '{uygulamaYeriCbx.ValueMember}'\r\nfrom Ucaklar where KuyrukNo='{kuyrukNo}' returning ucakID;";
            int result = SqlInsertScalar(query);
            if (result != 0)
            {
                MessageBox.Show("Kayıt başarıyla oluşturuldu."); ;
            }
            else
            {
                quickInfoLbl.Text = "Kayıt oluşturulamadı.";
            }
        }
    }
}
