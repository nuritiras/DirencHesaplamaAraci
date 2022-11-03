using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirencHesaplamaAraci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc;
            byte a1, a2, a3, a4;
            a1 =Convert.ToByte(comboBox1.SelectedIndex);
            a2 = Convert.ToByte(comboBox2.SelectedIndex);
            a3 = Convert.ToByte(comboBox3.SelectedIndex);
            a4 = Convert.ToByte(comboBox4.SelectedIndex);
            string toplam = a1.ToString() + a2.ToString();
            sonuc = (Convert.ToDouble(toplam) * Math.Pow(10, a3));

            if (sonuc < 1000)
                label2.Text = "Sonuç: "+sonuc.ToString() + " Ω";
            else if (sonuc < 1000000)
                label2.Text = "Sonuç: "+(sonuc / 1000).ToString() + " KΩ";
            else if (sonuc < 1000000000)
                label2.Text = "Sonuç: "+(sonuc / 1000000).ToString() + " MΩ";
            else if (sonuc < 1000000000000)
                label2.Text = "Sonuç: "+(sonuc / 1000000000).ToString() + " GΩ";
            else
                label2.Text = "Hata";

            
             if (a4 == 0)
                label3.Text= "Hata Payı:"+" ±%5";
            else    
                label3.Text= "Hata Payı:" + " ±%10";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }
    }
}
