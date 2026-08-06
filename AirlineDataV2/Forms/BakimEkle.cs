using AirlineDataV2.DbModels;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineDataV2.Forms
{
    public partial class BakimEkle : XtraForm
    {
        int _bakimId;
        public BakimEkle()
        {
            InitializeComponent();
            onaylaBtn.Visible = false;
        }
        public BakimEkle(int bakimId) : this()
        {
            _bakimId = bakimId;
            Text = "Bakım Kaydı Düzenle";
            bakimEkleBtn.Visible = false;
            onaylaBtn.Visible = true;
            labelControl4.Visible = true;
            dateEdit1.Visible = true;
        }

        private void BakimEkle_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    var ucaklar = context.Ucaklar
                        .Select(u => new
                        {
                            u.Id,
                            u.KuyrukNo,
                            u.Model,
                            ToplamBakim = u.BakimKayitlari.Count()
                        })
                        .ToList();

                    UcakLookUpEdit.Properties.DataSource = ucaklar;
                    UcakLookUpEdit.Properties.DisplayMember = "KuyrukNo";
                    UcakLookUpEdit.Properties.ValueMember = "Id";
                    UcakLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ToplamBakim", "ToplamBakım"));

                    var personeller = context.Personeller
                        .Select(p => new Personel
                        {
                            Id = p.Id,
                            AdSoyad = p.AdSoyad
                        })
                        .ToList();

                    PersLookUpEdit.Properties.DataSource = personeller;
                    PersLookUpEdit.Properties.DisplayMember = "AdSoyad";
                    PersLookUpEdit.Properties.ValueMember = "Id";

                    assgndPersList.DataSource = assignedPersoneller;
                    assgndPersList.DisplayMember = "AdSoyad";
                    assgndPersList.ValueMember = "Id";

                    if (_bakimId != 0)
                    {
                        var bakimKaydi = context.BakimKayitlari
                            .Include(bk => bk.BakimPersoneller)
                            .ThenInclude(bp => bp.Personel)
                            .FirstOrDefault(b => b.Id == _bakimId);
                        if (bakimKaydi == null)
                        {
                            XtraMessageBox.Show("Bakım kaydı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            return;
                        }
                        UcakLookUpEdit.EditValue = bakimKaydi.UcakId;
                        List<Personel> _personeller = bakimKaydi.BakimPersoneller
                            .Select(bp => new Personel
                            {
                                Id = bp.Personel.Id,
                                AdSoyad = bp.Personel.AdSoyad
                            })
                            .ToList();
                        assignedPersoneller.AddRange(_personeller);
                        assgndPersList.Refresh();

                        var secilenBakim = context.BakimKayitlari.Find(_bakimId);
                        dateEdit1.DateTime = secilenBakim.BakimTarihi;
                    }
                }

            }
            catch (ArgumentException ex)
            {
                XtraMessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //else
        //{
        //    try
        //    {
        //        using (var context = new DbModels.AirlineDbContext())
        //        {
        //            var bakim = context.Ucaklar.FirstOrDefault(u => u.Id == _bakimKaydi.Id);
        //            UcakLookUpEdit.EditValue = context.Ucaklar.FirstOrDefault(u => u.Id == _bakimKaydi.UcakId)?.Id;
        //            UcakLookUpEdit.Enabled = false;
        //            assignedPersoneller = _bakimKaydi.BakimPersoneller
        //                .Select(bp => new Personel
        //                {
        //                    Id = bp.Personel.Id,
        //                    AdSoyad = bp.Personel.AdSoyad
        //                })
        //                .ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void bakimEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DbModels.AirlineDbContext())
                {
                    // Bakım ekleme işlemleri

                    var secilenUcak = context.Ucaklar.FirstOrDefault(u => u.Id == (int)UcakLookUpEdit.EditValue);
                    var yeniBakimKaydi = new DbModels.BakimKaydi
                    {
                        UcakId = secilenUcak.Id,
                        BakimTarihi = DateTime.UtcNow,
                        BakimPersoneller = assignedPersoneller.Select(p => new BakimPersonel
                        {
                            PersonelId = p.Id
                        }).ToList()
                    };
                    secilenUcak.BakimKayitlari.Add(yeniBakimKaydi);
                    context.SaveChanges();
                }
                this.Close();
            }
            catch (ArgumentException ex)
            {
                XtraMessageBox.Show($"Bakım eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<Personel> assignedPersoneller = new List<Personel>();

        private void assignPersBtn_Click(object sender, EventArgs e)
        {
            //assignedPersoneller.Add(new Personel { Id = (int)PersLookUpEdit.EditValue, AdSoyad = PersLookUpEdit.Text });
            assignedPersoneller.Add(PersLookUpEdit.GetSelectedDataRow() as Personel);

            assgndPersList.Refresh();
        }

        private void assgndPersList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = assgndPersList.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    assignedPersoneller.RemoveAt(index);
                    assgndPersList.Refresh();
                }
            }
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AirlineDbContext())
                {
                    var secilenBakimKaydi = context.BakimKayitlari.Find(_bakimId);

                    secilenBakimKaydi.UcakId = (int)UcakLookUpEdit.EditValue;
                    secilenBakimKaydi.BakimTarihi = dateEdit1.DateTime;

                    var mevcutKayıtlar = context.BakimPersonel
                        .Where(bp => bp.BakimId == secilenBakimKaydi.Id)
                        .ToList();
                    context.BakimPersonel.RemoveRange(mevcutKayıtlar);
                    foreach (var p in assignedPersoneller)
                    {
                        secilenBakimKaydi.BakimPersoneller.Add(new BakimPersonel
                        {
                            BakimId = secilenBakimKaydi.Id,
                            PersonelId = p.Id
                        });
                    }

                    //context.Entry(secilenBakimKaydi).State = EntityState.Modified;
                    context.SaveChanges();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Hata oluştu: {ex.InnerException?.Message ?? ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
