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

namespace AirlineData.Forms
{
    public partial class ucakEkleControl : UserControl
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        public ucakEkleControl()
        {
            InitializeComponent();
        }

        private void ucakEkleControl_Load(object sender, EventArgs e)
        {
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 1, "Kuyruk No...");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 1, "Uçak Modeli...");
            SendMessage(numericUpDown1.Handle, EM_SETCUEBANNER, 1, "Alım Yılı...");
            SendMessage(textBox3.Handle, EM_SETCUEBANNER, 1, "Uçuş Saati...");

            comboBox1.DataSource = SqlPullData("SELECT ICAO, MeydanKodu FROM HavaMeydanlari");
            comboBox1.DisplayMember = "ICAO";

            numericUpDown1.Minimum = 1970;
            numericUpDown1.Maximum = 2026;
            numericUpDown1.Value = DateTime.UtcNow.Year - 5;

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string KuyrukNoTx
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ModelTx
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int AlimYilNum
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UcusSaati
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SimdikiMeydan
        {
            get { return comboBox1.Text; }
        }


    }
}
