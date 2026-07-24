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

        static Dictionary<string, string> tableMap = new Dictionary<string, string>
        {
            {"Ucaklar", "Uçaklar" },
            {"Bakim_Kayitlari", "Bakım Kayıtları" },
            {"Personel", "Personel" },
            {"Yakit_Harcamalari", "Yakıt Harcamaları" },
            {"Yakit_Tedarikcileri", "Yakıt Tedarikçileri" }
        };

        private void Form1_Load(object sender, EventArgs e)
        {

            // 1. Sadece 'baseTableNames' listesinde olan anahtarları sözlükten filtreleyin
            var filtrelenmisSozluk = tableMap
                .Where(kvp => baseTableNames.Contains(kvp.Key))
                .ToList();

            // 2. ComboBox'a veri kaynağı olarak bağlayın
            tableSelCbx.DataSource = filtrelenmisSozluk;
            tableSelCbx.DisplayMember = "Value";
            tableSelCbx.ValueMember = "Key";
        }

        private void tableSelCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    connection.Open();
                    object selectedItem = tableSelCbx.SelectedItem;
                    var selectedvalue = (KeyValuePair<string, string>)selectedItem;
                    string query = $"SELECT * FROM [{selectedvalue.Key}]"; // Replace with your actual table name
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


        private void PersonelYonetmBtn_Click(object sender, EventArgs e)
        {

        }

        private void HvyoluYonetmiBtn_Click(object sender, EventArgs e)
        {
            YonetimForm filoForm = new YonetimForm();
            filoForm.Show();
        }
    }
}
