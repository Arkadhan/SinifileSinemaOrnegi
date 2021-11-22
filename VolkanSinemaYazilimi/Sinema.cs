using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolkanSinemaYazilimi
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;
        const byte tamBilet=25;

        public Sinema(string salonNumarası, int koltukSayisi)
        {
            toplamKoltukSayisi = koltukSayisi;
            salonNumarası = salonNo;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;      
        }
        public void BiletSat()
        {
            if (bosKoltukSayisi >= 0)
            {
                bosKoltukSayisi--;
                bakiye += tamBilet;
            }
        }
        public void BiletIptal()
        {
            bosKoltukSayisi++;
            bakiye -= tamBilet;
        }
        public int BosKoltukSayisi()
        {   
            return bosKoltukSayisi;
        }
        public int DoluKoltukSayisi()
        {
            return toplamKoltukSayisi - bosKoltukSayisi;
        }
        public double BakiyeOgrek()
        {
            return bakiye;
        }
    
    }
    
}
