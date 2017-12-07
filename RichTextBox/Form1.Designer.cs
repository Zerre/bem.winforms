namespace RichTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirmiziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digerRenkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altcizgiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size8toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size10toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size12toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeDigertoolStripTxt = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFontSec = new System.Windows.Forms.Button();
            this.btnSolaYasla = new System.Windows.Forms.Button();
            this.btnOrtala = new System.Windows.Forms.Button();
            this.btnSagaYasla = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.menuDosya = new System.Windows.Forms.MenuStrip();
            this.menuItemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAç = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuDosya.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(12, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(461, 402);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.boyutToolStripMenuItem,
            this.toolStripSeparator1,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 142);
            // 
            // renkToolStripMenuItem
            // 
            this.renkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesilToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.kirmiziToolStripMenuItem,
            this.digerRenkToolStripMenuItem});
            this.renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            this.renkToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.renkToolStripMenuItem.Text = "Renk";
            // 
            // yesilToolStripMenuItem
            // 
            this.yesilToolStripMenuItem.Name = "yesilToolStripMenuItem";
            this.yesilToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yesilToolStripMenuItem.Text = "Yeşil";
            this.yesilToolStripMenuItem.Click += new System.EventHandler(this.yesilToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // kirmiziToolStripMenuItem
            // 
            this.kirmiziToolStripMenuItem.Name = "kirmiziToolStripMenuItem";
            this.kirmiziToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kirmiziToolStripMenuItem.Text = "Kırmızı";
            this.kirmiziToolStripMenuItem.Click += new System.EventHandler(this.kirmiziToolStripMenuItem_Click);
            // 
            // digerRenkToolStripMenuItem
            // 
            this.digerRenkToolStripMenuItem.Name = "digerRenkToolStripMenuItem";
            this.digerRenkToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.digerRenkToolStripMenuItem.Text = "Diğer";
            this.digerRenkToolStripMenuItem.Click += new System.EventHandler(this.digerRenkToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalinToolStripMenuItem,
            this.italikToolStripMenuItem,
            this.altcizgiliToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // kalinToolStripMenuItem
            // 
            this.kalinToolStripMenuItem.Name = "kalinToolStripMenuItem";
            this.kalinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kalinToolStripMenuItem.Text = "Kalın";
            this.kalinToolStripMenuItem.Click += new System.EventHandler(this.kalinToolStripMenuItem_Click);
            // 
            // italikToolStripMenuItem
            // 
            this.italikToolStripMenuItem.Name = "italikToolStripMenuItem";
            this.italikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.italikToolStripMenuItem.Text = "İtalik";
            this.italikToolStripMenuItem.Click += new System.EventHandler(this.italikToolStripMenuItem_Click);
            // 
            // altcizgiliToolStripMenuItem
            // 
            this.altcizgiliToolStripMenuItem.Name = "altcizgiliToolStripMenuItem";
            this.altcizgiliToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altcizgiliToolStripMenuItem.Text = "Altçizgili";
            this.altcizgiliToolStripMenuItem.Click += new System.EventHandler(this.altcizgiliToolStripMenuItem_Click);
            // 
            // boyutToolStripMenuItem
            // 
            this.boyutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.size8toolStripMenuItem,
            this.size10toolStripMenuItem,
            this.size12toolStripMenuItem,
            this.sizeDigertoolStripTxt});
            this.boyutToolStripMenuItem.Name = "boyutToolStripMenuItem";
            this.boyutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.boyutToolStripMenuItem.Text = "Boyut";
            // 
            // size8toolStripMenuItem
            // 
            this.size8toolStripMenuItem.Name = "size8toolStripMenuItem";
            this.size8toolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.size8toolStripMenuItem.Text = "8";
            this.size8toolStripMenuItem.Click += new System.EventHandler(this.size8toolStripMenuItem_Click);
            // 
            // size10toolStripMenuItem
            // 
            this.size10toolStripMenuItem.Name = "size10toolStripMenuItem";
            this.size10toolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.size10toolStripMenuItem.Text = "10";
            this.size10toolStripMenuItem.Click += new System.EventHandler(this.size10toolStripMenuItem_Click);
            // 
            // size12toolStripMenuItem
            // 
            this.size12toolStripMenuItem.Name = "size12toolStripMenuItem";
            this.size12toolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.size12toolStripMenuItem.Text = "12";
            this.size12toolStripMenuItem.Click += new System.EventHandler(this.size12toolStripMenuItem_Click);
            // 
            // sizeDigertoolStripTxt
            // 
            this.sizeDigertoolStripTxt.Name = "sizeDigertoolStripTxt";
            this.sizeDigertoolStripTxt.Size = new System.Drawing.Size(100, 23);
            this.sizeDigertoolStripTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeDigertoolStripTxt_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // btnFontSec
            // 
            this.btnFontSec.Location = new System.Drawing.Point(12, 45);
            this.btnFontSec.Name = "btnFontSec";
            this.btnFontSec.Size = new System.Drawing.Size(75, 23);
            this.btnFontSec.TabIndex = 1;
            this.btnFontSec.Text = "Font Seç";
            this.btnFontSec.UseVisualStyleBackColor = true;
            this.btnFontSec.Click += new System.EventHandler(this.btnFontSec_Click);
            // 
            // btnSolaYasla
            // 
            this.btnSolaYasla.Location = new System.Drawing.Point(115, 45);
            this.btnSolaYasla.Name = "btnSolaYasla";
            this.btnSolaYasla.Size = new System.Drawing.Size(75, 23);
            this.btnSolaYasla.TabIndex = 2;
            this.btnSolaYasla.Text = "Sola Yasla";
            this.btnSolaYasla.UseVisualStyleBackColor = true;
            this.btnSolaYasla.Click += new System.EventHandler(this.btnSolaYasla_Click);
            // 
            // btnOrtala
            // 
            this.btnOrtala.Location = new System.Drawing.Point(196, 45);
            this.btnOrtala.Name = "btnOrtala";
            this.btnOrtala.Size = new System.Drawing.Size(75, 23);
            this.btnOrtala.TabIndex = 3;
            this.btnOrtala.Text = "Ortala";
            this.btnOrtala.UseVisualStyleBackColor = true;
            this.btnOrtala.Click += new System.EventHandler(this.btnOrtala_Click);
            // 
            // btnSagaYasla
            // 
            this.btnSagaYasla.Location = new System.Drawing.Point(277, 45);
            this.btnSagaYasla.Name = "btnSagaYasla";
            this.btnSagaYasla.Size = new System.Drawing.Size(75, 23);
            this.btnSagaYasla.TabIndex = 4;
            this.btnSagaYasla.Text = "Sağa Yasla";
            this.btnSagaYasla.UseVisualStyleBackColor = true;
            this.btnSagaYasla.Click += new System.EventHandler(this.btnSagaYasla_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(398, 45);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnRenkDegistir.TabIndex = 5;
            this.btnRenkDegistir.Text = "Renk";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // menuDosya
            // 
            this.menuDosya.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemYeni,
            this.menuItemAç,
            this.kaydetToolStripMenuItem});
            this.menuDosya.Location = new System.Drawing.Point(0, 0);
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(485, 24);
            this.menuDosya.TabIndex = 6;
            this.menuDosya.Text = "Dosya";
            // 
            // menuItemYeni
            // 
            this.menuItemYeni.Name = "menuItemYeni";
            this.menuItemYeni.Size = new System.Drawing.Size(41, 20);
            this.menuItemYeni.Text = "Yeni";
            this.menuItemYeni.Click += new System.EventHandler(this.menuItemYeni_Click);
            // 
            // menuItemAç
            // 
            this.menuItemAç.Name = "menuItemAç";
            this.menuItemAç.Size = new System.Drawing.Size(33, 20);
            this.menuItemAç.Text = "Aç";
            this.menuItemAç.Click += new System.EventHandler(this.menuItemAç_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 497);
            this.Controls.Add(this.btnRenkDegistir);
            this.Controls.Add(this.btnSagaYasla);
            this.Controls.Add(this.btnOrtala);
            this.Controls.Add(this.btnSolaYasla);
            this.Controls.Add(this.btnFontSec);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuDosya);
            this.MainMenuStrip = this.menuDosya;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuDosya.ResumeLayout(false);
            this.menuDosya.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFontSec;
        private System.Windows.Forms.Button btnSolaYasla;
        private System.Windows.Forms.Button btnOrtala;
        private System.Windows.Forms.Button btnSagaYasla;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.MenuStrip menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuItemYeni;
        private System.Windows.Forms.ToolStripMenuItem menuItemAç;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirmiziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digerRenkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altcizgiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size8toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size10toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size12toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox sizeDigertoolStripTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
    }
}

