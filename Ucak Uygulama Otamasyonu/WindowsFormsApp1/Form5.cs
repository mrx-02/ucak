using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" && ysifre.Text == "" && esifre.Text == "")
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-I15JJB4; Initial Catalog = uygulama; Integrated Security = True");
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("UPDATE kullaniciler_girisi SET sifre = @ysifre Where sifre =@esifre and ad = @txtad", baglanti);
                sorgu.Parameters.AddWithValue("@txtad", txtad.Text);
                sorgu.Parameters.AddWithValue("@ysifre", ysifre.Text);
                sorgu.Parameters.AddWithValue("@esifre", esifre.Text);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Güncellenmiştir", "Tebrikler");
                txtad.Clear();
                ysifre.Text = ("");
                esifre.Text = ("");
                Form1 form1 = new Form1();
                form1.ShowDialog();
                baglanti.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
