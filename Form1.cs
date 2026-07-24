using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static AirlineData.Classes.Functions;

namespace AirlineData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var table in baseTableNames)
            {
                tableSelCbx.Text = "Tablo Seç";
                tableSelCbx.Items.Add(table);
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {tableSelCbx.SelectedItem}"; // Replace with your actual table name
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTableA.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
