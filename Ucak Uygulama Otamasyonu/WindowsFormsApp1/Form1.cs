using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (txtAd.Text == "" && txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Boş Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





            else
            {


                string user = txtAd.Text;
                string sifre = txtsifre.Text;

                SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-I15JJB4; Initial Catalog = uygulama; Integrated Security = True");
                sqlConnection.Open();
                SqlCommand comm = new SqlCommand("select * from kullaniciler_girisi where ad ='" + txtAd.Text + "'And sifre ='" + txtsifre.Text + "'", sqlConnection);
                dr = comm.ExecuteReader();
                if (dr.Read())

                    
                {
                    MessageBox.Show(" Tebrikler Giriş Başarılı", "Hoşgeldiniz",MessageBoxButtons.OK);
                    Form3 form3 = new Form3();
                    form3.ShowDialog();

                }

               


                else 

                {
                    MessageBox.Show("Adınız veya Şifreniz Hatalı", "Tekrar Deneyiniz ");
                }
                sqlConnection.Close();

                 txtAd.Clear();
                 txtsifre.Clear();
                   

                
                
               

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        Form2 frm;
        private void button3_Click(object sender, EventArgs e)
        {
            if (frm==null || frm.IsDisposed)
            {
                frm= new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bu Sayfa Zaten Açık", "Sistem");
                frm.Focus();
            }
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAd.Text != "")
            {
                btnGiris.Enabled = false;
            }
            else
            {
                btnGiris.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked) 
            { 
                txtsifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }

            else if (checkBox1.CheckState==CheckState.Unchecked)
            {
               txtsifre.UseSystemPasswordChar=false;
                checkBox1.Text = "Gizle";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fatihmrx01gmailcomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gmail.com");
        }
    }
}
