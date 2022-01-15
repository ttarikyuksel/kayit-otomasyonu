using DAL;
using DATA;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{
    public partial class SubeRaporForm : Form
    {
        Koordinator gelenKoordinator;
        Context db;
        public SubeRaporForm(Koordinator koordinator)
        {
            db = new Context();
            gelenKoordinator = koordinator;
            InitializeComponent();
        }
        public SubeRaporForm()
        {
            db = new Context();
            InitializeComponent();
        }
        private void SubeRaporForm_Load(object sender, EventArgs e)
        {
            if (gelenKoordinator != null)
            {
                cmbSubeSec.DataSource = db.Subeler.Where(x => x.SubeID == gelenKoordinator.SubeID && x.IsActive == true).ToList();
                cmbSubeSec.DisplayMember = "SubeAdi";
                cmbSubeSec.ValueMember = "SubeID";
                if (cmbSubeSec.Items.Count > 0) cmbSubeSec.SelectedIndex = 0;
                cmbSubeSec.Enabled = false;



                if (db.Subeler.FirstOrDefault(x => x.SubeID == (int)cmbSubeSec.SelectedValue) != null)
                {
                    Sube seciliSube = db.Subeler.FirstOrDefault(x => x.SubeID == (int)cmbSubeSec.SelectedValue);



                    if (db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblKoordinatorSayisi.Text = db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                    else lblKoordinatorSayisi.Text = "0";



                    if (db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblEgitmenSayisi.Text = db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                    else lblEgitmenSayisi.Text = "0";



                    if (db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblsinifSayisi.Text = db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                    else lblsinifSayisi.Text = "0";



                    int ogrenciSayisi = 0;
                    foreach (Sinif sinif in db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList())
                    {
                        foreach (var ogrenci in db.Ogrenciler.Where(x => x.SinifKodu == sinif.SinifKodu && x.IsActive == true).ToList())
                        {
                            ogrenciSayisi++;
                        }
                    }
                    if (ogrenciSayisi > 0) lblOgrenciSayisi.Text = ogrenciSayisi.ToString();
                    else lblOgrenciSayisi.Text = "0";

                    #region aaaa
                    int toplamsaat = 0;

                    if (db.Siniflar.Where(x => x.SubeID == gelenKoordinator.SubeID && x.IsActive == true).ToList() != null)
                    {
                        List<Sinif> siniflarim = db.Siniflar.Where(x => x.SubeID == gelenKoordinator.SubeID && x.IsActive == true).ToList();

                        foreach (var item in siniflarim)
                        {
                            int gelensaat = db.Egitimler.FirstOrDefault(x => x.EgitimID == item.EgitimID && x.IsActive == true).EgitimSuresi;
                            toplamsaat = toplamsaat + gelensaat;
                        }
                    }

                    if (toplamsaat > 0) lblVerilenDersSaati.Text = toplamsaat.ToString();
                    else lblVerilenDersSaati.Text = "0";
                    #endregion


                    int toplamegitmen = 0;
                    if (db.Egitmenler.Where(x => x.SubeID == gelenKoordinator.SubeID && x.IsActive == true).ToList() != null) toplamegitmen = db.Egitmenler.Where(x => x.SubeID == gelenKoordinator.SubeID && x.IsActive == true).Count();


                    if (toplamegitmen > 0) lblVerilenDersEgitmenOrt.Text = (toplamsaat / toplamegitmen).ToString();
                    else
                    {
                        lblVerilenDersEgitmenOrt.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Şube bilgisi bulunamadı");
                }
            }
            else
            {
                cmbSubeSec.Text = "";
                cmbSubeSec.DisplayMember = "SubeAdi";
                cmbSubeSec.ValueMember = "SubeID";
                cmbSubeSec.DataSource = db.Subeler.Where(x => x.IsActive == true).ToList();
            }
        }

        private void btnPDFKaydet_Click(object sender, EventArgs e)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "Cp1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);



            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "PDF Kaydet";
            sfd.Filter = "PDF Files (*.pdf) | *.pdf";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document rapor = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(rapor, new FileStream(sfd.FileName, FileMode.CreateNew));
                if (rapor.IsOpen() == false)
                {
                    rapor.Open();
                }
                rapor.Add(new Paragraph(new Phrase("SUBE RAPOR FORMU", fontNormal)));
                rapor.Add(new Paragraph(new Phrase(label3.Text + lblKoordinatorSayisi.Text, fontNormal)));
                rapor.Add(new Paragraph(new Phrase(label4.Text + lblEgitmenSayisi.Text, fontNormal)));
                rapor.Add(new Paragraph(new Phrase(label5.Text + lblOgrenciSayisi.Text, fontNormal)));
                rapor.Add(new Paragraph(new Phrase(label15.Text + lblsinifSayisi.Text, fontNormal)));
                rapor.Add(new Paragraph(new Phrase(verilenDersSaati.Text + lblVerilenDersSaati.Text, fontNormal)));
                rapor.Add(new Paragraph(new Phrase(label11.Text + lblVerilenDersEgitmenOrt.Text, fontNormal)));
                rapor.Close();
                MessageBox.Show("PDF Oluşturuldu");
            }
        }

        private void cmbSubeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gelenKoordinator == null)
            {
                Sube seciliSube = db.Subeler.FirstOrDefault(x => x.SubeID == (int)cmbSubeSec.SelectedValue);



                if (db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblKoordinatorSayisi.Text = db.Koordinatorler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblKoordinatorSayisi.Text = "0";



                if (db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblEgitmenSayisi.Text = db.Egitmenler.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblEgitmenSayisi.Text = "0";



                if (db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count > 0) lblsinifSayisi.Text = db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList().Count.ToString();
                else lblsinifSayisi.Text = "0";



                int ogrenciSayisi = 0;
                foreach (Sinif sinif in db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID && x.IsActive == true).ToList())
                {
                    foreach (var ogrenci in db.Ogrenciler.Where(x => x.SinifKodu == sinif.SinifKodu && x.IsActive == true).ToList())
                    {
                        ogrenciSayisi++;
                    }
                }
                if (ogrenciSayisi > 0) lblOgrenciSayisi.Text = ogrenciSayisi.ToString();
                else lblOgrenciSayisi.Text = "0";



                List<Sinif> siniflarim = db.Siniflar.Where(x => x.SubeID == seciliSube.SubeID).ToList();
                int toplamsaat = 0;
                foreach (var item in siniflarim)
                {
                    int gelensaat = db.Egitimler.FirstOrDefault(x => x.EgitimID == item.EgitimID && x.IsActive == true).EgitimSuresi;
                    toplamsaat = toplamsaat + gelensaat;
                }

                if (toplamsaat > 0) lblVerilenDersSaati.Text = toplamsaat.ToString();
                else lblVerilenDersSaati.Text = "0";



                int toplamegitmen = db.Siniflar.Where(x => x.SubeID == x.SubeID && x.IsActive == true).Count();



                if (toplamsaat > 0 && toplamegitmen > 0) lblVerilenDersEgitmenOrt.Text = (toplamsaat / toplamegitmen).ToString();
                else lblVerilenDersEgitmenOrt.Text = "0";
            }
        }
    }
}
