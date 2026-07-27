using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public QuickDataViewForm(string tableName)
        {
            dataGridView1 = new DataGridView();
            if (tableName == "Ucaklar")
            {

                dataGridView1.DataSource = SqlPullData("SELECT * FROM Ucaklar");
            }
            else if (tableName == "Personel")
            {
                dataGridView1.DataSource = SqlPullData("SELECT * FROM Personel");
            }
        }
        public QuickDataViewForm(string tableName, string[] columns)
        {
            dataGridView1 = new DataGridView();
            if (tableName == "Ucaklar")
            {

                dataGridView1.DataSource = SqlPullData($"SELECT {string.Join("", columns)} FROM Ucaklar");
            }
            else if (tableName == "Personel")
            {
                dataGridView1.DataSource = SqlPullData($"SELECT {string.Join("", columns)} FROM Personel");
            }
        }
    }
}
