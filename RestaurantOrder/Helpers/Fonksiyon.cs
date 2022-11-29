using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_Oop_07042022.Helpers
{
    public static class Fonksiyon
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox) item.Text = " ";
                else if (item is CheckBox) ((CheckBox)item).Checked = false;
                else if (item is RadioButton)
                {
                    if (item.Name == "rbkucuk") // Default'ta ki gibi radioKucuk checkli gelsin diğerleri checksiz gelsin.
                    {
                        ((RadioButton)item).Checked = true;
                    }
                    else ((RadioButton)item).Checked = false;
                }
                else if (item is NumericUpDown) ((NumericUpDown)item).Value = 1;
                else if (item is GroupBox) Temizle(((GroupBox)item).Controls);
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
                else if (item is FlowLayoutPanel) Temizle(((FlowLayoutPanel)item).Controls);

                
            }
        }
    }
}
