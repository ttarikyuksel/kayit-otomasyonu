﻿using DAL;
using DATA;
using OOP_ODEV.Concretes;
using OOP_ODEV.Concretes.Genel;
using OOP_ODEV.Concretes.SubeC;
using OOP_ODEV.Concretes.YoneticiC;
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
    public partial class Form1 : Form
    {
        Context db;
        public Form1()
        {
            db = new Context();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region On First Launch => Automatically Create Adminstrator for add to database
            if (db.Yoneticiler.Count() == 0)
            {
                new YoneticiOlustur("Bilge",
                    "Adam",
                    DateTime.Now,
                    "11223344",
                    DATA.Enums.Gorevler.Yonetici,
                    "admin@bilgeadam.com", "1234", null);
            }
            if (db.Subeler.Count() == 0)
            {
                new SubeEkle("Sube Yok", "pasifSube", "pasifSube", "pasifSube");
            }
            #endregion


            txtGirisParola.PasswordChar = '*';
        }

        private void chkParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtGirisParola.PasswordChar = chkParolaGoster.Checked ? '\0' : '*';
            chkParolaGoster.Text = chkParolaGoster.Checked ? "Parolayı Gizle" : "Parolayı Göster";
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (BosAlanKontrol.EmptyAreaControl(grpGirisPaneli)) MessageBox.Show("Lütfen boş alan bırakmayınız.");
            else
            {
                try
                {

                    if (db.Koordinatorler.FirstOrDefault(x => x.Email == txtGirisMailAdresi.Text && x.Sifre == txtGirisParola.Text && x.IsActive == true) != null)
                    {
                        // TARIK BURA İLE OYNAMA YAPTINNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
                        Koordinator koordinator = db.Koordinatorler.FirstOrDefault(x => x.Email == txtGirisMailAdresi.Text && x.Sifre == txtGirisParola.Text);
                        if ((koordinator.SubeID != null) && (db.Subeler.FirstOrDefault(x => x.SubeID == koordinator.SubeID).IsActive == true))
                        {
                            KoordinatorForm koordinatorForm = new KoordinatorForm(this, koordinator);
                            koordinatorForm.Show();
                            Temizle.Clean(this.Controls);
                            this.Hide();
                        }
                        else MessageBox.Show("LÜTFEN ŞUBE EKLEYİN");
                    }
                    else if (db.Yoneticiler.FirstOrDefault(x => x.Email == txtGirisMailAdresi.Text && x.Sifre == txtGirisParola.Text && x.IsActive == true) != null)
                    {
                        YoneticiForm yoneticiForm = new YoneticiForm(this);
                        yoneticiForm.gelenYonetici = db.Yoneticiler.FirstOrDefault(x => x.Email == txtGirisMailAdresi.Text);
                        yoneticiForm.Show();
                        Temizle.Clean(this.Controls);
                        this.Hide();
                    }
                    else if (db.Egitmenler.FirstOrDefault(x => x.Email == txtGirisMailAdresi.Text && x.Sifre == txtGirisParola.Text && x.IsActive == true) != null)
                    {
                        Egitmen egitmen = db.Egitmenler.FirstOrDefault(x => x.Email == txtGirisMailAdresi.Text && x.Sifre == txtGirisParola.Text);
                        EgitmenForm egitmenForm = new EgitmenForm(this, egitmen);
                        egitmenForm.Show();
                        Temizle.Clean(this.Controls);
                        this.Hide();
                    }
                    else MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


