using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineData.Classes
{
    internal class Functions
    {
        public static int tableCount = 0;
        public static List<string> baseTableNames = new List<string>();
        public static string GetConnectionString()
        {
            // Replace with your actual connection string
            return "Server=.\\PROJELER; Database=Airline; User Id=sa; Password=sql2026dev; TrustServerCertificate=true;";
        }
        public static int GetDatabaseProps()
        {
            int totalTables = 0;
            try
            { 
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.Open();
                    string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE_TABLE'"; // Veriabanındaki tabloların ismini liste olarak verir
                    SqlCommand cmd = new SqlCommand(query, connection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            baseTableNames.Add(reader["TABLE_NAME"].ToString());
                        }
                    }
                    totalTables = baseTableNames.Count;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }
    }
}
