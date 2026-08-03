using AirlineData.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static AirlineData.Classes.Functions;

namespace AirlineData.Forms
{
    public partial class UcakEdit : EditRecord
    {
        public UcakEdit()
        {
            InitializeComponent();
            this.Size = base.Size;

        }

        public UcakEdit(DataGridViewRow row) : this()
        {
            this.row = row;
            numericUpDown1.Maximum = DateTime.UtcNow.Year;
        }
        DataGridViewRow row;

        Ucak ucak = new Ucak();


        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);

            int result = SqlInsertData(
                $"UPDATE Ucaklar SET Model='{textBox1.Text}', AlimYili='{numericUpDown1.Value}', UcusSaati='{textBox2.Text}', " +
                $"SimdikiMeydan='{comboBox1.Text}' WHERE UcakID={ucak.Id};");
            if (result > 0)
            {
                MessageBox.Show("Uçak detayları güncellend.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Uçak bilgisi güncellenirken bir hata oluştu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Close();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;


        private void UcakEdit_Load(object sender, EventArgs e)
        {
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 1, "Model...");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 1, "Uçuş Saati...");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 1, "Uçuş Saati...");

            comboBox1.DataSource = SqlPullData("SELECT ICAO, MeydanKodu FROM HavaMeydanlari");
            comboBox1.DisplayMember = "ICAO";


            ucak.Id = (int)row.Cells["UcakID"].Value!;
            ucak.KuyrukNo = row.Cells["KuyrukNo"].Value != DBNull.Value ? (string)row.Cells["KuyrukNo"].Value! : "";
            ucak.Model = row.Cells["Model"].Value != DBNull.Value ? (string)row.Cells["Model"].Value! : "";
            ucak.UcusSaati = row.Cells["UcusSaati"].Value != DBNull.Value ? (decimal)row.Cells["UcusSaati"].Value! : 0;
            ucak.AlimYili = row.Cells["AlimYili"].Value != DBNull.Value ? (int)row.Cells["AlimYili"].Value! : 0;
            ucak.SimdikiMeydan = row.Cells["SimdikiMeydan"].Value != DBNull.Value ? (string)row.Cells["SimdikiMeydan"].Value! : "";


            textBox1.Text = ucak.Model;
            textBox2.Text = ucak.UcusSaati.ToString();
            numericUpDown1.Value = ucak.AlimYili;
            comboBox1.Text = ucak.SimdikiMeydan;


        }
    }
}
