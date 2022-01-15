using DAL;
using DATA;
using DATA.Enums;
using OOP_ODEV.Concretes.Genel;
using OOP_ODEV.Concretes.KoordinatorC;
using OOP_ODEV.Concretes.SubeC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{
    public partial class SubeEkleGuncelleSilForm : Form
    {
        Context db;
        KoordinatorBul kBul;
        public SubeEkleGuncelleSilForm()
        {
            kBul = new KoordinatorBul();
            db = new Context();
            InitializeComponent();
        }

        private void SubeEkleGuncelleSilForm_Load(object sender, EventArgs e)
        {
            btnSubeEkle.Enabled = db.Koordinatorler.Where(x => x.IsActive == true).Count() > 0 ? true : false;
            btnSubeGuncelle.Enabled = btnSubeSil.Enabled = false;
            foreach (Koordinator item in db.Koordinatorler)
            {
                cmbSubeKoordinatoru.Items.Add(item);
            }
            cmbSubeKoordinatoru.DataSource = db.Koordinatorler.Where(x => x.IsActive == true).ToList();
            //cmbSubeKoordinatoru.DisplayMember = db.Koordinatorler.ToString();
            //cmbSubeKoordinatoru.ValueMember = "KoordinatorID";

            SubeDoldur();
            cmbSubeKoordinatoru.SelectedIndex = -1;
        }
        void SubeDoldur()
        {
            lstSubeBilgileri.Items.Clear();

            foreach (var item in db.Subeler.Where(x => x.IsActive == true).ToList())
            {
                if (db.Koordinatorler.Where(x => x.IsActive == true).Count() > 0)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.SubeAdi;
                    if (db.Koordinatorler.FirstOrDefault(x => x.SubeID == item.SubeID && x.IsActive == true) != null)
                    {
                        string deger = db.Koordinatorler.FirstOrDefault(x => x.SubeID == item.SubeID && x.IsActive == true).ToString();
                        lvi.SubItems.Add(deger);
                    }
                    else lvi.SubItems.Add("-");
                    lvi.SubItems.Add(item.SubeMail);
                    lvi.SubItems.Add(item.SubeTelefon);
                    lvi.Tag = item;

                    lstSubeBilgileri.Items.Add(lvi);
                }
            }
        }
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            if (BosAlanKontrol.EmptyAreaControl(grpSubeBilgileri)) MessageBox.Show("Lütfen boş alan bırakmayınız");
            else
            {
                if (db.Subeler.FirstOrDefault(x => x.SubeAdi == txtSubeAdi.Text && x.IsActive == true) != null) MessageBox.Show("Şube adı önceden alınmış");
                else
                {
                    new SubeEkle(txtSubeAdi.Text,
                                                  (cmbSubeKoordinatoru.SelectedItem as Koordinator).KoordinatorID,
                                                  txtSubeMaili.Text,
                                                  txtSubeTelefon.Text,
                                                  txtSubeAdresi.Text
                                                  );
                    MessageBox.Show("İşlem başarılı");
                    Temizle.Clean(this.Controls);
                    SubeDoldur();
                }
            }
        }
        Sube selectedSube;
        private void lstSubeBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSubeBilgileri.SelectedItems.Count > 0)
            {
                btnSubeGuncelle.Enabled = btnSubeSil.Enabled = true;

                selectedSube = lstSubeBilgileri.SelectedItems[0].Tag as Sube;
                txtSubeAdi.Text = selectedSube.SubeAdi;
                txtSubeAdresi.Text = selectedSube.SubeAdresi;
                txtSubeTelefon.Text = selectedSube.SubeTelefon;
                txtSubeMaili.Text = selectedSube.SubeMail;
                if (kBul.FindIt((lstSubeBilgileri.SelectedItems[0].Tag as Sube).SubeID) != null) cmbSubeKoordinatoru.Text = kBul.FindIt((lstSubeBilgileri.SelectedItems[0].Tag as Sube).SubeID).ToString();
                else cmbSubeKoordinatoru.Text = string.Empty;
                //db.Koordinatorler.FirstOrDefault(x => x.SubeID == selectedSube.SubeID);
            }
        }

        private void btnSubeGuncelle_Click(object sender, EventArgs e)
        {
            if (BosAlanKontrol.EmptyAreaControl(grpSubeBilgileri)) MessageBox.Show("Lütfen boş alan bırakmayınız");
            else
            {
                if (db.Subeler.FirstOrDefault(x => x.SubeAdi == txtSubeAdi.Text && x.IsActive == true && x.SubeID != selectedSube.SubeID) != null) MessageBox.Show("Şube adı önceden alınmış");
                else
                {
                    selectedSube.SubeAdi = txtSubeAdi.Text;
                    selectedSube.SubeMail = txtSubeMaili.Text;
                    selectedSube.SubeTelefon = txtSubeTelefon.Text;
                    selectedSube.SubeAdresi = txtSubeAdresi.Text;

                    new SubeGuncelle(selectedSube,
                    (cmbSubeKoordinatoru.SelectedItem as Koordinator).KoordinatorID);

                    MessageBox.Show("İşlem başarılı");
                    Temizle.Clean(this.Controls);
                    btnSubeGuncelle.Enabled = false;
                    SubeDoldur();
                }
            }
        }

        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            if (lstSubeBilgileri.SelectedItems.Count <= 0) MessageBox.Show("Lütfen şube seçin");
            else
            {
                new SubeSil((lstSubeBilgileri.SelectedItems[0].Tag as Sube).SubeID);
                MessageBox.Show("İşlem başarılı");
                Temizle.Clean(this.Controls);
                btnSubeGuncelle.Enabled = btnSubeSil.Enabled = false;
                SubeDoldur();
            }
        }
    }
}
