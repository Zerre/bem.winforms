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
        public TimeSpan SinavSüresi { get; private set; }
        public double SinavSüresiYüzdeOn { get; private set; }
        public List<SoruGroupBox> SoruKutulari { get; set; }
        public Dictionary<int, List<RadioButton>> SoruCevapListesi { get; set; }

        public frmSinavEkrani()
        {
            InitializeComponent();
            SoruKutulari = new List<SoruGroupBox>();
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
                BaslangicDegerleriniTanimla(streamReader);
                SoruListesiniOlustur(streamReader);
            }
        }

        private void SoruListesiniOlustur(StreamReader streamReader)
        {
            string line = "";

            int soruSayisi = 0;
            int top = 0;
            int left = 0;
            int enBuyukSatirYuksekligi = 0;

            while (!string.IsNullOrWhiteSpace((line = streamReader.ReadLine())))
            {
                List<RadioButton> buttonList = new List<RadioButton>();

                soruSayisi++;
                var items = line.Split('|');

                top += (soruSayisi % 2 == 1) ? enBuyukSatirYuksekligi : 0;
                left = (soruSayisi % 2 == 1) ? 0 : 286;

                var groupBox = new SoruGroupBox
                {
                    AutoSize = true,
                    Location = new Point(left, top),
                    MinimumSize = new Size(270, 0),
                    SoruNumarasi = soruSayisi-1,
                    Text = $"{soruSayisi}. Soru"
                };

                var lbl = new Label
                {
                    Text = items[0],
                    MaximumSize = new Size(260, 0),
                    AutoSize = true,
                    Location = new Point(15, 15)
                };

                int radioTop = lbl.Location.Y + lbl.PreferredHeight + 15;

                for (int i = 1; i < items.Length - 1; i++)
                {
                    var radio = new RadioButton
                    {
                        Text = items[i],
                        Location = new Point(20, radioTop),
                        Enabled = false,
                        AutoSize = true,
                        MaximumSize = new Size(200, 0),
                        Tag = i-1
                    };
                    radio.Click += Radio_Click;

                    groupBox.Controls.Add(radio);

                    radioTop += 30;

                    buttonList.Add(radio);
                }

                groupBox.Controls.Add(lbl);

                SoruKutulari.Add(groupBox);

                if (soruSayisi % 2 == 1)
                {
                    enBuyukSatirYuksekligi = groupBox.PreferredSize.Height;
                }
                else
                {
                    if (groupBox.PreferredSize.Height > enBuyukSatirYuksekligi)
                    {
                        enBuyukSatirYuksekligi = groupBox.PreferredSize.Height;
                    }
                }

                //groupBox.Location= new Point(groupBox.Location.X, top+enBuyukSatirYuksekligi);

                pnlSorular.Controls.Add(groupBox);

            }

            prgCevapOrani.Maximum = soruSayisi;
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            var parentGroupBox = radio.Parent as SoruGroupBox;

            if (!parentGroupBox.CevaplandiMi)
            {
                prgCevapOrani.Value++;
                parentGroupBox.CevaplandiMi = true;
            }

            parentGroupBox.SeciliSecenek = radio;
        }

        private void BaslangicDegerleriniTanimla(StreamReader streamReader)
        {
            lblSinavAdi.Text = streamReader.ReadLine();
            lblSinavAciklama.Text = streamReader.ReadLine();
            SinavSüresi = TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()));
            SinavSüresiYüzdeOn = SinavSüresi.TotalSeconds * 0.1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SinavSüresi.TotalSeconds == 0)
            {
                SinaviBitir();
                return;
            }

            this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");

            if (SinavSüresi.TotalSeconds <= SinavSüresiYüzdeOn)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }

            SinavSüresi = TimeSpan.FromSeconds(SinavSüresi.TotalSeconds - 1);
        }

        private void frmSinavEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            SecenekleriAktifPasifYap(true);
            (sender as Button).Enabled = false;
            timer1.Start();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            SinaviBitir();
        }

        private void SinaviBitir()
        {
            timer1.Stop();
            SecenekleriAktifPasifYap(false);
            btnBitir.Enabled = false;

            string fileName = $"{lblSinavAdi.Text}-{lblAdSoyad.Text}.txt";
            saveFileDialog1.FileName = fileName;
            saveFileDialog1.ShowDialog();

            using (var streamWriter = new StreamWriter(saveFileDialog1.FileName, false))
            {
                streamWriter.WriteLine(lblSinavAdi.Text);

                foreach (var item in SoruKutulari)
                {
                    if (item.CevaplandiMi)
                    {
                        streamWriter.WriteLine($"{item.SoruNumarasi} - {item.SeciliSecenek.Tag}");
                    }

                    //foreach (var radio in item.Value)
                    //{
                    //    if (radio.Checked)
                    //    {
                    //        streamWriter.WriteLine($"{item.Key} - {radio.Tag}");
                    //        break;
                    //    }
                    //}
                }


                //for (int i = 0; i < pnlSorular.Controls.Count; i++)
                //{
                //    var item = pnlSorular.Controls[i];

                //    for (int j = 0; j < item.Controls.Count-1; j++)
                //    {
                //        if ((item.Controls[j] as RadioButton).Checked)
                //        {
                //            streamWriter.WriteLine($"{i} - {(item.Controls[j] as RadioButton).Tag}");
                //            break;
                //        }
                //    }

                //}

            }
        }

        private void SecenekleriAktifPasifYap(bool isEnabled)
        {
            foreach (var item in SoruKutulari)
            {
                foreach (var item2 in item.Controls)
                {
                    if(!(item2 is RadioButton))
                    {
                        continue;
                    }

                    (item2 as RadioButton).Enabled = isEnabled;
                }
            }
        }
    }
}
