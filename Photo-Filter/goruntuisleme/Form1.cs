using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace goruntuisleme
{
    public partial class Form1 : Form
    {
        int sayi = 10;


        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            panel1.AutoScroll = true;
            panel2.AutoScroll = true;
            trackBar1.Minimum = -300;
            trackBar1.Maximum = 300;
       
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            resimsec();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image==null)
                MessageBox.Show("Önce bir resim Seçin");
            else 
            pictureBox2.Image = terscevir(new Bitmap(pictureBox1.Image));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Önce bir resim Seçin");
            else
                pictureBox2.Image = gri(new Bitmap(pictureBox1.Image));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Önce bir resim Seçin");
            else
                pictureBox2.Image = negatif(new Bitmap(pictureBox1.Image));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Önce bir resim Seçin");
            else
                pictureBox2.Image = parlakligiartir(new Bitmap(pictureBox1.Image),sayi);
            sayi += 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Önce bir resim Seçin");
            else
                pictureBox2.Image = parlakligiazalt(new Bitmap(pictureBox1.Image), sayi);
            sayi += 10;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
                MessageBox.Show("Resmi düzenleyiniz..");
            else
                resimkaydet();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Önce bir resim Seçin");
            else
                pictureBox2.Image = aynalama(new Bitmap(pictureBox1.Image));
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Önce bir resim Seçin");
            else
                pictureBox2.Image = zoomin(new Bitmap(pictureBox1.Image));
            
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Seçili resim yok");
            else
                pictureBox2.Image = zoomin(new Bitmap(pictureBox2.Image));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Seçili resim yok");
            else
                pictureBox2.Image = zoomout(new Bitmap(pictureBox2.Image));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Seçili resim yok");
            else
                pictureBox2.Image = histogramEşitleme(new Bitmap(pictureBox2.Image));
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            boyutlandırma();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Seçili resim yok");
            else
                pictureBox2.Image = otsu(new Bitmap(pictureBox2.Image));
        }

        private void button11_Click_3(object sender, EventArgs e)
        {
            Bitmap resim = new Bitmap(pictureBox1.Image);
            pictureBox2.Image = resim;
        }




        public void resimsec()
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;

            Bitmap bitmap1 = (Bitmap)Bitmap.FromFile(DosyaYolu);

            pictureBox1.Image = bitmap1;
        }

        public void resimkaydet()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif";

            saveFileDialog1.ShowDialog();

            FileStream DosyaAkisi = (FileStream)saveFileDialog1.OpenFile();

            pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg);

            DosyaAkisi.Close();
        }

        public Bitmap terscevir(Bitmap resim)
        {

            Bitmap cikisresmi = new Bitmap(resim);
            for (int j = 0; j < resim.Height; j++)
                for (int k = 0; k < resim.Width; k++)
                {
                    cikisresmi.SetPixel(k, resim.Height - j - 1 , Color.FromArgb(resim.GetPixel(k, j).R, resim.GetPixel(k, j).G, resim.GetPixel(k, j).B));
                }
            return cikisresmi;
        }

        public Bitmap gri(Bitmap resim)
        {
            Bitmap yeniResim = new Bitmap(resim.Width, resim.Height);
            for (int i = 0; i < resim.Width; i++)
            {
                for (int j = 0; j < resim.Height; j++)
                {
                    Color renk = resim.GetPixel(i, j);

                    int yeniRenk = Convert.ToInt32(renk.R * 0.299 + renk.G * 0.587 + renk.B * 0.114);
                    yeniResim.SetPixel(i, j, Color.FromArgb(yeniRenk, yeniRenk, yeniRenk));
                }
            }
            return yeniResim;
        }

        public Bitmap negatif(Bitmap GirisResmi)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int i = 0, j = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = 255 - OkunanRenk.R;
                    G = 255 - OkunanRenk.G;
                    B = 255 - OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            return CikisResmi;
        }

        public Bitmap parlakligiartir(Bitmap GirisResmi, int deger)
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            Bitmap CikisResmi;

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int i = 0, j = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    R = OkunanRenk.R + deger;
                    G = OkunanRenk.G + deger;
                    B = OkunanRenk.B + deger;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            return CikisResmi;
        }
        public Bitmap parlakligiazalt(Bitmap GirisResmi, int deger)
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            Bitmap CikisResmi;

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int i = 0, j = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    R = OkunanRenk.R - deger;
                    G = OkunanRenk.G - deger;
                    B = OkunanRenk.B - deger;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            return CikisResmi;
        }

        public Bitmap aynalama(Bitmap resim) {
            
            Bitmap cikisresmi = new Bitmap(resim);
            for (int j = 0; j < resim.Height; j++)
                for (int k = 0; k < resim.Width; k++)
                {
                    cikisresmi.SetPixel(resim.Width - k - 1, j, Color.FromArgb(resim.GetPixel(k,j).R, resim.GetPixel(k, j).G, resim.GetPixel(k, j).B));
                }
            return cikisresmi;
        }
     
        public Bitmap zoomin(Bitmap resim)
        {
            Bitmap cikisresmi = new Bitmap(resim, Convert.ToInt32(resim.Width * 2), Convert.ToInt32(resim.Height * 2));
            return cikisresmi;

        }
        public Bitmap zoomout(Bitmap resim)
        {
            Bitmap cikisresmi = new Bitmap(resim, Convert.ToInt32(resim.Width / 2), Convert.ToInt32(resim.Height / 2));
            return cikisresmi;

        }
        public void boyutlandırma()
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Seçili resim yok");
            else
            {
                Bitmap cikisresmi = new Bitmap(pictureBox1.Image, Convert.ToInt32(pictureBox1.Image.Width + trackBar1.Value), Convert.ToInt32(pictureBox1.Image.Height + trackBar1.Value));
                pictureBox2.Image = cikisresmi;
            }

        }
  

        public Bitmap histogramEşitleme(Bitmap KaynakResim)
        {
            Bitmap renderedImage = KaynakResim;

            uint pixels = (uint)renderedImage.Height * (uint)renderedImage.Width;
            decimal Const = 255 / (decimal)pixels;

            int x, y, R, G, B;


            int[] HistogramRed2 = new int[256];
            int[] HistogramGreen2 = new int[256];
            int[] HistogramBlue2 = new int[256];


            for (var i = 0; i < renderedImage.Width; i++)
            {
                for (var j = 0; j < renderedImage.Height; j++)
                {
                    var piksel = renderedImage.GetPixel(i, j);

                    HistogramRed2[(int)piksel.R]++;
                    HistogramGreen2[(int)piksel.G]++;
                    HistogramBlue2[(int)piksel.B]++;

                }
            }

            int[] cdfR = HistogramRed2;
            int[] cdfG = HistogramGreen2;
            int[] cdfB = HistogramBlue2;

            for (int r = 1; r <= 255; r++)
            {
                cdfR[r] = cdfR[r] + cdfR[r - 1];
                cdfG[r] = cdfG[r] + cdfG[r - 1];
                cdfB[r] = cdfB[r] + cdfB[r - 1];
            }

            for (y = 0; y < renderedImage.Height; y++)
            {
                for (x = 0; x < renderedImage.Width; x++)
                {
                    Color pixelColor = renderedImage.GetPixel(x, y);

                    R = (int)((decimal)cdfR[pixelColor.R] * Const);
                    G = (int)((decimal)cdfG[pixelColor.G] * Const);
                    B = (int)((decimal)cdfB[pixelColor.B] * Const);

                    Color newColor = Color.FromArgb(R, G, B);
                    renderedImage.SetPixel(x, y, newColor);
                }
            }
            return renderedImage;
        }

        public Bitmap otsu(Bitmap kaynakresim)
        {

            Bitmap filtreliResim;
            OtsuThreshold otsuFiltre = new OtsuThreshold();

            filtreliResim = otsuFiltre.Apply(kaynakresim.PixelFormat != PixelFormat.Format8bppIndexed ? Grayscale.CommonAlgorithms.BT709.Apply(kaynakresim) : kaynakresim);

            return filtreliResim;


        }
  

      
      
    }
}
