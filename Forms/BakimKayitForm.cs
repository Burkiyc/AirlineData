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
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 1, "Bakım Türü...");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 1, "Personel Numarası...");


        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            bakimDataGrid.DataSource = SqlPullData("SELECT * FROM Bakim_Kayitlari");
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            SqlInsertData("INSERT INTO Bakim_Kayitlari ");
        }


        private void tumKayilar_Click(object sender, EventArgs e)
        {

        }

        private void bakimDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0 && e.Button == MouseButtons.Right)
            {
                object? myobj = bakimDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                bakimContextMenu.Show();
            }
        }

        private void qprsSelBtn_Click(object sender, EventArgs e)
        {
            QuickDataViewForm quickForm = new QuickDataViewForm("Personel");
            quickForm.ShowDialog();
            
        }
    }
}
