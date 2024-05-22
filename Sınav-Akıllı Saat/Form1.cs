using System.ComponentModel;
using System.Reflection;

namespace Sınav_Akıllı_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtadımuzulugu_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Adımuzunluğunu giriniz::");
        }

        private void btnadınuzunlugukaydedildi_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtadımuzulugu.Text, out double adımuzunlugu))
            {
                MessageBox.Show("Adım uzunluğunuz kaydedildi:" + adımuzunlugu.ToString() + "cm");
            }
            else
            {
                MessageBox.Show("Geçersiz sayı girişi yaptınız:");
            }
        }

        private void btnAdımSayısı_Click(object sender, EventArgs e)
        {
            try
            {
                int adımsayısı = Convert.ToInt32(txtadımsayısı.Text);
                MessageBox.Show("Girilen  Adım Sayısı :" + adımsayısı.ToString());
            }
            catch
            {
                MessageBox.Show("Geçersiz sayı girişi yaptınız:");
            }

        }

        private void cmbSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cmbSaat.Items.Add(i);
            }
        }

        private void cmbDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                cmbDakika.Items.Add(i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double mesafe;
            if (double.TryParse(textBox1.Text, out mesafe))
            {
                MessageBox.Show("Koşu mesafesi:" + mesafe.ToString() + "km");
            }
            else
            {
                MessageBox.Show("Geçersiz Giriş Yaptınız");
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {

                double km=Convert.ToDouble(txtToplamMesafe.Text);
                double cm = km * 100000;
                int  saat=Convert.ToInt32(cmbSaat.Text);
                int dakika=Convert.ToInt32(cmbDakika.Text);
                int toplamDakika = (saat * 60) + dakika;
                int adimsayısı=Convert.ToInt32(txtadımsayısı.Text); 
                double adımuzulugu=Convert.ToDouble(txtadımuzulugu.Text);
                double toplammesafe = adımuzulugu * adimsayısı * toplamDakika;
                MessageBox.Show($"Girilen {km} km {cm} cm'ye {saat} saat {dakika} dakika {toplamDakika} dakikaya ve toplamda {adimsayısı} adım {adımuzulugu} cm adım uzunlugu ile toplam{toplammesafe} birim mesafe yaptınız.");




            }
            catch
            {
                MessageBox.Show("Lütfen saat,dakika ve mesafe biliglerini tekrar giriniz:");
            }
        }

        private void btnDakikadaKatedilenMesafe_Click(object sender, EventArgs e)
        {
            try
            {
                double adımuzunlugu = Convert.ToDouble(txtadımuzulugu.Text);
                int dakikadaakiadımSayisi = Convert.ToInt32(txtadımsayısı.Text);
                double toplamMesafe = adımuzunlugu * dakikadaakiadımSayisi;
                txtToplamMesafe.Text=toplamMesafe.ToString();
               
            }
            catch
            {
                MessageBox.Show("Girilen değerler yanlış tekrar giriniz:");
            }
        }
    }
}
