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

namespace yazlab1
{
    public partial class AnaEkran : Form
    {

        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            lbl1.Text = Form2.puan.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosya_yolu = @"C:\Users\emre9\Desktop\YAZLAB2- PROJELER\yazlab1\yazlab1\bin\Debug\enyuksekskor.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(lbl1.Text + "-" + textBox1.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
            this.Hide();

        }
    }

}

