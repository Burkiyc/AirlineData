using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineDataV2.DbModels
{
    public class BakimPersonel
    {
        public int BakimId { get; set; }
        public virtual BakimKaydi BakimKaydi { get; set; }

        public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }

    }
}
