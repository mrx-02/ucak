using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    { SqlConnection bag= new SqlConnection("Data Source = DESKTOP-I15JJB4; Initial Catalog = uygulama; Integrated Security = True");

        SqlDataAdapter adr;
        SqlCommandBuilder commandBuilder;
        DataTable dt= new DataTable();
        void Listele ()

        { /*
            dt.Clear();
            adr = new SqlDataAdapter("Select * from seyehatt",bag );
            adr.Fill (dt);
            dataGridView1.DataSource = dt;
            */

        }
        private int sayi;
        private Keys keyData;
        

        public Form4()
        {
            
            InitializeComponent();
            Listele ();
        }

        

       

        private void btnOnayla_Click(object sender, EventArgs e)
        
        {
        
            
                
            int sonuc;
            sonuc = Int32.Parse(lblBakiye.Text) + Int32.Parse(txtTutar.Text);
            MessageBox.Show("Bakiyeniz Yüklenecektir ", "EMİNMİSİNİZ");
                lblBakiye.Text = sonuc.ToString();
            txtTutar.Clear();
                
            
        }
        
      
        
        

        
       

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hesabınızdan Çıkış Yapışacaktır","Sistem",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

       

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            lblBakiye.Text = ("0");
        }

      

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim=  MessageBox.Show("Hesabınızdan Çıkış Yapılacaktır" ,"Dikkat",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (secim== DialogResult.Yes)
            {

                Application.Exit();
                
                    
             }
            else
            {
              
                MessageBox.Show("Çıkş İşlemi İptal Edildi","Sistem ",MessageBoxButtons.OK);
            }
            
        }

      
       

        private void button1_Click_3(object sender, EventArgs e)
        {/*
           bag.Open();
            SqlCommand komut = new SqlCommand("select * from seyehatt", bag);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet veriseti = new DataSet();
            adp.Fill(veriseti);
            dataGridView1.DataSource = veriseti.Tables[0];
            bag.Close();
            */
           
        }

        private void lblBakiye_Click(object sender, EventArgs e)
        {

        }
        Form3 f;

        private void button2_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Form3();
                f.Show();
            }
            else
            {
                MessageBox.Show("Giriş Paneli Açık", "Sistem");
            }
            /*Form3 form3 = new Form3();
            form3.ShowDialog();
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
             bag.Open();
            SqlCommand komut = new SqlCommand("select * from seyehatt", bag);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataSet veriseti = new DataSet();
            adp.Fill(veriseti);
            dataGridView1.DataSource = veriseti.Tables[0];
            bag.Close();
           

            /*commandBuilder = new SqlCommandBuilder(adr);
            adr.Update(dt);
            */
            
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }
    }
}
