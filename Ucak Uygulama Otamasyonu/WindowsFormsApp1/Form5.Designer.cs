namespace WindowsFormsApp1
{
    partial class Form5
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
            this.ysifre = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblŞifretekrar = new System.Windows.Forms.Label();
            this.esifre = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ysifre
            // 
            this.ysifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ysifre.Location = new System.Drawing.Point(137, 235);
            this.ysifre.Margin = new System.Windows.Forms.Padding(2);
            this.ysifre.Name = "ysifre";
            this.ysifre.Size = new System.Drawing.Size(146, 24);
            this.ysifre.TabIndex = 1;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(312, 266);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(102, 62);
            this.btnGüncelle.TabIndex = 4;
            this.btnGüncelle.Text = "Şifremi Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eski  Şifreniz";
            // 
            // lblŞifretekrar
            // 
            this.lblŞifretekrar.AutoSize = true;
            this.lblŞifretekrar.BackColor = System.Drawing.Color.Transparent;
            this.lblŞifretekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifretekrar.ForeColor = System.Drawing.Color.Black;
            this.lblŞifretekrar.Location = new System.Drawing.Point(149, 197);
            this.lblŞifretekrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblŞifretekrar.Name = "lblŞifretekrar";
            this.lblŞifretekrar.Size = new System.Drawing.Size(111, 20);
            this.lblŞifretekrar.TabIndex = 7;
            this.lblŞifretekrar.Text = "Yeni Şifreniz";
            // 
            // esifre
            // 
            this.esifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esifre.Location = new System.Drawing.Point(137, 154);
            this.esifre.Margin = new System.Windows.Forms.Padding(2);
            this.esifre.Name = "esifre";
            this.esifre.Size = new System.Drawing.Size(146, 24);
            this.esifre.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(170, 38);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(58, 20);
            this.lblAd.TabIndex = 9;
            this.lblAd.Text = "Adınız";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(137, 72);
            this.txtad.Margin = new System.Windows.Forms.Padding(2);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(146, 24);
            this.txtad.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.ysifre);
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.lblŞifretekrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.esifre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(606, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 343);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre  Paneli";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aircraft_547105_1920;
            this.ClientSize = new System.Drawing.Size(1454, 767);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Şifre Yenileme Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ysifre;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblŞifretekrar;
        private System.Windows.Forms.TextBox esifre;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}