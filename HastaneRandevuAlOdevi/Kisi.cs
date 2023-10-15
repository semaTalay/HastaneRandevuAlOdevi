using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuAlOdevi
{
    public class Kisi
    {
        


        public string Tc { get; set; }
        public  string  AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public string Poliklinik { get; set; }
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }


        public override string ToString()
        {
            return $"{AdSoyad} - {Poliklinik} - {Tarih} - {Saat}";
        }




    }
}
