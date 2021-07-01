using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriq
{
    class Satish
    {
        public string Date { get; set; }
        public double Mebleg { get; set; }

        public List<SatishItem> siyahi = new List<SatishItem>();

        private static int _id;
        public readonly int ID;

        public Satish()
        {
            ID = ++_id;
            Mebleg = 0;
        }

        public override string ToString()
        {
            return $"Satish Nomresi: {ID} | Tarix: {Date.ToString()} | Mehsul sayi: {siyahi.Count} | Yekun Mebleg: {Mebleg}";
        }
    }
}

