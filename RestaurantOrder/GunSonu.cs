using Hamburger_Oop_07042022.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_Oop_07042022
{
    public partial class GunSonu : Form
    {
        public GunSonu()
        {
            InitializeComponent();
        }

        private void GunSonu_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal exMalzemeGelir = 0;
            int satisAdedi = 0;

            // Siparis alma formu üzerinde yarattığımız static işaretli listeye buradan ulaşıp her bir siparişi tek tek gezmek istiyoruz ki istediğimiz bilgilere ulaşalım.
            foreach (Siparis item in Form1.siparisler) /// siparisler form1'de static olduğu için oradan çektik, "Siparisleri" using'lere ekledik
            {
                ciro += item.ToplamTutar;
                foreach (Extra ex in item.ExtraMalzemesi)
                {
                    exMalzemeGelir += ex.Fiyati;
                }

                satisAdedi += item.Adet;
                lstSiparisler.Items.Add(item);
            }

            lblExtraMalzeme.Text = exMalzemeGelir.ToString();
            lblCiro.Text = ciro.ToString();
            lblSatılanUrun.Text = satisAdedi.ToString();
            lblSiparisSayisi.Text = lstSiparisler.Items.Count.ToString();
        }
    }
}
