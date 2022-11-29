using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hamburger_Oop_07042022.Helpers;
using Hamburger_Oop_07042022.Models;

namespace Hamburger_Oop_07042022
{
    public partial class ExtraBilgileri : Form
    {
        public ExtraBilgileri()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Form1.extralar.Add(new Extra { ExtraAdi = txtExtra.Text, Fiyati = nmrExtraFiyatı.Value });
            Fonksiyon.Temizle(this.Controls);
        }
    }
}
