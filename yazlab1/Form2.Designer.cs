namespace yazlab1
{
    partial class Form2
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
            this.dosyaEkle1 = new System.Windows.Forms.Button();
            this.karistir = new System.Windows.Forms.Button();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.SuspendLayout();
            // 
            // dosyaEkle1
            // 
            this.dosyaEkle1.Location = new System.Drawing.Point(20, 12);
            this.dosyaEkle1.Name = "dosyaEkle1";
            this.dosyaEkle1.Size = new System.Drawing.Size(120, 31);
            this.dosyaEkle1.TabIndex = 51;
            this.dosyaEkle1.Text = "dosya ekle";
            this.dosyaEkle1.UseVisualStyleBackColor = true;
            this.dosyaEkle1.Click += new System.EventHandler(this.dosyaEkle1_Click);
            // 
            // karistir
            // 
            this.karistir.Location = new System.Drawing.Point(2047, 314);
            this.karistir.Name = "karistir";
            this.karistir.Size = new System.Drawing.Size(103, 48);
            this.karistir.TabIndex = 86;
            this.karistir.Text = "KARIŞTIR";
            this.karistir.UseVisualStyleBackColor = true;
            this.karistir.Click += new System.EventHandler(this.karistir_Click_1);
            // 
            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(1097, 50);
            this.pictureBox33.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(800, 800);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox33.TabIndex = 87;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 1001);
            this.panel1.TabIndex = 88;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(913, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 89;
            this.button2.Text = "KARIŞTIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1552, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "EN YÜKSEK SKOR";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(1522, 154);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(216, 181);
            this.richTextBox.TabIndex = 96;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(1502, 398);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 84);
            this.listBox.TabIndex = 97;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.karistir);
            this.Controls.Add(this.dosyaEkle1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dosyaEkle1;
        private System.Windows.Forms.Button karistir;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ListBox listBox;
    }
}