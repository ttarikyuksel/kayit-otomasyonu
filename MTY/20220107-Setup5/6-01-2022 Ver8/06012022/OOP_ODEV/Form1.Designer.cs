namespace OOP_ODEV
{
    partial class Form1
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
            this.grpGirisPaneli = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.chkParolaGoster = new System.Windows.Forms.CheckBox();
            this.txtGirisParola = new System.Windows.Forms.TextBox();
            this.txtGirisMailAdresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpGirisPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGirisPaneli
            // 
            this.grpGirisPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.grpGirisPaneli.Controls.Add(this.label3);
            this.grpGirisPaneli.Controls.Add(this.pbLogo);
            this.grpGirisPaneli.Controls.Add(this.chkParolaGoster);
            this.grpGirisPaneli.Controls.Add(this.txtGirisParola);
            this.grpGirisPaneli.Controls.Add(this.txtGirisMailAdresi);
            this.grpGirisPaneli.Controls.Add(this.label2);
            this.grpGirisPaneli.Controls.Add(this.label1);
            this.grpGirisPaneli.Controls.Add(this.btnGirisYap);
            this.grpGirisPaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpGirisPaneli.ForeColor = System.Drawing.Color.White;
            this.grpGirisPaneli.Location = new System.Drawing.Point(12, 6);
            this.grpGirisPaneli.Name = "grpGirisPaneli";
            this.grpGirisPaneli.Size = new System.Drawing.Size(441, 612);
            this.grpGirisPaneli.TabIndex = 0;
            this.grpGirisPaneli.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::OOP_ODEV.Properties.Resources.ProjectorLogoUnBG;
            this.pbLogo.Location = new System.Drawing.Point(27, 84);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(389, 205);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // chkParolaGoster
            // 
            this.chkParolaGoster.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkParolaGoster.ForeColor = System.Drawing.Color.White;
            this.chkParolaGoster.Location = new System.Drawing.Point(129, 383);
            this.chkParolaGoster.Name = "chkParolaGoster";
            this.chkParolaGoster.Size = new System.Drawing.Size(132, 22);
            this.chkParolaGoster.TabIndex = 2;
            this.chkParolaGoster.Text = "Parolayı Göster";
            this.chkParolaGoster.UseVisualStyleBackColor = true;
            this.chkParolaGoster.CheckedChanged += new System.EventHandler(this.chkParolaGoster_CheckedChanged);
            // 
            // txtGirisParola
            // 
            this.txtGirisParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtGirisParola.ForeColor = System.Drawing.Color.White;
            this.txtGirisParola.Location = new System.Drawing.Point(129, 351);
            this.txtGirisParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtGirisParola.Name = "txtGirisParola";
            this.txtGirisParola.Size = new System.Drawing.Size(248, 25);
            this.txtGirisParola.TabIndex = 1;
            // 
            // txtGirisMailAdresi
            // 
            this.txtGirisMailAdresi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtGirisMailAdresi.ForeColor = System.Drawing.Color.White;
            this.txtGirisMailAdresi.Location = new System.Drawing.Point(129, 316);
            this.txtGirisMailAdresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtGirisMailAdresi.Name = "txtGirisMailAdresi";
            this.txtGirisMailAdresi.Size = new System.Drawing.Size(248, 25);
            this.txtGirisMailAdresi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mail Adresi:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGirisYap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGirisYap.Location = new System.Drawing.Point(129, 412);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(248, 32);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(406, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(465, 630);
            this.Controls.Add(this.grpGirisPaneli);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGirisPaneli.ResumeLayout(false);
            this.grpGirisPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGirisPaneli;
        private System.Windows.Forms.CheckBox chkParolaGoster;
        private System.Windows.Forms.TextBox txtGirisParola;
        private System.Windows.Forms.TextBox txtGirisMailAdresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label3;
    }
}

