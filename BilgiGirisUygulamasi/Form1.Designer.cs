
namespace BilgiGirisUygulamasi
{
    partial class frm_bilgiGirisUygulamasi
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
            this.gbx_bilgiGiris = new System.Windows.Forms.GroupBox();
            this.gbx_bilgiIslemler = new System.Windows.Forms.GroupBox();
            this.gbx_veriler = new System.Windows.Forms.GroupBox();
            this.lbl_studentCount = new System.Windows.Forms.Label();
            this.tbx_tcNo = new System.Windows.Forms.TextBox();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.tbx_ad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.tbx_soyad = new System.Windows.Forms.TextBox();
            this.lbl_sinif = new System.Windows.Forms.Label();
            this.cbx_sinif = new System.Windows.Forms.ComboBox();
            this.btn_ekleVeGuncelle = new System.Windows.Forms.Button();
            this.tbx_bul = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_bul = new System.Windows.Forms.Button();
            this.rbtn_tcNo = new System.Windows.Forms.RadioButton();
            this.rbtn_adVeSoyad = new System.Windows.Forms.RadioButton();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.lbx_tcNo = new System.Windows.Forms.ListBox();
            this.lbx_adVeSoyad = new System.Windows.Forms.ListBox();
            this.lbx_sinif = new System.Windows.Forms.ListBox();
            this.gbx_bilgiGiris.SuspendLayout();
            this.gbx_bilgiIslemler.SuspendLayout();
            this.gbx_veriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_bilgiGiris
            // 
            this.gbx_bilgiGiris.Controls.Add(this.btn_ekleVeGuncelle);
            this.gbx_bilgiGiris.Controls.Add(this.cbx_sinif);
            this.gbx_bilgiGiris.Controls.Add(this.lbl_sinif);
            this.gbx_bilgiGiris.Controls.Add(this.lbl_soyad);
            this.gbx_bilgiGiris.Controls.Add(this.tbx_soyad);
            this.gbx_bilgiGiris.Controls.Add(this.lbl_ad);
            this.gbx_bilgiGiris.Controls.Add(this.tbx_ad);
            this.gbx_bilgiGiris.Controls.Add(this.lbl_tcNo);
            this.gbx_bilgiGiris.Controls.Add(this.tbx_tcNo);
            this.gbx_bilgiGiris.Location = new System.Drawing.Point(12, 12);
            this.gbx_bilgiGiris.Name = "gbx_bilgiGiris";
            this.gbx_bilgiGiris.Size = new System.Drawing.Size(331, 329);
            this.gbx_bilgiGiris.TabIndex = 0;
            this.gbx_bilgiGiris.TabStop = false;
            this.gbx_bilgiGiris.Text = "Giriş";
            // 
            // gbx_bilgiIslemler
            // 
            this.gbx_bilgiIslemler.Controls.Add(this.btn_degistir);
            this.gbx_bilgiIslemler.Controls.Add(this.rbtn_adVeSoyad);
            this.gbx_bilgiIslemler.Controls.Add(this.rbtn_tcNo);
            this.gbx_bilgiIslemler.Controls.Add(this.btn_bul);
            this.gbx_bilgiIslemler.Controls.Add(this.btn_sil);
            this.gbx_bilgiIslemler.Controls.Add(this.tbx_bul);
            this.gbx_bilgiIslemler.Location = new System.Drawing.Point(349, 12);
            this.gbx_bilgiIslemler.Name = "gbx_bilgiIslemler";
            this.gbx_bilgiIslemler.Size = new System.Drawing.Size(378, 329);
            this.gbx_bilgiIslemler.TabIndex = 1;
            this.gbx_bilgiIslemler.TabStop = false;
            this.gbx_bilgiIslemler.Text = "İşlemler";
            // 
            // gbx_veriler
            // 
            this.gbx_veriler.Controls.Add(this.lbx_sinif);
            this.gbx_veriler.Controls.Add(this.lbx_adVeSoyad);
            this.gbx_veriler.Controls.Add(this.lbx_tcNo);
            this.gbx_veriler.Location = new System.Drawing.Point(12, 347);
            this.gbx_veriler.Name = "gbx_veriler";
            this.gbx_veriler.Size = new System.Drawing.Size(715, 329);
            this.gbx_veriler.TabIndex = 2;
            this.gbx_veriler.TabStop = false;
            this.gbx_veriler.Text = "Veriler";
            // 
            // lbl_studentCount
            // 
            this.lbl_studentCount.AutoSize = true;
            this.lbl_studentCount.Location = new System.Drawing.Point(15, 693);
            this.lbl_studentCount.Name = "lbl_studentCount";
            this.lbl_studentCount.Size = new System.Drawing.Size(119, 17);
            this.lbl_studentCount.TabIndex = 3;
            this.lbl_studentCount.Text = "Öğrenci Sayısı : 0";
            // 
            // tbx_tcNo
            // 
            this.tbx_tcNo.Location = new System.Drawing.Point(112, 35);
            this.tbx_tcNo.Name = "tbx_tcNo";
            this.tbx_tcNo.Size = new System.Drawing.Size(166, 22);
            this.tbx_tcNo.TabIndex = 4;
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.Location = new System.Drawing.Point(42, 38);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(60, 17);
            this.lbl_tcNo.TabIndex = 4;
            this.lbl_tcNo.Text = "TC No : ";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(65, 79);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(37, 17);
            this.lbl_ad.TabIndex = 5;
            this.lbl_ad.Text = "Ad : ";
            // 
            // tbx_ad
            // 
            this.tbx_ad.Location = new System.Drawing.Point(112, 76);
            this.tbx_ad.Name = "tbx_ad";
            this.tbx_ad.Size = new System.Drawing.Size(166, 22);
            this.tbx_ad.TabIndex = 6;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(42, 121);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(60, 17);
            this.lbl_soyad.TabIndex = 7;
            this.lbl_soyad.Text = "Soyad : ";
            // 
            // tbx_soyad
            // 
            this.tbx_soyad.Location = new System.Drawing.Point(112, 118);
            this.tbx_soyad.Name = "tbx_soyad";
            this.tbx_soyad.Size = new System.Drawing.Size(166, 22);
            this.tbx_soyad.TabIndex = 8;
            // 
            // lbl_sinif
            // 
            this.lbl_sinif.AutoSize = true;
            this.lbl_sinif.Location = new System.Drawing.Point(55, 162);
            this.lbl_sinif.Name = "lbl_sinif";
            this.lbl_sinif.Size = new System.Drawing.Size(47, 17);
            this.lbl_sinif.TabIndex = 9;
            this.lbl_sinif.Text = "Sınıf : ";
            // 
            // cbx_sinif
            // 
            this.cbx_sinif.FormattingEnabled = true;
            this.cbx_sinif.Location = new System.Drawing.Point(112, 159);
            this.cbx_sinif.Name = "cbx_sinif";
            this.cbx_sinif.Size = new System.Drawing.Size(120, 24);
            this.cbx_sinif.TabIndex = 10;
            // 
            // btn_ekleVeGuncelle
            // 
            this.btn_ekleVeGuncelle.Location = new System.Drawing.Point(45, 212);
            this.btn_ekleVeGuncelle.Name = "btn_ekleVeGuncelle";
            this.btn_ekleVeGuncelle.Size = new System.Drawing.Size(233, 55);
            this.btn_ekleVeGuncelle.TabIndex = 11;
            this.btn_ekleVeGuncelle.Text = "Ekle";
            this.btn_ekleVeGuncelle.UseVisualStyleBackColor = true;
            // 
            // tbx_bul
            // 
            this.tbx_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bul.Location = new System.Drawing.Point(96, 121);
            this.tbx_bul.Name = "tbx_bul";
            this.tbx_bul.Size = new System.Drawing.Size(201, 27);
            this.tbx_bul.TabIndex = 13;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(78, 183);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(233, 37);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(78, 226);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(233, 37);
            this.btn_bul.TabIndex = 20;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = true;
            // 
            // rbtn_tcNo
            // 
            this.rbtn_tcNo.AutoSize = true;
            this.rbtn_tcNo.Location = new System.Drawing.Point(96, 75);
            this.rbtn_tcNo.Name = "rbtn_tcNo";
            this.rbtn_tcNo.Size = new System.Drawing.Size(69, 21);
            this.rbtn_tcNo.TabIndex = 22;
            this.rbtn_tcNo.TabStop = true;
            this.rbtn_tcNo.Text = "TC No";
            this.rbtn_tcNo.UseVisualStyleBackColor = true;
            // 
            // rbtn_adVeSoyad
            // 
            this.rbtn_adVeSoyad.AutoSize = true;
            this.rbtn_adVeSoyad.Location = new System.Drawing.Point(188, 77);
            this.rbtn_adVeSoyad.Name = "rbtn_adVeSoyad";
            this.rbtn_adVeSoyad.Size = new System.Drawing.Size(109, 21);
            this.rbtn_adVeSoyad.TabIndex = 23;
            this.rbtn_adVeSoyad.TabStop = true;
            this.rbtn_adVeSoyad.Text = "Ad ve Soyad";
            this.rbtn_adVeSoyad.UseVisualStyleBackColor = true;
            // 
            // btn_degistir
            // 
            this.btn_degistir.Location = new System.Drawing.Point(78, 269);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(233, 37);
            this.btn_degistir.TabIndex = 24;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.UseVisualStyleBackColor = true;
            // 
            // lbx_tcNo
            // 
            this.lbx_tcNo.FormattingEnabled = true;
            this.lbx_tcNo.ItemHeight = 16;
            this.lbx_tcNo.Location = new System.Drawing.Point(12, 21);
            this.lbx_tcNo.Name = "lbx_tcNo";
            this.lbx_tcNo.Size = new System.Drawing.Size(226, 292);
            this.lbx_tcNo.TabIndex = 25;
            // 
            // lbx_adVeSoyad
            // 
            this.lbx_adVeSoyad.FormattingEnabled = true;
            this.lbx_adVeSoyad.ItemHeight = 16;
            this.lbx_adVeSoyad.Location = new System.Drawing.Point(244, 21);
            this.lbx_adVeSoyad.Name = "lbx_adVeSoyad";
            this.lbx_adVeSoyad.Size = new System.Drawing.Size(226, 292);
            this.lbx_adVeSoyad.TabIndex = 26;
            // 
            // lbx_sinif
            // 
            this.lbx_sinif.FormattingEnabled = true;
            this.lbx_sinif.ItemHeight = 16;
            this.lbx_sinif.Location = new System.Drawing.Point(476, 21);
            this.lbx_sinif.Name = "lbx_sinif";
            this.lbx_sinif.Size = new System.Drawing.Size(226, 292);
            this.lbx_sinif.TabIndex = 27;
            // 
            // frm_bilgiGirisUygulamasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(739, 733);
            this.Controls.Add(this.lbl_studentCount);
            this.Controls.Add(this.gbx_veriler);
            this.Controls.Add(this.gbx_bilgiIslemler);
            this.Controls.Add(this.gbx_bilgiGiris);
            this.Name = "frm_bilgiGirisUygulamasi";
            this.Text = "Bilgi Giriş Uygulaması";
            this.gbx_bilgiGiris.ResumeLayout(false);
            this.gbx_bilgiGiris.PerformLayout();
            this.gbx_bilgiIslemler.ResumeLayout(false);
            this.gbx_bilgiIslemler.PerformLayout();
            this.gbx_veriler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_bilgiGiris;
        private System.Windows.Forms.GroupBox gbx_bilgiIslemler;
        private System.Windows.Forms.GroupBox gbx_veriler;
        private System.Windows.Forms.Label lbl_studentCount;
        private System.Windows.Forms.Label lbl_sinif;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox tbx_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox tbx_ad;
        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.TextBox tbx_tcNo;
        private System.Windows.Forms.Button btn_ekleVeGuncelle;
        private System.Windows.Forms.ComboBox cbx_sinif;
        private System.Windows.Forms.RadioButton rbtn_adVeSoyad;
        private System.Windows.Forms.RadioButton rbtn_tcNo;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox tbx_bul;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.ListBox lbx_sinif;
        private System.Windows.Forms.ListBox lbx_adVeSoyad;
        private System.Windows.Forms.ListBox lbx_tcNo;
    }
}

