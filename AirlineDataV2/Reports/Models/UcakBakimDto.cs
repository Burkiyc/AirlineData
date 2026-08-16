using AirlineDataV2.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirlineDataV2.Reports.Models
{
    public class UcakBakimDto
    {
        [Display(Name = "İş Emri Numarası")]
        public int IsEmriNumarasi { get; set; }


        [Display(Name = "Kuyruk No/Uçak Tescil Kodu")]
        public string KuyrukNo { get; set; }

        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Toplam Uçuş Saati")]
        public int UcusSaati { get; set; }

        [Display(Name = "Bakım Tarihi")]
        public DateTime BakimTarihi { get; set; }

        [Display(Name = "Personeller")]
        public IList<BakimPersonel> BakimPersoneller { get; set; }

        [Display(Name = "Bakımın Yapıldığı Hangar")]
        public string Hangar { get; set; }

        [Display(Name = "ATA Kategori Kodu")]
        public string AtaKategoriKodu { get; set; }

        [Display(Name = "Görev Tanımı")]
        public string GorevTanimi { get; set; }

        [Display(Name = "Teşhis")]
        public string Teshis { get; set; }

        [Display(Name = "Arıza/Talep Sebebi")]
        public string ArızaTalepSebebi { get; set; }

        [Display(Name = "Uygulanan İşlem")]
        public string UygulananIslem { get; set; }

        [Display(Name = "Servise Verilme Onayı(CRS)")]
        public string CRS { get; set; } = "Certifies that the work specified, except as otherwise specified, was carried out in accordance with Part-145 and in respect to that work, the aircraft/aircraft component is considered ready for release to service.";

    }
}
