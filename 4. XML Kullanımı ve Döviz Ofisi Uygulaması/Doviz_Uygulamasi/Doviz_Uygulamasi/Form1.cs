using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Borsa Çeviri Uygulaması";




            String bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";

            try
            {
                var xmldosya = new XmlDocument();
                xmldosya.Load(bugun);
                var dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerText;
                label1.Text = dolaralis.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Hatası");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
