using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineDataV2.DbModels
{
    public class BakimKaydi
    {
        public BakimKaydi()
        {
            Personeller = new List<Personel>();
        }
        public int Id { get; set; }
        public Ucak Ucak { get; set; }
        public List<Personel> Personeller { get; set; }
        public DateTime BakimTarihi { get; set; }

    }
}
