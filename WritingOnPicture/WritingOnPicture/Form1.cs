using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingOnPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim = "Dosya Seç";
        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
            if (resim != "Dosya Seç")
            {
                pictureBox1.Load(resim);
            }
        }

        Color renk;
        private void btnRenk_Click(object sender, EventArgs e)
        {
            if (resim == "Dosya Seç")
            {
                MessageBox.Show("Lütfen bir resim seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                colorDialog1.ShowDialog();
                renk = colorDialog1.Color;
            }
        }

        Bitmap bmp;
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (resim == "Dosya Seç")
            {
                MessageBox.Show("Lütfen bir resim seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (renk.IsEmpty)
                {
                    MessageBox.Show("Lütfen bir renk seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtMetin.Text == string.Empty)
                    {
                        MessageBox.Show("Lütfen bir metin yazınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txtBoyut.Text == string.Empty)
                        {
                            MessageBox.Show("Lütfen bir metin boyutu yazınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            bmp = new Bitmap(resim);
                            Graphics gr = Graphics.FromImage(bmp);
                            gr.DrawString(txtMetin.Text, new Font("Segoe UI", Convert.ToInt16(txtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
                            pictureBox1.Image = bmp;
                            btnKaydet.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog1.FileName);
                MessageBox.Show("Resminiz başarıyla kaydedildi!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Bir Dosya Seçiniz";
            openFileDialog1.FileName = "Dosya Seç";
            openFileDialog1.Filter = "Jpg Dosyaları (*.jpg)|*.jpg|Png Dosyaları (*.png)|*.png|Tüm Dosyalar|*";
            btnKaydet.Enabled = false;

        }

        private void txtBoyut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
