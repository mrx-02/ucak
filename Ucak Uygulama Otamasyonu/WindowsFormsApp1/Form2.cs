using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Management;
using System.CodeDom;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand com;
        
        public Form2()
        {
            InitializeComponent();
            
        }
        Form1 f;

       
        private void button1_Click(object sender, EventArgs e)
        {

            

            /*
            com =new SqlCommand();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "select * from kullanicilar_girisi where ad ='" + txtAd.Text + "'And sifre ='" + txtSifre.Text + "'"; 
            dr= com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show(" Tebrikler Giriş Başarılı");
            }

            else
            {
                MessageBox.Show("Girdiğiniz Verileri Kontrol Ediniz");
            }
            conn.Close();
            txtAd.Clear();
            txtSoyisim.Clear();
            txtSifre.Clear();
            mskdTelefon.Clear();
            Form3 form3 = new Form3();
            form3.ShowDialog();

            */
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnÜye_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyisim.Text == "" || txtŞifre.Text == "" || mskdTelefon.Text == "")



            {
                MessageBox.Show("Lütfen Alanları Boş Bırakmayınız", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }


            else
            {

                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I15JJB4;Initial Catalog=uygulama;Integrated Security=True");

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kullaniciler_girisi(ad,soyisim,sifre,tel_no) values (@ad,@soyisim,@sifre,@tel_no)", baglanti);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                komut.Parameters.AddWithValue("@sifre", txtŞifre.Text);
                komut.Parameters.AddWithValue("tel_no", mskdTelefon.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kaydınız Başarılı Olmuştur", "HOŞGELDİNİZ");
                txtAd.Clear();
                txtSoyisim.Clear();
                txtŞifre.Clear();
                mskdTelefon.Clear();
                if (f==null || f.IsDisposed)
                {
                    f = new Form1();
                    f.Show();
                }
               else
                {
                    MessageBox.Show("Giriş Paneli Açık", "Sistem");
                }
                
            }
        }

       
        
    }
}

