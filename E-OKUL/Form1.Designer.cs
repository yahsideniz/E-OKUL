
namespace E_OKUL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureOgrenci = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureOgretmen = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PicClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureOgrenci
            // 
            this.PictureOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("PictureOgrenci.Image")));
            this.PictureOgrenci.Location = new System.Drawing.Point(135, 79);
            this.PictureOgrenci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureOgrenci.Name = "PictureOgrenci";
            this.PictureOgrenci.Size = new System.Drawing.Size(170, 77);
            this.PictureOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureOgrenci.TabIndex = 0;
            this.PictureOgrenci.TabStop = false;
            this.PictureOgrenci.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(184, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(460, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen";
            // 
            // PictureOgretmen
            // 
            this.PictureOgretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("PictureOgretmen.Image")));
            this.PictureOgretmen.Location = new System.Drawing.Point(419, 79);
            this.PictureOgretmen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureOgretmen.Name = "PictureOgretmen";
            this.PictureOgretmen.Size = new System.Drawing.Size(170, 77);
            this.PictureOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureOgretmen.TabIndex = 4;
            this.PictureOgretmen.TabStop = false;
            this.PictureOgretmen.Click += new System.EventHandler(this.PictureOgretmen_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Location = new System.Drawing.Point(236, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğrenci Numarası:";
            // 
            // PicClose
            // 
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = ((System.Drawing.Image)(resources.GetObject("PicClose.Image")));
            this.PicClose.Location = new System.Drawing.Point(653, 12);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(55, 50);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 16;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(730, 351);
            this.Controls.Add(this.PicClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PictureOgretmen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureOgrenci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureOgretmen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicClose;
    }
}

