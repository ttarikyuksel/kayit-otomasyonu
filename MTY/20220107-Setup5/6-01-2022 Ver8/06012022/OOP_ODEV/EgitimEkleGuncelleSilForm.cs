using DAL;
using DATA;
using OOP_ODEV.Concretes.EgitimC;
using OOP_ODEV.Concretes.Genel;
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
    public partial class EgitimEkleGuncelleSilForm : Form
    {
        Context db;
        public EgitimEkleGuncelleSilForm()
        {
            db = new Context();
            InitializeComponent();
        }
        private void EgitimEkleGuncelleSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEgitimEkle_Click(object sender, EventArgs e)
        {
            if (db.Egitimler.FirstOrDefault(x => x.EgitimAdi == txtEgitimAdi.Text && x.EgitimSuresi == nmrDersSuresi.Value) != null) MessageBox.Show("Aynı eğitim mevcut. Lütfen bilgileri kontrol edin");
            else
            {
                if (BosAlanKontrol.EmptyAreaControl(grpEgitimBilgileri)) MessageBox.Show("Lütfen boş alan bırakmayın");
                else
                {
                    new EgitimEkle(txtEgitimAdi.Text, txtEgitimAciklama.Text, (int)nmrDersSuresi.Value);
                    MessageBox.Show("İşlem başarılı");
                    Listele();
                    Temizle.Clean(this.Controls);
                }
            }
        }
        public void Listele()
        {
            lstEgitimListesi.Items.Clear();
            foreach (var item in db.Egitimler.Where(x => x.IsActive == true).ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.EgitimAdi;
                lvi.SubItems.Add(item.EgitimSuresi.ToString());
                lvi.SubItems.Add(item.EgitimAciklamasi);
                lvi.Tag = item;
                lstEgitimListesi.Items.Add(lvi);
            }
        }


        Egitim egitims;
        private void lstEgitimListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEgitimListesi.SelectedItems.Count > 0)
            {
                egitims = lstEgitimListesi.SelectedItems[0].Tag as Egitim;
                txtEgitimAdi.Text = egitims.EgitimAdi;
                txtEgitimAciklama.Text = egitims.EgitimAciklamasi;
                nmrDersSuresi.Value = egitims.EgitimSuresi;
            }
        }

        private void btnEgitimGuncelle_Click(object sender, EventArgs e)
        {
            if (lstEgitimListesi.SelectedItems.Count > 0)
            {
                if (db.Egitimler.FirstOrDefault(x => x.EgitimAdi == txtEgitimAdi.Text && x.EgitimSuresi == nmrDersSuresi.Value && x.EgitimID != egitims.EgitimID) != null) MessageBox.Show("Aynı eğitim mevcut. Lütfen bilgileri kontrol edin");
                else
                {
                    if (BosAlanKontrol.EmptyAreaControl(grpEgitimBilgileri)) MessageBox.Show("Lütfen boş alan bırakmayın");
                    else
                    {
                        egitims.EgitimAciklamasi = txtEgitimAciklama.Text;
                        egitims.EgitimSuresi = (int)nmrDersSuresi.Value;
                        egitims.EgitimAdi = txtEgitimAdi.Text;
                        new EgitimGuncelle(egitims);
                        MessageBox.Show("İşlem başarılı");
                        Listele();
                        Temizle.Clean(this.Controls);
                    }
                }
            }
            else MessageBox.Show("Lütfen eğitim seçin");
        }

        private void btnEgitimSil_Click(object sender, EventArgs e)
        {
            if (lstEgitimListesi.SelectedItems.Count > 0)
            {
                new EgitimSil(((Egitim)lstEgitimListesi.SelectedItems[0].Tag).EgitimID);
                MessageBox.Show("İşlem başarılı");
                Temizle.Clean(this.Controls);
                Listele();
            }
            else MessageBox.Show("Lütfen eğitim seçin");
        }
    }
}
