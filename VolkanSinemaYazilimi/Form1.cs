using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolkanSinemaYazilimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salonAc;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void olusturBtn_Click(object sender, EventArgs e)
        {
           try
            {
                string salon = salonTxt.Text;
                int koltuksayisi = Convert.ToInt16(koltukTxt.Text);
                salonAc = new Sinema(salon, koltuksayisi);
                lblSonuc.Text = "Salon Oluşturuldu...";
            }
            catch
            {
                lblSonuc.Text = "Hata! Salon Oluşturulamadı...";
            }
        }

        private void satBtn_Click(object sender, EventArgs e)
        {

                salonAc.BiletSat();
                lblSonuc.Text = "1 Bilet satıldı..";
           
                
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            salonAc.BiletIptal();
            lblSonuc.Text = "1 Bilet iptal edildi..";
        }

        private void bosKoltukBtn_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = Convert.ToString(salonAc.BosKoltukSayisi())+" Adet";
        }

        private void doluKoltukBtn_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = Convert.ToString(salonAc.DoluKoltukSayisi()) + " Adet";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = Convert.ToString(salonAc.BakiyeOgrek())+"TL";
        }

    }
}
