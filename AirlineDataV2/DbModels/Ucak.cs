using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineDataV2.DbModels
{
    public class Ucak
    {
        public Ucak() { }
        public int Id { get; set; }
        public string KuyrukNo { get; set; }
        public string Model { get; set; }
        public string AlimYili { get; set; }
        public decimal UcusSaati { get; set; }
        public string SimdikiMeydan { get; set; }

    }
}
