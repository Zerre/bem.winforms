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
            btnBitir.Enabled = false;
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                SinavSüresi = TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()));
                SinavSüresiYüzdeOn = SinavSüresi.TotalSeconds * 0.1;

                string line = "";

                int left = 0;
                int top = 0;
                int grpSolHeight = 0;
                int grpSagHeight = 0;

                while (!string.IsNullOrWhiteSpace((line = streamReader.ReadLine())))
                {
                    soruSayisi++;
                    var items = line.Split('|');

                    left = (soruSayisi % 2 == 1) ? 0 : 286;
                    top += (soruSayisi % 2 == 1) ? (grpSolHeight >= grpSagHeight) ? grpSolHeight + 15 : grpSagHeight + 15 : 0;

                    var groupBox = new GroupBox
                    {
                        Location = new Point(left, top),
                        Size = new Size(275, 0),
                        AutoSize = true,
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
                            Name = soruSayisi + "rdbCevap" + i,
                            Tag = (soruSayisi - 1) + "-" + (i - 1)
                        };
                        radio.CheckedChanged += Radio_CheckedChanged;

                        groupBox.Controls.Add(radio);
                        radioTop = radio.Location.Y + radio.PreferredSize.Height + 15;
                    }

                    groupBox.Controls.Add(lbl);

                    int cehennemdenGelen = (soruSayisi % 2 == 0) ? (grpSagHeight = groupBox.PreferredSize.Height) : (grpSolHeight = groupBox.PreferredSize.Height);
                    pnlSorular.Controls.Add(groupBox);
                };

                prgCevapOrani.Maximum = soruSayisi;
            }
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Parent.Tag != "Tiklandi")
            {
                prgCevapOrani.Value += 1;
                (sender as RadioButton).Parent.Tag = "Tiklandi";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SinavSüresi.TotalSeconds <= 0)
            {
                CevaplariKaydet();
                timer1.Stop();
            }
            this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");

            if (SinavSüresi.TotalSeconds <= SinavSüresiYüzdeOn)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            SinavSüresi = TimeSpan.FromSeconds(SinavSüresi.TotalSeconds - 1);
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = false;
            btnBitir.Enabled = true;
            timer1.Start();
            SinavBaslaBitir(true);
        }

        private void SinavBaslaBitir(bool baslaBitir)
        {
            foreach (Control grpBox in pnlSorular.Controls)
            {
                foreach (Control radio in grpBox.Controls)
                {
                    if (radio is RadioButton)
                    {
                        radio.Enabled = baslaBitir;
                    }
                }
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnBitir.Enabled = false;
            SinavBaslaBitir(false);
            CevaplariKaydet();
        }

        private void CevaplariKaydet()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(lblSinavAdi.Text);
            foreach (Control grpBox in pnlSorular.Controls)
            {
                foreach (Control radio in grpBox.Controls)
                {
                    if (radio is RadioButton)
                    {
                        if ((radio as RadioButton).Checked)
                        {
                            string[] soruCevap = (radio as RadioButton).Tag.ToString().Split('-');
                            text.AppendLine(soruCevap[0] + " " + soruCevap[1]);
                        }
                    }
                }
            }
            using (var streamWriter = new StreamWriter(@"C:\Users\Sami\Documents\Visual Studio 2017\Projects\Github Projects\bem.winforms\SinavApp\Cevaplar\" + lblAdSoyad.Text + ".txt", false))
            {
                streamWriter.Write(text);
            }
        }
    }
}
