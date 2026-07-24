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
            SqlPullTable("Ucaklar");
        }

        private void YonetimForm_Load(object sender, EventArgs e)
        {

        }

        private void ucakEkleBtn_Click(object sender, EventArgs e)
        {

            string query = $"INSERT Ucaklar {null}";
            SqlInsertData(query);
        }
    }
}
