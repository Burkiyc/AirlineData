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
        static SqlConnection connection = new SqlConnection(GetConnectionString());
        public static int GetDatabaseProps()
        {
            int totalTables = 0;
            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"; // Veriabanındaki tabloların ismini liste olarak verir
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

        public static void SqlInsertData(string query)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SqlInsertMultiData(string query, List<object> datas)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
