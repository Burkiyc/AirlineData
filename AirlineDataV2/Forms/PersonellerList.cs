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
    public partial class PersonellerList : UserControl
    {
        public PersonellerList()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }
        private void ListeyiYenile()
        {
            using (var context = new DbModels.AirlineDbContext())
            {
                var personeller = context.Personeller.ToList();
                gridControl1.DataSource = personeller;
            }
        }

        private void persEkleBtn_Click(object sender, EventArgs e)
        {
            using (var context = new DbModels.AirlineDbContext())
            {
                PersonelForm personelForm = new PersonelForm();
                personelForm.ShowDialog();
                ListeyiYenile();
            }
        }

        private void persSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var focusedRow = gridView1.GetFocusedRow();
                if (focusedRow != null)
                {
                    DialogResult result = MessageBox.Show("Seçili personel silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (var context = new DbModels.AirlineDbContext())
                        {
                            var personel = context.Personeller.Find(((DbModels.Personel)focusedRow).Id);
                            if (personel != null)
                            {
                                context.Personeller.Remove(personel);
                                context.SaveChanges();
                                ListeyiYenile();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Personel silinirken bir hata oluştu: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void persEditBtn_Click(object sender, EventArgs e)
        {
            int focusedRow = gridView1.FocusedRowHandle;
            int personelId = (int)gridView1.GetRowCellValue(focusedRow, "Id");
            PersonelForm editPersForm = new PersonelForm(personelId);
            editPersForm.ShowDialog();
            ListeyiYenile();
        }
    }
}
