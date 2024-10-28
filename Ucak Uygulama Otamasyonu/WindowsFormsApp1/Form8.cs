using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        

        public Form8()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls=false;
        }

        

        public void islem1()
        {
            if (TB1.Text == "")
            {
                MessageBox.Show("Lütfen ilk Önce bir Lokasyon Giriniz ", "HATA");
            }

            else
            {
                Form8 frm = new Form8();
                string htmlCode = "";
                using(WebClient client = WebClient())
                {
                  client.Encoding = Encoding.UTF8;
                    htmlCode = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?lat={TB1.Text}&appid=de5309a5e4f4364c182c7ee8dc78ddca&&lang=tr");
                }
                dynamic stuff = JObject.Parse (htmlCode);
                dynamic sicaklik = stuff.main.temp;
                int veriSicaklik = (sicaklik - 273);
                L1.Text = veriSicaklik.ToString() + "°C";
                L1.Location = new Point(frm.Size.Width / 2 - L1.Size.Width / 2 - 10, 68);
                dynamic picture = stuff.weather[0].icon;
                PB1.Load("");

                dynamic status  = stuff.weather[0].descryption;
                L2.Location = new Point(frm.Size.Width / 2 - L2.Size.Width / 2 / 10, 237);
                dynamic country = stuff.sys .country;
                dynamic name = stuff.sys .name;
                L3.Text = $"{name},{country}";
                L2.Location = new Point(frm.Size.Width / 2 - L2.Size.Width / 2 / 10, 68);
                TB1.Text = "";

            }
        }

        private WebClient WebClient()
        {
            throw new NotImplementedException();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Thread islem = new Thread(() =>  islem1 ());
            islem.Start ();
        }
    }
}
