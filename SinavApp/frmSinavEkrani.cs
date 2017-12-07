using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public partial class frmSinavEkrani : Form
    {
        public string AdSoyad { get; set; }
        public string SinavDosyaYolu { get; set; }
        int kalanZaman, sonDakikalar;

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) : this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }


        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                kalanZaman = Convert.ToInt32(streamReader.ReadLine());
            }
            lblKalanZaman.Text = ZamanHesapla(kalanZaman);
            sonDakikalar = (kalanZaman / 100) * 10;
            timer1.Start();
        }

        string zamanFormatla(int birim)
        {
            return birim < 10 ? "0" + birim : birim + "";
        }
        string ZamanHesapla(int zaman)
        {
            int saat = zaman / 3600;
            int dakika = zaman % 3600 / 60;
            int saniye = zaman % 3600 % 60;

            return zamanFormatla(saat) + ":" + zamanFormatla(dakika) + ":" + zamanFormatla(saniye);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanZaman--;
            lblKalanZaman.Text = ZamanHesapla(kalanZaman);
            if (kalanZaman == sonDakikalar)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            if (kalanZaman == 0)
            {
                timer1.Stop();
            }
        }
    }
}
