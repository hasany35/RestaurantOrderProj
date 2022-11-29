using Hamburger_Oop_07042022.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Oop_07042022.Models
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }

        public Boyut Boyutu { get; set; }

        public List<Extra> ExtraMalzemesi { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            switch (Boyutu)  // Switch +  tab*2 ile çağırdığımızda dışarı hiç çıkmadan değişkeni belirledikten sonra otomatik çağırır.
            {


                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 1.1m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 1.3m;
                    break;

            }

            foreach (Extra item in ExtraMalzemesi)
            {
                ToplamTutar += item.Fiyati;
            }

            ToplamTutar = ToplamTutar * Adet;

        }

        public override string ToString()
        {
            if (ExtraMalzemesi.Count<1) // Ekstra Malzeme Almadısya,
            {
                return string.Format("{0} Menu , X {1} Adet, {2} Boy , Toplam : {3}",SeciliMenu.MenuAdi,Adet,Boyutu,ToplamTutar);

            }
            else
            {
                string exMalzemeler = null;
                foreach (Extra item in ExtraMalzemesi)
                {
                    exMalzemeler += item.ExtraAdi + ",";
                    
                }
                return string.Format("{0} Menu , X {1} Adet, {2} Boy ,({3}),Toplam : {4}",
                        SeciliMenu.MenuAdi, Adet, Boyutu, exMalzemeler, ToplamTutar);
            }
        }
    }
}
