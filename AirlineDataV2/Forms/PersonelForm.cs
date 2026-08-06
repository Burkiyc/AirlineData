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
    public partial class PersonelForm : XtraForm
    {
        Personel _sectilenPersonel;
        public PersonelForm()
        {
            InitializeComponent();

        }
        public PersonelForm(int personelId) : this()
        {
            Text = "Personel Güncelle";
            using (var context = new DbModels.AirlineDbContext())
            {
                var personel = context.Personeller.Find(personelId);
                if (personel != null)
                {
                    nameTextBox.Text = personel.AdSoyad;
                }
            }
            prsKytEkleBtn.Enabled = false;
            onaylaBtn.Enabled = true;
        }

        private void prsKytEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    var yeniPersonel = new DbModels.Personel
                    {
                        AdSoyad = nameTextBox.Text
                    };
                    context.Personeller.Add(yeniPersonel);
                    context.SaveChanges();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            int personelId = _sectilenPersonel.Id;
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    var personel = context.Personeller.Find(personelId);
                    if (personel != null)
                    {
                        personel.AdSoyad = nameTextBox.Text;
                        context.SaveChanges();
                        XtraMessageBox.Show("Personel bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Personel bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && nameTextBox.Text != string.Empty)
            {
                if (prsKytEkleBtn.Visible)
                {
                    prsKytEkleBtn.PerformClick();
                }
                else if (onaylaBtn.Visible)
                {
                    onaylaBtn.PerformClick();
                }
            }
        }
    }
}
