using AirlineData.Classes;
using AirlineData.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static AirlineData.Classes.Functions;

namespace AirlineData
{
    public partial class YonetimForm : Form
    {
        public YonetimForm()
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        enum TabIndex
        {
            FILO = 0,
            PERSONEL = 1
        }

        public bool SqlPullTable(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = $"SELECT * FROM [{tableName}]"; // Replace with your actual table name
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (tableName == "Ucaklar")
                        ucakDataGrid.DataSource = dataTable;
                    else if (tableName == "Personel")
                        persDataGrid.DataSource = dataTable;
                    else
                        return false;
                }
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
                return false;
            }
        }
        public bool SqlPullTable(string tableName, string customArgs)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = $"SELECT * FROM [{tableName} {customArgs}]"; // Replace with your actual table name
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    ucakDataGrid.DataSource = dataTable;
                    connection.Close();
                }
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
                return false;
            }

        }

        private void addDataBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucakEkleControl1.KuyrukNoTx))
            {
                MessageBox.Show("Kuyruk numarası doldurulması zorunludur."); return;
            }


            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(1) FROM Ucaklar WHERE KuyrukNo = @KuyrukNo;";
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@KuyrukNo", ucakEkleControl1.KuyrukNoTx);
                    int c = (int)command.ExecuteScalar();
                    if (c == 1)
                    {
                        MessageBox.Show("Veritabanında zaten bu kuyruk numaralı bir uçak var.");
                        return;
                    }
                }
                using (SqlCommand cmd = new SqlCommand("", connection))
                {
                    List<string> columns = new List<string>();
                    List<string> paramss = new List<string>();
                    columns.Add("KuyrukNo");
                    paramss.Add("@KuyrukNo");
                    cmd.Parameters.AddWithValue("@KuyrukNo", ucakEkleControl1.KuyrukNoTx);

                    if (!string.IsNullOrWhiteSpace(ucakEkleControl1.ModelTx))
                    {
                        columns.Add("Model");
                        paramss.Add("@Model");
                        cmd.Parameters.AddWithValue("@Model", ucakEkleControl1.ModelTx);
                    }

                    if (ucakEkleControl1.AlimYilNum != 0)
                    {
                        columns.Add("AlimYili");
                        paramss.Add("@AlimYili");
                        cmd.Parameters.AddWithValue("@AlimYili", ucakEkleControl1.AlimYilNum);
                    }

                    if (!string.IsNullOrWhiteSpace(ucakEkleControl1.UcusSaati))
                    {
                        columns.Add("UcusSaati");
                        paramss.Add("@UcusSaati");
                        cmd.Parameters.AddWithValue("@UcusSaati", ucakEkleControl1.UcusSaati);
                    }

                    if (!string.IsNullOrWhiteSpace(ucakEkleControl1.SimdikiMeydan))
                    {
                        columns.Add("SimdikiMeydan");
                        paramss.Add("@SimdikiMeydan");
                        cmd.Parameters.AddWithValue("@SimdikiMeydan", ucakEkleControl1.SimdikiMeydan);
                    }

                    string setClause = string.Join(", ", columns);
                    string paramClause = string.Join(", ", paramss);
                    string commandText = $"INSERT INTO Ucaklar ({setClause}) VALUES ({paramClause});";
                    cmd.CommandText = commandText;
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Uçak kaydı başarıyla eklendi.");
                    }

                }
            }


        }

        private void YonetimForm_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                SqlPullTable("Ucaklar");
                ucakDataGrid.Columns["UcakID"].Visible = false;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                SqlPullTable("Personel");
                persDataGrid.Columns["PersonelID"].Visible = false;
            }
            atMeydancbx.DataSource = SqlPullData("SELECT ICAO FROM HavaMeydanlari");
            atMeydancbx.DisplayMember = "ICAO";
        }


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            SqlPullTable("Ucaklar");
        }

        private void filoYonetmTab_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                SqlPullTable("Ucaklar");
                ucakDataGrid.Columns["UcakID"].Visible = false;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                SqlPullTable("Personel");
                persDataGrid.Columns["PersonelID"].Visible = false;
                SendMessage(persAdtbx.Handle, EM_SETCUEBANNER, 1, "Ad Soyad...");
                SendMessage(uzmanlikTbx.Handle, EM_SETCUEBANNER, 1, "Uzmanlık Alanı...");
                SendMessage(uzmanlikTbx.Handle, EM_SETCUEBANNER, 1, "Uzmanlık Alanı...");
            }
        }

        private void prsEkleBtn_Click(object sender, EventArgs e)
        {
            string name = persAdtbx.Text;
            string uzmanlik = uzmanlikTbx.Text;
            string meydan = atMeydancbx.Text;
            int result = SqlInsertData($"INSERT INTO Personel (AdSoyad, UzmanlikAlani, Ise_GirisTarihi, AtananMeydan)" +
                $"VALUES ('{name}', '{uzmanlik}', GETUTCDATE(), '{meydan}');");
            if (result == 1)
            {
                qinfLbl2.Text = "Başarıyla Kaydedildi";
            }
            else
                MessageBox.Show("Kaydedilirken bir hata oluştu.");
        }

        int rowIndex = -1;
        private void ucakDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                foreach (var item in ucakDataGrid.Rows)
                {
                    (item as DataGridViewRow).Selected = false;

                }
                rowIndex = e.RowIndex;
                ucakDataGrid.Rows[e.RowIndex].Selected = true;

                yontimCtxMenu.Show(Cursor.Position);
            }
        }

        private void kaydıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                int ID = (int)ucakDataGrid.Rows[rowIndex].Cells["UcakID"].Value!;
                int result = SqlInsertData($"BEGIN TRANSACTION; DELETE FROM Bakim_Kayitlari WHERE UcakID={ID}; DELETE FROM Ucaklar WHERE UcakID={ID}; COMMIT;");
                if (result != 0)
                    MessageBox.Show("Kayıt silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Kayıt silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SqlPullTable("Ucaklar");
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                int ID = (int)persDataGrid.Rows[rowIndex].Cells["PersonelID"].Value!;
                int result = SqlInsertData($"DELETE FROM Personel WHERE PersonelID = {ID};");
                if (result != 0)
                    MessageBox.Show("Kayıt silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Kayıt silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SqlPullTable("Personel");
            }
            else return;
        }

        private void persDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                foreach (var item in persDataGrid.Rows)
                {
                    (item as DataGridViewRow).Selected = false;

                }
                rowIndex = e.RowIndex;
                persDataGrid.Rows[e.RowIndex].Selected = true;

                yontimCtxMenu.Show(Cursor.Position);
            }
        }

        private void kaydıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int ID = (int)ucakDataGrid.Rows[rowIndex].Cells["UcakID"].Value;
            //string query = $"UPDATE TABLE Ucaklar WHERE UcakID = {ID} Model=";
            if (tabControl1.SelectedIndex == 0)
            {
                DataGridViewRow row = ucakDataGrid.Rows[rowIndex];
                UcakEdit editForm = new UcakEdit(row);
                editForm.ShowDialog();
                SqlPullTable("Ucaklar");
            }
            else
            {
                DataGridViewRow row = ucakDataGrid.Rows[rowIndex];
                UcakEdit editForm = new UcakEdit(row);
                editForm.ShowDialog();
                SqlPullTable("Ucaklar");
            }
        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            SqlPullTable("Personel");
        }
    }
}
