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
using Menu = Hamburger_Oop_07042022.Models.Menu;
using Hamburger_Oop_07042022.Enums;
using Hamburger_Oop_07042022.Helpers;

namespace Hamburger_Oop_07042022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Extra item in extralar)
            {
                flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = item.ExtraAdi, Tag = item });
            }

            foreach (Menu item in Menuler)
            {
                cmbMenuler.Items.Add(item);
            }
        }

        public static List<Extra> extralar = new List<Extra>()
        {
            new Extra { ExtraAdi = "Ketçap", Fiyati = 1},
            new Extra { ExtraAdi = "Mayonez", Fiyati = 0.6m},
            new Extra { ExtraAdi = "Hardal", Fiyati = 1.2m},
            new Extra { ExtraAdi = "Soğan", Fiyati = 5.75m},
            new Extra { ExtraAdi = "Ranch",Fiyati = 0.4m},
            new Extra { ExtraAdi = "BBQ",Fiyati = 0.35m},
        };

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu {MenuAdi = "SteakHouse", Fiyati = 45.45m},
            new Menu { MenuAdi = "Whoper",Fiyati = 56.3m},
            new Menu { MenuAdi = "FishBurger",Fiyati = 123.12m},
            new Menu { MenuAdi = "KingChicken",Fiyati = 78.87m},
            new Menu { MenuAdi = "ChickenRoyale",Fiyati = 90}
        };

        public static List<Siparis> siparisler = new List<Siparis>();
        private void BtnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;
            if (rbKucuk.Checked) siparis.Boyutu = Boyut.Kucuk;
            else if (rbOrta.Checked) siparis.Boyutu = Boyut.Orta;
            else siparis.Boyutu = Boyut.Buyuk;

            siparis.ExtraMalzemesi = new List<Extra>();
            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                if (item.Checked) // Extra malzeme seçildiyse siparişe ekle 
                {
                    siparis.ExtraMalzemesi.Add((Extra)item.Tag);
                }
            }

            siparis.Adet = Convert.ToInt32(nmrAdet.Value);  /// Sipariş Adeti
            siparis.Hesapla();
            lstSiparisler.Items.Add(siparis);
            siparisler.Add(siparis);
            ToplamTutarYaz();
            Fonksiyon.Temizle(this.Controls);

            
            
            


        }

        public decimal ToplamTutarYaz()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                toplamTutar += ((Siparis)lstSiparisler.Items[i]).ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString();
            return toplamTutar;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarınız : " + ToplamTutarYaz().ToString()+"Satın Alma işlemini tamamlamak üzeresiniz işlemi onaylıyor musunuz ?","İşlem Sonlandırılıyor",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr == DialogResult.Yes) // İşlemi sonlamayı kabul ettiyse
            {
                lstSiparisler.Items.Clear();
                MessageBox.Show("İşleminiz sonlandırıldı teşekkür ederiz");
                lblToplamTutar.Text = "0";
            }
            else
            {
                MessageBox.Show("Bir Sorun oluştu Lütfen Tekrar Deneyiniz");
                lblToplamTutar.Text = "0";
            }
        }


     
    }
}
