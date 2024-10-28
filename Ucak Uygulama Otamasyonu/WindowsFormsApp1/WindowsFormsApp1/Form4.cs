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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("bakiye yüklenecektir ", "eminmisiniz");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("HESABINZIDAN Çıkış Yapılacaktır ", "Eminmisiz");
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
