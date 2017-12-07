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

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur a maximus quam. Ut vehicula a mauris id aliquam. Morbi faucibus consequat interdum. Morbi cursus leo eu augue iaculis, et blandit eros finibus. Donec efficitur condimentum velit. Nam in augue at lacus mattis fringilla. Integer quis orci diam. Aenean eget tristique urna, eget varius libero. Ut id mollis magna.

Etiam sed accumsan risus, vitae gravida ex. Donec ex risus, mollis quis pulvinar nec, vehicula quis nisi. Integer eleifend urna sed tortor venenatis feugiat vitae in mi. Nam sagittis est at tincidunt dignissim. Curabitur nec ligula luctus, sollicitudin ligula at, aliquet nulla. Praesent vitae iaculis libero. Proin dignissim interdum commodo. Nam nec aliquam magna.";
        }

        private void btnFontSec_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void btnSolaYasla_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnOrtala_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnSagaYasla_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void menuItemYeni_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void menuItemAç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            var reader = new StreamReader(openFileDialog1.FileName, Encoding.Default);

            var text = reader.ReadToEnd();

            richTextBox1.Text = text;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            using (var streamWriter = new StreamWriter(saveFileDialog1.FileName, true))
            {
                streamWriter.Write(richTextBox1.Text);
            }
        }

        private void yesilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
            yesilToolStripMenuItem.Checked = !yesilToolStripMenuItem.Checked;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
            maviToolStripMenuItem.Checked = !maviToolStripMenuItem.Checked;
        }

        private void kirmiziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;

        }

        private void digerRenkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        Font font;
        bool fontVarMi = false;
        Font fontEkleCikar(int size)
        {
            //bool bold = richTextBox1.SelectionFont.Bold;
            //bool italic = richTextBox1.SelectionFont.Italic;
            //bool underline = richTextBox1.SelectionFont.Underline;

            if (kalinYazi && italicYazi && altCizgiliYazi)
            {
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                fontVarMi = true;
                kalinToolStripMenuItem.Checked = true;
                italikToolStripMenuItem.Checked = true;
                altcizgiliToolStripMenuItem.Checked = true;
                return font;
            }

            if (kalinYazi && !kalinToolStripMenuItem.Checked)
            {
                kalinToolStripMenuItem.Checked = true;

                if (italicYazi && altCizgiliYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (altCizgiliYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Underline);
                }
                else if (italicYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic);
                }
                else
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold);
                }
                fontVarMi = true;
                return font;
            }

            if (italicYazi && !italikToolStripMenuItem.Checked)
            {
                italikToolStripMenuItem.Checked = true;
                if (kalinYazi && altCizgiliYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (altCizgiliYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Italic | FontStyle.Underline);
                }
                else if (kalinYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic);
                }
                else
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Italic);
                }
                fontVarMi = true;
                return font;
            }

            if (altCizgiliYazi && !altcizgiliToolStripMenuItem.Checked)
            {
                altcizgiliToolStripMenuItem.Checked = true;
                if (kalinYazi && italicYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                else if (kalinYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Underline);
                }
                else if (italicYazi)
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Italic | FontStyle.Underline);
                }
                else
                {
                    font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Underline);
                }
                fontVarMi = true;
                return font;
            }

            if (!kalinYazi && !italicYazi && !altCizgiliYazi)
            {
                fontVarMi = false;
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Regular);
                kalinToolStripMenuItem.Checked = false;
                italikToolStripMenuItem.Checked = false;
                altcizgiliToolStripMenuItem.Checked = false;
            }
            else if (!kalinYazi && !italicYazi)
            {
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Underline);
                kalinToolStripMenuItem.Checked = false;
                italikToolStripMenuItem.Checked = false;
            }
            else if (!kalinYazi && !altCizgiliYazi)
            {
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Italic);
                kalinToolStripMenuItem.Checked = false;
                altcizgiliToolStripMenuItem.Checked = false;
            }
            else if (!altCizgiliYazi && !italicYazi)
            {
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold);
                altcizgiliToolStripMenuItem.Checked = false;
                italikToolStripMenuItem.Checked = false;
            }
            else if (!kalinYazi)
            {
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Italic | FontStyle.Underline);
                kalinToolStripMenuItem.Checked = false;
            }
            else if (!italicYazi)
            {
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Underline);
                kalinToolStripMenuItem.Checked = false;
                italikToolStripMenuItem.Checked = false;
            }
            else if (!altCizgiliYazi)
            {
                font = new Font(richTextBox1.Font.FontFamily, size, FontStyle.Bold | FontStyle.Italic);
                kalinToolStripMenuItem.Checked = false;
                altcizgiliToolStripMenuItem.Checked = false;
            }

            return font;
        }

        int YaziBoyutu = 8;
        bool kalinYazi = false;
        private void kalinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kalinYazi = !kalinYazi;
            richTextBox1.SelectionFont = fontEkleCikar(YaziBoyutu);
        }

        bool italicYazi = false;
        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicYazi = !italicYazi;
            richTextBox1.SelectionFont = fontEkleCikar(YaziBoyutu);
        }

        bool altCizgiliYazi = false;
        private void altcizgiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altCizgiliYazi = !altCizgiliYazi;
            richTextBox1.SelectionFont = fontEkleCikar(YaziBoyutu);
        }

        private void size8toolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziBoyutu = Convert.ToInt32(size8toolStripMenuItem.Text);
            richTextBox1.SelectionFont = fontEkleCikar(YaziBoyutu);
        }

        private void size10toolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziBoyutu = Convert.ToInt32(size10toolStripMenuItem.Text);
            richTextBox1.SelectionFont = fontEkleCikar(YaziBoyutu);
        }

        private void size12toolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziBoyutu = Convert.ToInt32(size12toolStripMenuItem.Text);
            richTextBox1.SelectionFont = fontEkleCikar(YaziBoyutu);
        }

        private void sizeDigertoolStripTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                YaziBoyutu = Convert.ToInt32(sizeDigertoolStripTxt.Text);
                richTextBox1.SelectionFont = fontEkleCikar(YaziBoyutu);
            }
        }
    }
}