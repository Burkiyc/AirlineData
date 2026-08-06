using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AirlineDataV2.DbModels
{

    public class Personel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public virtual IList<BakimPersonel> BakimPersoneller { get; set; } = new List<BakimPersonel>();

    }
}
