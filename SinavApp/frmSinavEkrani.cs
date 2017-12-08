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
            int soruSayisi = 0;
            int solY = 0, sagY = 0;
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                kalanZaman = Convert.ToInt32(streamReader.ReadLine());

                while (true)
                {
                    string satir = streamReader.ReadLine();
                    if (string.IsNullOrWhiteSpace(satir))
                    {
                        break;
                    }
                    string[] soruVeSecenekler = satir.Split('|');
                    GroupBox grpSoru = new GroupBox();
                    grpSoru.Text = soruSayisi + 1 + ". SORU";
                    grpSoru.Size = new Size(250, 250);
                    grpSoru.Name = "grp" + soruSayisi;

                    Label lblSoru = new Label();
                    lblSoru.Name = "lbl" + soruSayisi;
                    lblSoru.AutoSize = true;
                    lblSoru.MaximumSize = new Size(240, 0);
                    if (soruSayisi % 2 == 0)
                    {
                        grpSoru.Location = new Point(0, solY);
                        solY += grpSoru.Height + 5;
                        lblSoru.Location = new Point(30, 30);
                        //solY += lblSoru.Height + 25;
                    }
                    else
                    {
                        grpSoru.Location = new Point(300, sagY);
                        sagY += grpSoru.Height + 5;
                        lblSoru.Location = new Point(30, 30);
                        //sagY += lblSoru.Height + 5;
                    }

                    lblSoru.Text = soruVeSecenekler[0];
                    grpSoru.Controls.Add(lblSoru);
                    for (int i = 1; i < soruVeSecenekler.Length - 1; i++)
                    {
                        RadioButton rdbSecenek = new RadioButton()
                        {
                            Name = soruSayisi + "soru" + i,
                            Text = soruVeSecenekler[i],
                            Location = new Point(25, i * lblSoru.Top + lblSoru.Height + 5)
                        };
                        grpSoru.Controls.Add(rdbSecenek);
                    }
                    pnlSorular.Controls.Add(grpSoru);
                    soruSayisi++;
                }
                prgCevapOrani.Maximum = soruSayisi + 3;
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
            int dakika = (zaman % 3600) / 60;
            int saniye = (zaman % 3600) % 60;

            return zamanFormatla(saat) + ":" + zamanFormatla(dakika) + ":" + zamanFormatla(saniye);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanZaman--;
            lblKalanZaman.Text = ZamanHesapla(kalanZaman);
            if (kalanZaman <= sonDakikalar)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            if (kalanZaman <= 0)
            {
                timer1.Stop();
            }
        }
    }
}
