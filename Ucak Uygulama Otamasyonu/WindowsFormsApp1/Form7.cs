using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {

        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilkSayi;
        public Form7()
        {
            InitializeComponent();
        }

        private void btnRakam1_Click(object sender, EventArgs e)
        { if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "1";
        }

        private void btnRakam2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "2";
        }

        private void btnRakam3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "3";
        }

        private void btnRakam4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "4";
        }

        private void btnRakam5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "5";
        }

        private void btnRakam6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "6";
        }

        private void btnRakam7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "7";
        }

        private void btnRakam8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "8";
        }

        private void btnRakam9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "9";
        }

        private void btnRakam0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "0";
        }

        private void btnArtı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi= true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        { int ikinci_Sayi= Convert.ToInt32(lblEkran.Text);
            int sonuc;
            switch (_islem)
                
            {
                case '+':

                   sonuc=  _ilkSayi + ikinci_Sayi;
                    break;

                case '-':

                    sonuc = _ilkSayi - ikinci_Sayi;
                    break;
                case 'x':

                    sonuc = _ilkSayi * ikinci_Sayi;
                    break;
                case '/':

                    sonuc = _ilkSayi / ikinci_Sayi;
                    break;
                    default: sonuc = 0;
                     break;

            }
            lblEkran.Text= Convert.ToString(sonuc);
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnBölü_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblEkran.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblEkran.Text= "0";
        }
    }
}
