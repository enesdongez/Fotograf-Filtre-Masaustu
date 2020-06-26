using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Steganography
{
    public partial class Steganography : Form
    {
        private Bitmap bmp = null;
        private string GelenMesaj = string.Empty;

        public Steganography()
        {
            InitializeComponent();
        }

        private void MesajGizle_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string text = girilenMesaj.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("Mesaj Girilmedi!", "Dikkat");

                return;
            }
            if (gelenSifre.Text.Equals(""))
            {
                MessageBox.Show("Şifre Girilmedi!", "Dikkat");

                return;
            }

            text = Crypto.EncryptStringAES(text, gelenSifre.Text);

            bmp = SteganographyHelper.embedText(text, bmp);

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }


            }

            notesLabel.Text = "Mesaj içerikli resim kayıt oldu.";
            notesLabel.ForeColor = Color.Green;
        }

        private void KontrolEt_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;

            string GelenMesaj = SteganographyHelper.extractText(bmp);

            if (girilenSifre.Text == "")
            {
                MessageBox.Show("Şifre Girilmedi!", "Dikkat");
                return;
            }
            try
            {
                GelenMesaj = Crypto.DecryptStringAES(GelenMesaj, girilenSifre.Text);
                notesLabel.Text = "";
            }
            catch
            {
                notesLabel.Text = "Yanlış";
                notesLabel.ForeColor = Color.Red;
                return;
            }


            gelenCikti.Text = GelenMesaj;
        }

        private void ResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
            }
        }

        private void ResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open_dialog.FileName);
            }
        }

    }
}