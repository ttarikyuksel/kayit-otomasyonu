using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.Genel
{
    public static class BosAlanKontrol
    {
        public static bool EmptyAreaControl(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == string.Empty) return true;
                    if ((item.Name == "txtKullaniciMailAdresi" || item.Name == "txtOgrenciMailAdresi") && (!item.Text.Contains('@') || !item.Text.Contains('.'))) return true;
                }
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == -1 && ((ComboBox)item).Enabled == true) return true;
                }
                else if (item is DateTimePicker)
                {
                    if (((DateTimePicker)item).Name.EndsWith("DTarihi") && ((((DateTimePicker)item).Value.Year > DateTime.Now.Year) || (DateTime.Now.Year - ((DateTimePicker)item).Value.Year < 15))) return true;
                    else if (((DateTimePicker)item).Name == "dtSinifBaslangicTarihi")
                    {
                        if (((DateTimePicker)item).Value < DateTime.Now.AddDays(-1)) return true;
                    }
                }
                else if (item is MaskedTextBox)
                {
                    if (((MaskedTextBox)item).MaskFull == false) return true;
                }
            }
            return false;
        }
    }
}


