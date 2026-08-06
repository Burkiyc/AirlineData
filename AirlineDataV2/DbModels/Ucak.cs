using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirlineDataV2.DbModels
{
    public class Ucak
    {
        public Ucak() { }
        public int Id { get; set; }
        [StringLength(6)] public string KuyrukNo { get; set; }
        public string Model { get; set; }
        public IList<BakimKaydi> BakimKayitlari { get; set; } = new List<BakimKaydi>();

    }
}
