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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string tutar;
            tutar=txtTutar.Text;
        lstBakiyem.Items.Add(tutar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstBakiyem.Items.Clear();
            txtTutar.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string onbeş;
            onbeş = button2.Text;
             lstBakiyem.Items.Add("15");
        }
    }
}
