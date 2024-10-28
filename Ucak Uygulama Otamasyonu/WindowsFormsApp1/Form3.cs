using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        SqlConnection bag = new SqlConnection("Data Source = DESKTOP-I15JJB4; Initial Catalog = uygulama; Integrated Security = True");
        string connectionString = "Data Source=DESKTOP-I15JJB4;Initial Catalog=uygulama;Integrated Security=True";
        SqlConnection connection;

        public Form3()
        {
            InitializeComponent();

            connection= new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }














        private void Form3_Load(object sender, EventArgs e)
        { 
            
           
            SqlCommand cmd = new SqlCommand("Select * from firmalar", bag);
            SqlDataReader dr;
            bag.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbUçak.Items.Add(dr["f_adi"]);

            }
            bag.Close();

            SqlCommand komut = new SqlCommand("Select * from Seyehat", bag);
            SqlDataReader kdr;
            bag.Open();
            kdr = komut.ExecuteReader();
            while (kdr.Read())
            {
                cmbNereden.Items.Add(kdr["Nereden"]);
            }
            bag.Close();


            SqlCommand kmt = new SqlCommand("Select * from Seyehat", bag);
            SqlDataReader rd;
            bag.Open();
            rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                cmbNereye.Items.Add(rd["Nereye"]);
            }
            bag.Close();
        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://tr.wikipedia.org/wiki/Pegasus_Hava_Yollar%C4%B1");
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://tr.wikipedia.org/wiki/SunExpress");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://tr.wikipedia.org/wiki/T%C3%BCrk_Hava_Yollar%C4%B1");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://tr.wikipedia.org/wiki/AJet");
        }


        int toplam = 0;
        private void cmbUçak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cmbUçak.SelectedItem.ToString();

            if (cmbUçak.SelectedIndex == 0) 
            {
                toplam += 900;
                    { lblTutar.Text = toplam.ToString(); } 
            }
            if (cmbUçak.SelectedIndex == 1)
            {
                toplam += 950;
                lblTutar.Text = toplam.ToString();
            }
            if (cmbUçak.SelectedIndex == 2)
            {
                toplam += 1000;
                lblTutar.Text = toplam.ToString();
            }
                        
            if (cmbUçak.SelectedIndex == 3)
            {
                toplam += 1500;
                lblTutar.Text = toplam.ToString();
            }

            if (cmbUçak.SelectedIndex == 4)
            {
                toplam += 1550;
                lblTutar.Text = toplam.ToString();
            }



        }


        
        private void button2_Click(object sender, EventArgs e)


        {
            
           bag.Open();
            string selectedItem = cmbUçak.SelectedItem.ToString();
            string selectedItem1 = cmbNereden.SelectedItem.ToString();
            string selectedItem2 = cmbNereye.SelectedItem.ToString();
            string selectedItem4 = lblTutar.ToString();
           
            string insertQuery = "INSERT INTO seyehatt (ucak_secimi, nereden,nereye,odenen_tutar) VALUES (@ucak_secimi,@nereden,@nereye,@odenen_tutar)";
            SqlCommand command = new SqlCommand(insertQuery, bag);
            command.Parameters.AddWithValue("@ucak_secimi", selectedItem);
            command.Parameters.AddWithValue("@nereden", selectedItem1);
            command.Parameters.AddWithValue("@nereye", selectedItem2);
            command.Parameters.AddWithValue("@odenen_tutar" ,selectedItem4);
            command.ExecuteNonQuery();
            MessageBox.Show("Seferiniz Onaylanmıştır. Profilim Sekmesinden Ulaşabilirsiniz", "İyi Uçuşlar :)");
            bag.Close();

         cmbNereden.Items.Clear();
            cmbNereye.Items.Clear();
            cmbUçak.Items.Clear();
            lblTutar.Text = ("0");
        }
   
        
         
        private void cmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilen2 = cmbNereden.SelectedIndex;
            
            switch (secilen2)
            {
                case 0:
                    toplam += 400;
                    break;
                case 1:
                    toplam += 200;
                    break;
                case 2:
                    toplam += 250;
                    break;
                case 3:
                    toplam += 300;
                    break;
            }
            lblTutar.Text = toplam.ToString();
        }
        
        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen3 = cmbNereye.SelectedItem.ToString();
            
            switch (secilen3)
            {

                case "Adana":
                    toplam += 400;
                    break;
                case "İstanbul":
                    toplam += 350;
                    break;
                case "Rize":
                    toplam += 400;
                    break;
                case "Sinop":
                    toplam += 550;
                    break;

            }
            lblTutar.Text = toplam.ToString();
            //lblTutar.Text=""+toplam.ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }
    }



    }
    
