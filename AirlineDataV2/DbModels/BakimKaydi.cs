using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineDataV2.DbModels
{
    public class BakimKaydi
    {
        public int Id { get; set; }
        public int UcakId { get; set; }
        public virtual Ucak Ucak { get; set; }
        public virtual IList<BakimPersonel> BakimPersoneller { get; set; } = new List<BakimPersonel>();
        public DateTime BakimTarihi { get; set; }

    }
}
