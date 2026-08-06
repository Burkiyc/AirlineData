using AirlineDataV2.DbModels;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineDataV2.Forms
{
    public partial class BakimKayitlariList : UserControl
    {
        public BakimKayitlariList()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void kayitEkleBtn_Click(object sender, EventArgs e)
        {
            BakimEkle bakimEkleForm = new BakimEkle();
            bakimEkleForm.ShowDialog();
            ListeyiYenile();
        }

        private void kayitSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    if (gridView1.FocusedRowHandle < 0)
                    {
                        XtraMessageBox.Show("Seçilen satır geçerli bir nesne satırına işaret etmiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var bakimId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
                    //var seciliBakimKaydi = gridView1.FocusedRowObject as DbModels.BakimKaydi ?? throw new InvalidOperationException("Seçili bakım kaydı bulunamadı.");
                    if (bakimId != null && (int)bakimId > 0)
                    {
                        var sectigimBakimKaydi = context.BakimKayitlari.Find(bakimId);
                        if (sectigimBakimKaydi != null)
                        {
                            context.BakimKayitlari.Remove(sectigimBakimKaydi);
                            context.SaveChanges();
                            XtraMessageBox.Show("Bakım kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else XtraMessageBox.Show("veritabanından bulduğum kayı boş(sectigimBkimKAydi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ListeyiYenile();
                    }
                    else XtraMessageBox.Show("seçilen kayıt boş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                string innerExceptionMessage = ex.InnerException?.Message ?? ex.Message;
                XtraMessageBox.Show("Bakım kaydı silinirken bir hata oluştu: " + innerExceptionMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BakimKayitlariList_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    //var bakimKayitlari = context.BakimKayitlari
                    //    .Include(b => b.Ucak)
                    //    .ToList();
                    //gridControl1.DataSource = bakimKayitlari;

                    var bakimListesi = context.BakimKayitlari
                        //.Include(b => b.BakimPersoneller)
                        .Select(b => new
                        {
                            b.Id,
                            b.UcakId,
                            b.Ucak,
                            KuyrukNo = b.Ucak.KuyrukNo,
                            b.BakimTarihi,
                            Personeller = string.Join(", ", b.BakimPersoneller.Select(s => s.Personel.AdSoyad))
                        })
                        .ToList();

                    gridControl1.DataSource = bakimListesi;

                }
            }
            catch (Exception ex)
            {
                string innerExceptionMessage = ex.InnerException?.Message ?? ex.Message;
                XtraMessageBox.Show("Bakım kayıtları yüklenirken bir hata oluştu: " + innerExceptionMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kayitEditBtn_Click(object sender, EventArgs e)
        {
            int seciliBakimId = gridView1.FocusedRowHandle;
            var bakimIdObj = gridView1.GetRowCellValue(seciliBakimId, "Id");
            BakimEkle bakimEditForm = new BakimEkle((int)bakimIdObj);
            bakimEditForm.ShowDialog();
            ListeyiYenile();
        }
    }
}
