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
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        private void MyMDIForm_Load(object sender, EventArgs e)
        {

        }


        void OpenForm(Form childform)  /// İlk defa açılmaya kalktığımızda çalışmaz aşağıda ki if çalışır.
        {
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.StartPosition = FormStartPosition.CenterParent;
            this.Width = childform.Width + 150;
            this.Height = childform.Height + 140;

            bool durum = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == childform.Text)
                {
                    durum = true;
                    childform.Activate();

                }
                else
                {
                    item.Close();
                }
            }
            if (durum == false)
            {
                childform.MdiParent = this;
                childform.Dock = DockStyle.Fill;
                childform.Show();
            }
        }



        private void SiparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void GünSonuRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new GunSonu());
        }

        private void MenüBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new MenuBilgileri());
        }

        private void ExtraBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ExtraBilgileri());
        }
    }
}
