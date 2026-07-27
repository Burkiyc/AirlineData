using AirlineData.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            }

        }

        private void ucakEkleBtn_Click(object sender, EventArgs e)
        {

            string query = $"INSERT Ucaklar {null}";
            SqlInsertData(query);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            SqlPullTable("Ucaklar");
        }

        private void filoYonetmTab_Click(object sender, EventArgs e)
        {

        }


    }
}
