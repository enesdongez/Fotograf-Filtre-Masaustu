namespace Steganography
{
    partial class Steganography
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
            this.MesajGizle = new System.Windows.Forms.Button();
            this.girilenMesaj = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.gelenSifre = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResimYukle = new System.Windows.Forms.Button();
            this.ResimSec = new System.Windows.Forms.Button();
            this.gelenCikti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.girilenSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KontrolEt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MesajGizle
            // 
            this.MesajGizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MesajGizle.Location = new System.Drawing.Point(340, 327);
            this.MesajGizle.Name = "MesajGizle";
            this.MesajGizle.Size = new System.Drawing.Size(98, 46);
            this.MesajGizle.TabIndex = 0;
            this.MesajGizle.Text = "Gizle ve Kaydet";
            this.MesajGizle.UseVisualStyleBackColor = true;
            this.MesajGizle.Click += new System.EventHandler(this.MesajGizle_Click);
            // 
            // girilenMesaj
            // 
            this.girilenMesaj.Font = new System.Drawing.Font("Tahoma", 12F);
            this.girilenMesaj.Location = new System.Drawing.Point(84, 269);
            this.girilenMesaj.Multiline = true;
            this.girilenMesaj.Name = "girilenMesaj";
            this.girilenMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.girilenMesaj.Size = new System.Drawing.Size(245, 114);
            this.girilenMesaj.TabIndex = 2;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.Location = new System.Drawing.Point(32, 66);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(406, 197);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
          
            // 
            // gelenSifre
            // 
            this.gelenSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gelenSifre.Location = new System.Drawing.Point(340, 295);
            this.gelenSifre.Name = "gelenSifre";
            this.gelenSifre.PasswordChar = '*';
            this.gelenSifre.Size = new System.Drawing.Size(98, 26);
            this.gelenSifre.TabIndex = 7;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(87, 433);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(0, 20);
            this.notesLabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-59, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mesaj Gir:";
            // 
            // ResimYukle
            // 
            this.ResimYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResimYukle.Location = new System.Drawing.Point(151, 14);
            this.ResimYukle.Name = "ResimYukle";
            this.ResimYukle.Size = new System.Drawing.Size(155, 46);
            this.ResimYukle.TabIndex = 13;
            this.ResimYukle.Text = "Resim Yükle";
            this.ResimYukle.UseVisualStyleBackColor = true;
            this.ResimYukle.Click += new System.EventHandler(this.ResimYukle_Click);
            // 
            // ResimSec
            // 
            this.ResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResimSec.Location = new System.Drawing.Point(142, 14);
            this.ResimSec.Name = "ResimSec";
            this.ResimSec.Size = new System.Drawing.Size(155, 46);
            this.ResimSec.TabIndex = 14;
            this.ResimSec.Text = "Resim Seç";
            this.ResimSec.UseVisualStyleBackColor = true;
            this.ResimSec.Click += new System.EventHandler(this.ResimSec_Click);
            // 
            // gelenCikti
            // 
            this.gelenCikti.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gelenCikti.Location = new System.Drawing.Point(74, 269);
            this.gelenCikti.Multiline = true;
            this.gelenCikti.Name = "gelenCikti";
            this.gelenCikti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gelenCikti.Size = new System.Drawing.Size(214, 114);
            this.gelenCikti.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Şifre:";
            // 
            // girilenSifre
            // 
            this.girilenSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girilenSifre.Location = new System.Drawing.Point(294, 295);
            this.girilenSifre.Name = "girilenSifre";
            this.girilenSifre.PasswordChar = '*';
            this.girilenSifre.Size = new System.Drawing.Size(117, 26);
            this.girilenSifre.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Çıktı:";
            // 
            // KontrolEt
            // 
            this.KontrolEt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KontrolEt.Location = new System.Drawing.Point(294, 327);
            this.KontrolEt.Name = "KontrolEt";
            this.KontrolEt.Size = new System.Drawing.Size(117, 34);
            this.KontrolEt.TabIndex = 20;
            this.KontrolEt.Text = "Mesajı Gör";
            this.KontrolEt.UseVisualStyleBackColor = true;
            this.KontrolEt.Click += new System.EventHandler(this.KontrolEt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(34, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Uyarılar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ResimYukle);
            this.groupBox1.Controls.Add(this.MesajGizle);
            this.groupBox1.Controls.Add(this.girilenMesaj);
            this.groupBox1.Controls.Add(this.imagePictureBox);
            this.groupBox1.Controls.Add(this.gelenSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 396);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifreli Resim Oluştur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mesajını Gir:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.ResimSec);
            this.groupBox2.Controls.Add(this.gelenCikti);
            this.groupBox2.Controls.Add(this.girilenSifre);
            this.groupBox2.Controls.Add(this.KontrolEt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(494, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 396);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreli Resim Çözümle";
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notesLabel);
            this.MaximizeBox = false;
            this.Name = "Steganography";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography Project";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MesajGizle;
        private System.Windows.Forms.TextBox girilenMesaj;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox gelenSifre;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResimYukle;
        private System.Windows.Forms.Button ResimSec;
        private System.Windows.Forms.TextBox gelenCikti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox girilenSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KontrolEt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

