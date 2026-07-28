using AirlineData.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static AirlineData.Classes.Functions;

namespace AirlineData.Forms
{
    public partial class QuickDataViewForm : Form
    {
        public QuickDataViewForm()
        {
            InitializeComponent();
        }

        public QuickDataViewForm(string tableName, string[]? columns = null) : this()
        {
            string kolonlar = columns == null ? "*" : string.Join(",", columns);

            dataGridView1.DataSource = SqlPullData($"SELECT {kolonlar} FROM {tableName}");
        }

        static object? selectedItem;
        public static object SelectedItem()
        {
            if (selectedItem != null)
            {
                return selectedItem;
            }
            else
            {
                MessageBox.Show("selectedItem null döndü.");
                return null;
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowCollection = dataGridView1.Rows[e.RowIndex];
                Personel personel = new Personel();
                personel.Id = (int)rowCollection.Cells[0].Value!;
                personel.AdSoyad = (string)rowCollection.Cells["AdSoyad"].Value!;
                personel.IseGirisTarihi = Convert.ToDateTime(rowCollection.Cells["Ise_GirisTarihi"].Value!);
                if (rowCollection.Cells["AtananMeydan"].Value != DBNull.Value)
                    personel.AtananMeydan = (string)(rowCollection.Cells["AtananMeydan"].Value!);
                selectedItem = personel;
                this.Close();
            }
        }

        private void QuickDataViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
        }
    }
}
