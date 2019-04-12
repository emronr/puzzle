using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;



namespace yazlab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        Bitmap img1, img2;
        int count1 = 0, count2 = 0;
        bool ayni = true;
        bool izin = true;
        Bitmap bmp1, bmp2;
        int pixel1, pixel2;
        public static int puan = 100;
        int sayac = 0;

        PictureBox[] sira = new PictureBox[2];
        PictureBox gecici = new PictureBox();
        List<int> liste = new List<int>();
        List<int> sirali = new List<int>();

        private void dosyaEkle1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyaları |*.png;*.jpg";

            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox33.Image = new Bitmap(dosya.OpenFile());
            }
            if (this.pictureBox33.Height != this.pictureBox33.Width)
            {
                MessageBox.Show("Lütfen kare bir fotoğraf seçiniz!!!");

            }
            /// GÜNCELLEME İŞLEMİ
            richTextBox.Text = "";
            StreamReader sw = new StreamReader(Application.StartupPath + "\\enyuksekskor.txt");
            String satir;
            int say = 0;

            while ((satir = sw.ReadLine()) != null)
            {
                //listBox.Items.Add(satir);
                richTextBox.AppendText(satir + "\n");
                say++;
            }
            sw.Close();
            button2.Enabled = true;

        }
        List<Point> Liste = new List<Point>();

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //sayac++;
            PictureBox pix = (PictureBox)sender;
            pix.BorderStyle = BorderStyle.Fixed3D;
            var i = (from PictureBox pbx in this.panel1.Controls.OfType<PictureBox>()
                     where pbx.BorderStyle == BorderStyle.Fixed3D
                     select pbx).ToList();
            if (i.Count() == 1)
            {
                sira[0] = i[0];
            }
            if (i.Count() == 2)
            {
                sira[1] = i[1];
            }

            if (i.Count() == 2)
            {
                bmp1 = new Bitmap(sira[0].Image);
                bmp2 = new Bitmap(sira[1].Image);
                for (int j = 0; j < i[0].Image.Width; j++)
                {
                    for (int k = 0; k < i[0].Image.Height; k++)
                    {
                        pixel1 = (bmp1.GetPixel(j, k).R + bmp1.GetPixel(j, k).G + bmp1.GetPixel(j, k).B) / 3;
                        pixel2 = (bmp2.GetPixel(j, k).R + bmp2.GetPixel(j, k).G + bmp2.GetPixel(j, k).B) / 3;
                    }

                }
                //  MessageBox.Show("pixel1" + pixel1 + "   pixel2" + pixel2);
                if (pixel1 == pixel2)
                {
                    gecici = i[0];
                    i[0] = i[1];
                    i[1] = gecici;
                }
                aynimi(i[0], i[1]);
                if (izin == true)
                {
                    degistir(i[0], i[1]);
                    i.Clear();

                }
                if (izin == false)
                {
                    sayac++;
                    i[0].BorderStyle = BorderStyle.None;
                    i[1].BorderStyle = BorderStyle.None;
                    i.Clear();
                }

            }



            Liste.Clear();
            ///BİTTİ Mİ KONTROL
            foreach (PictureBox p in panel1.Controls)
            {
                if (p.Name == p.Location.ToString()) { Liste.Add(p.Location); }
            }
            if (Liste.Count == panel1.Controls.Count)
            {
                puan = puan - (sayac * 5);
                ///PUAN HESABI




                DialogResult secenek = MessageBox.Show("Puanınız= " + puan + "\n Kaydetmek istiyor musunuz?", "ENDGAME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    AnaEkran anaekran = new AnaEkran();
                    anaekran.Show();
                }
                if (secenek == DialogResult.No)
                {

                }

            }

        }

        private void degistir(PictureBox sender1, PictureBox sender2)
        {
            System.Threading.Thread.Sleep(100);
            Point loc1 = sender1.Location;
            Point loc2 = sender2.Location;
            // MessageBox.Show(loc1.X + "-" + loc1.Y + "ile" + loc2.X + "-" + loc2.Y + "yer değitirdi");

            sender2.Location = new Point(loc1.X, loc1.Y);
            sender1.Location = new Point(loc2.X, loc2.Y);
            sender1.BorderStyle = BorderStyle.None;
            sender2.BorderStyle = BorderStyle.None;

        }
        private void aynimi(PictureBox sender1, PictureBox sender2)
        {
            Bitmap original = (Bitmap)pictureBox33.Image;
            string img1_ref, img2_ref;


            Point loc1 = sender1.Location;
            Point loc2 = sender2.Location;
            Rectangle picRect = new Rectangle(loc2.X, loc2.Y, sender2.Width, sender2.Height);
            Bitmap cropped = original.Clone(picRect, original.PixelFormat);

            img1 = new Bitmap(sender1.Image);
            img2 = new Bitmap(cropped);


            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {// aynı olmayan pikselleri say

                            count2++;

                            ayni = false;
                            break;
                        }
                        count1++;
                    }

                }

                if (count2 > count1)
                {

                    count1 = 0;
                    count2 = 0;
                    ayni = true;
                    izin = false;
                }


                else
                {

                    count1 = 0;
                    count2 = 0;
                    ayni = true;
                    izin = true;

                }

            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YapBozYap(int x, int y)
        {
            button2.Enabled = false;
            Liste.Clear();
            panel1.Controls.Clear();
            Bitmap original = (Bitmap)pictureBox33.Image;
            int width = pictureBox33.Width / x;
            int height = pictureBox33.Height / y;


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Rectangle srcRect = new Rectangle(width * i, height * j, width, height);
                    Bitmap cropped = original.Clone(srcRect, original.PixelFormat);
                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(width, height);
                    pic.BorderStyle = BorderStyle.None;
                    pic.Image = cropped;

                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Location = new Point(width * i, height * j);
                    pic.Name = pic.Location.ToString();
                    this.panel1.Controls.Add(pic);
                    Liste.Add(pic.Location);
                    pic.Click += new System.EventHandler(this.pictureBox_Click);

                }
            }

            Random rnd = new Random();
            foreach (PictureBox p in panel1.Controls)
            {
                int xxx = rnd.Next(0, Liste.Count);
                p.Location = Liste[xxx];
                Liste.RemoveAt(xxx);
            }

            button2.Enabled = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            /// OKUMA İŞLEMİ
            richTextBox.Text = "";
            StreamReader sw = new StreamReader(Application.StartupPath + "\\enyuksekskor.txt");
            String satir;
            int say = 0;

            while ((satir = sw.ReadLine()) != null)
            {
                // listBox.Items.Add(satir);
                richTextBox.AppendText(satir + "\n");
                say++;

            }
            sw.Close();

            Regex regex = new Regex(@"([0-9]*[0-9]|[0-9]*[0-9])");
            MatchCollection eşleş = regex.Matches(richTextBox.Text);



            foreach (Match x in eşleş)
            {
                sirali.Add(Convert.ToInt32(x.Value));

            }
            int buyuk = sirali[0];

            foreach (int sayi in sirali)
            {
                if (sayi > buyuk)
                {
                    buyuk = sayi;
                }

            }

            listBox.Items.Add(buyuk.ToString());



        }
        private void karistir_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YapBozYap(4, 4);
            puan = 100;
            sayac = 0;

        }
    }
}