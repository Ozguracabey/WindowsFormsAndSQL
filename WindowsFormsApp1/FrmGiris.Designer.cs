namespace WindowsFormsApp1
{
    partial class FrmGiris
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(172, 154);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 42);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şİfre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Location = new System.Drawing.Point(172, 71);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(100, 29);
            this.TxtKullaniciAd.TabIndex = 4;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(172, 106);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(100, 29);
            this.TxtSifre.TabIndex = 5;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 219);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.TextBox TxtSifre;
    }
}