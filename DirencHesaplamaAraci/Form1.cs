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
            double a1, a2, a3, a4, sonuc;
            a1 = comboBox1.SelectedIndex;
            a2 = comboBox2.SelectedIndex;
            a3 = comboBox3.SelectedIndex;
            a4 = comboBox4.SelectedIndex;
            string toplam = a1 + a2.ToString();
            sonuc = (Convert.ToDouble(toplam) * Math.Pow(10, a3));

            if (sonuc < 1000)
                label1.Text = sonuc + " Ohm".ToString();
            else if (sonuc < 1000000)
                label1.Text = (sonuc / 1000) + " Kilo Ohm".ToString();
            else if (sonuc < 1000000000)
                label1.Text = (sonuc / 1000000) + " Mega Ohm".ToString();
            else if (sonuc < 1000000000000)
                label1.Text = (sonuc / 1000000000) + " Giga Ohm".ToString();
            else
                label1.Text = "Hata";

            
             if (a4 == 0)
                label2.Text = "Hata Payı %5";
            else    
                label2.Text = "Hata Payı %10";
        }
    }
}
