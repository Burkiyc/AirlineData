using AirlineDataV2.DbModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineDataV2.Forms
{
    public partial class UcakForm : XtraForm
    {
        string operationState = "Add";
        Ucak seciliUcak;
        public UcakForm()
        {
            InitializeComponent();
            onaylaBtn.Visible = false;
        }
        public UcakForm(Ucak ucak) : this()
        {
            operationState = "Edit";
            seciliUcak = ucak;
            onaylaBtn.Visible = true;
            ucakEkleBtn.Visible = false;
        }

        private void UcakForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (seciliUcak != null)
                {
                    textEdit1.Text = seciliUcak.KuyrukNo ?? "TC-???";
                    textEdit2.Text = seciliUcak.Model ?? "";
                    //textEdit3.Text = seciliUcak.AlimYili;
                    //textEdit4.Text = seciliUcak.UcusSaati.ToString();
                    //textEdit5.Text = seciliUcak.SimdikiMeydan;
                }
                else
                {
                    textEdit1.Text = "TC-";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Uçak bilgileri yüklenirken bir hata oluştu." + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ucakEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    var yeniUcak = new DbModels.Ucak
                    {
                        KuyrukNo = textEdit1.Text,
                        Model = textEdit2.Text
                    };
                    context.Ucaklar.Add(yeniUcak);
                    context.SaveChanges();
                }
                XtraMessageBox.Show("Uçak başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Uçak eklenirken bir hata oluştu." + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    if (operationState == "Edit" && seciliUcak != null)
                    {
                        var ucakToUpdate = context.Ucaklar.Find(seciliUcak.Id);
                        if (ucakToUpdate != null)
                        {
                            ucakToUpdate.KuyrukNo = textEdit1.Text;
                            ucakToUpdate.Model = textEdit2.Text;
                            //ucakToUpdate.AlimYili = textEdit3.Text;
                            //ucakToUpdate.UcusSaati = Convert.ToDecimal(textEdit4.Text);
                            //ucakToUpdate.SimdikiMeydan = textEdit5.Text;
                            context.SaveChanges();
                        }
                    }
                }
                XtraMessageBox.Show("Uçak başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Uçak kaydedilirken bir hata oluştu." + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //char[]? TC_section = textEdit1.Text.Substring(0, 2)?.ToCharArray();
            //if (TC_section[0] != 'T' || TC_section[1] != 'C' || TC_section[2] != '-')
            //{
            //    textEdit1.Text = "TC-";
            //}
        }
    }
}
