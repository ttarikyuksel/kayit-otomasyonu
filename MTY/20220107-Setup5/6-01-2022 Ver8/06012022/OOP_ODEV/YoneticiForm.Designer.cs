﻿namespace OOP_ODEV
{
    partial class YoneticiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msYoneticiForm = new System.Windows.Forms.MenuStrip();
            this.tsmKullaniciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKullaniciEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKullaniciGuncelleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSubeIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSubeEkleGuncelleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEgitimIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEgitimEkleGuncellSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRaporIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGenelRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSubeRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSinifRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.msYoneticiForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msYoneticiForm
            // 
            this.msYoneticiForm.BackColor = System.Drawing.SystemColors.Control;
            this.msYoneticiForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.msYoneticiForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKullaniciIslemleri,
            this.tsmSubeIslemleri,
            this.tsmEgitimIslemleri,
            this.tsmRaporIslemleri});
            this.msYoneticiForm.Location = new System.Drawing.Point(0, 0);
            this.msYoneticiForm.Name = "msYoneticiForm";
            this.msYoneticiForm.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.msYoneticiForm.Size = new System.Drawing.Size(1311, 27);
            this.msYoneticiForm.TabIndex = 0;
            this.msYoneticiForm.Text = "menuStrip1";
            // 
            // tsmKullaniciIslemleri
            // 
            this.tsmKullaniciIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmKullaniciEkle,
            this.tsmKullaniciGuncelleSil});
            this.tsmKullaniciIslemleri.Name = "tsmKullaniciIslemleri";
            this.tsmKullaniciIslemleri.Size = new System.Drawing.Size(136, 21);
            this.tsmKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            // 
            // tsmKullaniciEkle
            // 
            this.tsmKullaniciEkle.Name = "tsmKullaniciEkle";
            this.tsmKullaniciEkle.Size = new System.Drawing.Size(162, 22);
            this.tsmKullaniciEkle.Text = "Ekle";
            this.tsmKullaniciEkle.Click += new System.EventHandler(this.tsmKullaniciEkle_Click);
            // 
            // tsmKullaniciGuncelleSil
            // 
            this.tsmKullaniciGuncelleSil.Name = "tsmKullaniciGuncelleSil";
            this.tsmKullaniciGuncelleSil.Size = new System.Drawing.Size(162, 22);
            this.tsmKullaniciGuncelleSil.Text = "Güncelle / Sil";
            this.tsmKullaniciGuncelleSil.Click += new System.EventHandler(this.tsmKullaniciGuncelleSil_Click);
            // 
            // tsmSubeIslemleri
            // 
            this.tsmSubeIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSubeEkleGuncelleSil});
            this.tsmSubeIslemleri.Name = "tsmSubeIslemleri";
            this.tsmSubeIslemleri.Size = new System.Drawing.Size(114, 21);
            this.tsmSubeIslemleri.Text = "Şube İşlemleri";
            // 
            // tsmSubeEkleGuncelleSil
            // 
            this.tsmSubeEkleGuncelleSil.Name = "tsmSubeEkleGuncelleSil";
            this.tsmSubeEkleGuncelleSil.Size = new System.Drawing.Size(202, 22);
            this.tsmSubeEkleGuncelleSil.Text = "Ekle / Güncelle / Sil";
            this.tsmSubeEkleGuncelleSil.Click += new System.EventHandler(this.tsmSubeEkleGuncelleSil_Click);
            // 
            // tsmEgitimIslemleri
            // 
            this.tsmEgitimIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEgitimEkleGuncellSil});
            this.tsmEgitimIslemleri.Name = "tsmEgitimIslemleri";
            this.tsmEgitimIslemleri.Size = new System.Drawing.Size(122, 21);
            this.tsmEgitimIslemleri.Text = "Eğitim İşlemleri";
            // 
            // tsmEgitimEkleGuncellSil
            // 
            this.tsmEgitimEkleGuncellSil.Name = "tsmEgitimEkleGuncellSil";
            this.tsmEgitimEkleGuncellSil.Size = new System.Drawing.Size(202, 22);
            this.tsmEgitimEkleGuncellSil.Text = "Ekle / Güncelle / Sil";
            this.tsmEgitimEkleGuncellSil.Click += new System.EventHandler(this.tsmEgitimEkleGuncellSil_Click);
            // 
            // tsmRaporIslemleri
            // 
            this.tsmRaporIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGenelRapor,
            this.tsmSubeRaporu,
            this.tsmSinifRaporu});
            this.tsmRaporIslemleri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmRaporIslemleri.Name = "tsmRaporIslemleri";
            this.tsmRaporIslemleri.Size = new System.Drawing.Size(119, 21);
            this.tsmRaporIslemleri.Text = "Rapor İşlemleri";
            // 
            // tsmGenelRapor
            // 
            this.tsmGenelRapor.BackColor = System.Drawing.SystemColors.Control;
            this.tsmGenelRapor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmGenelRapor.Name = "tsmGenelRapor";
            this.tsmGenelRapor.Size = new System.Drawing.Size(180, 22);
            this.tsmGenelRapor.Text = "Genel Rapor";
            this.tsmGenelRapor.Click += new System.EventHandler(this.tsmGenelRapor_Click);
            // 
            // tsmSubeRaporu
            // 
            this.tsmSubeRaporu.BackColor = System.Drawing.SystemColors.Control;
            this.tsmSubeRaporu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmSubeRaporu.Name = "tsmSubeRaporu";
            this.tsmSubeRaporu.Size = new System.Drawing.Size(180, 22);
            this.tsmSubeRaporu.Text = "Şube Raporu";
            this.tsmSubeRaporu.Click += new System.EventHandler(this.tsmSubeRaporu_Click);
            // 
            // tsmSinifRaporu
            // 
            this.tsmSinifRaporu.BackColor = System.Drawing.SystemColors.Control;
            this.tsmSinifRaporu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmSinifRaporu.Name = "tsmSinifRaporu";
            this.tsmSinifRaporu.Size = new System.Drawing.Size(180, 22);
            this.tsmSinifRaporu.Text = "Sınıf Raporu";
            this.tsmSinifRaporu.Click += new System.EventHandler(this.tsmSinifRaporu_Click);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 799);
            this.Controls.Add(this.msYoneticiForm);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msYoneticiForm;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "YoneticiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoneticiForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YoneticiForm_FormClosed);
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.msYoneticiForm.ResumeLayout(false);
            this.msYoneticiForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msYoneticiForm;
        private System.Windows.Forms.ToolStripMenuItem tsmKullaniciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmKullaniciEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmKullaniciGuncelleSil;
        private System.Windows.Forms.ToolStripMenuItem tsmRaporIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmGenelRapor;
        private System.Windows.Forms.ToolStripMenuItem tsmSubeRaporu;
        private System.Windows.Forms.ToolStripMenuItem tsmSinifRaporu;
        private System.Windows.Forms.ToolStripMenuItem tsmSubeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmSubeEkleGuncelleSil;
        private System.Windows.Forms.ToolStripMenuItem tsmEgitimIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsmEgitimEkleGuncellSil;
    }
}