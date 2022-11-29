using Hamburger_Oop_07042022.Helpers;
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
    public partial class MenuBilgileri : Form
    {
        public MenuBilgileri()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            /// KAYDET'e basıldığında Yeni bir MENU nesnesi oluşması ve statik listeye eklenip sipariş ekranında gözükebilmeli.

            Form1.Menuler.Add(new Models.Menu { MenuAdi = txtMenuAdi.Text,Fiyati = nmrFiyat.Value});
            /// Models'i menu'yü sistem nesnesi gördüğü için verdik normalde ctrl. yapıyoruz.

            Fonksiyon.Temizle(this.Controls);

        }
    }
}
