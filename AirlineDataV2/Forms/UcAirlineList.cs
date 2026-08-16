using AirlineDataV2.DbModels;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;

namespace AirlineDataV2.Forms;

public partial class UcAirlineList : XtraUserControl
{
    public UcAirlineList()
    {
        InitializeComponent();
    }

    private void UcAirlineList_Load(object sender, EventArgs e)
    {
        ListeyiYenile();
    }

    private void ListeyiYenile()
    {
        using (var context = new DbModels.AirlineDbContext())
        {
            var ucaklar = context.Ucaklar.ToList();
            gridControl1.DataSource = ucaklar;
        }
    }

    private void ucakEkleBtn_Click(object sender, EventArgs e)
    {
        UcakForm ucakForm = new UcakForm();
        ucakForm.Text = "Uçak Ekle";
        ucakForm.ShowDialog();

        ListeyiYenile();
    }

    private void ucakEditBtn_Click(object sender, EventArgs e)
    {
        int seciliSatir = gridView1.FocusedRowHandle;
        int seciliUcakId = (int)gridView1.GetRowCellValue(seciliSatir, "Id");

        using (var context = new DbModels.AirlineDbContext())
        {
            var seciliUcak = context.Ucaklar.Find(seciliUcakId);
            if (seciliUcak != null)
            {
                UcakForm ucakForm = new UcakForm(seciliUcak);
                ucakForm.Text = "Uçak Düzenle";
                ucakForm.ShowDialog();
                ListeyiYenile();
            }
        }
    }

    private void ucakSilBtn_Click(object sender, EventArgs e)
    {
        int seciliUdakId = (int)gridView1.GetFocusedRowCellValue("Id");

        if (seciliUdakId != null)
        {
            DialogResult result = XtraMessageBox.Show("Seçili uçak silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new DbModels.AirlineDbContext())
                    {
                        var secilenUcak = context.Ucaklar.Find(seciliUdakId);
                        var bakimKaydiVarMi = context.BakimKayitlari.Where(w => w.UcakId == seciliUdakId).Any();
                        if (bakimKaydiVarMi)
                        {
                            DialogResult bakimSilResult = XtraMessageBox.Show("Bu uçağa ait bakım kayıtları bulunmaktadır. Bakım kayıtlarını silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (bakimSilResult == DialogResult.Yes)
                            {
                                secilenUcak.BakimKayitlari.Clear(); // Bakım kayıtlarını temizle
                            }
                            else
                            {
                                XtraMessageBox.Show("Uçak silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        context.Ucaklar.Remove(secilenUcak);
                        context.SaveChanges();
                    }
                    ListeyiYenile();
                }

                catch (Exception ex)
                {
                    string hataMesaji = ex.InnerException?.Message ?? ex.Message;
                    XtraMessageBox.Show($"Uçak silinirken bir hata oluştu: {hataMesaji}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else return;
        }
        else
        {
            XtraMessageBox.Show("Lütfen silinecek uçağı listeden seçiniz.", "Uyarı",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {

    }

    private void gridControl1_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            var hitInfo = gridView1.CalcHitInfo(e.Location);
            if (hitInfo.InRow)
            {
                gridView1.FocusedRowHandle = hitInfo.RowHandle;
                ucPopupMenu.ShowPopup(MousePosition);
            }
        }
    }
}