namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKayıtol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.saat = new System.Windows.Forms.Label();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fatihmrx01gmailcomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(531, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UÇAK TAKİBİ  VE BİLGİ OTOMASYONUNA HOŞGELDİNİZ\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(404, 151);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 63);
            this.button2.TabIndex = 15;
            this.button2.Text = "Şifre Güncelle\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Lime;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(324, 154);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(66, 62);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click_1);
            this.btnGiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGiris_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(124, 145);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(129, 23);
            this.txtAd.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şifreniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adınız ";
            // 
            // btnKayıtol
            // 
            this.btnKayıtol.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKayıtol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtol.ForeColor = System.Drawing.Color.Black;
            this.btnKayıtol.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKayıtol.Location = new System.Drawing.Point(242, 293);
            this.btnKayıtol.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayıtol.Name = "btnKayıtol";
            this.btnKayıtol.Size = new System.Drawing.Size(82, 56);
            this.btnKayıtol.TabIndex = 2;
            this.btnKayıtol.Text = "Kayıt Ol\r\n";
            this.btnKayıtol.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKayıtol.UseMnemonic = false;
            this.btnKayıtol.UseVisualStyleBackColor = false;
            this.btnKayıtol.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sisteme Giriş İçin Lütfen Bilgilerinizi Giriniz";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.Color.Transparent;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.Color.Black;
            this.saat.Location = new System.Drawing.Point(223, 15);
            this.saat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(104, 26);
            this.saat.TabIndex = 19;
            this.saat.Text = "00:00:00";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem1,
            this.fatihmrx01gmailcomToolStripMenuItem1});
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.iletişimToolStripMenuItem.Text = "Menüler";
            // 
            // iletişimToolStripMenuItem1
            // 
            this.iletişimToolStripMenuItem1.Name = "iletişimToolStripMenuItem1";
            this.iletişimToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.iletişimToolStripMenuItem1.Text = "İletişim";
            // 
            // fatihmrx01gmailcomToolStripMenuItem1
            // 
            this.fatihmrx01gmailcomToolStripMenuItem1.Name = "fatihmrx01gmailcomToolStripMenuItem1";
            this.fatihmrx01gmailcomToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.fatihmrx01gmailcomToolStripMenuItem1.Text = "Fatihmrx01@gmail.com";
            this.fatihmrx01gmailcomToolStripMenuItem1.Click += new System.EventHandler(this.fatihmrx01gmailcomToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aircraft_4885805_1920;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1316, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnKayıtol);
            this.groupBox1.Controls.Add(this.saat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(561, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(582, 366);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(124, 207);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(129, 24);
            this.txtsifre.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(257, 211);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aircraft_4885805_1920;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1316, 732);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Giriş Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKayıtol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fatihmrx01gmailcomToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtsifre;
    }
}

