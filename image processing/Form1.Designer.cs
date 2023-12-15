
namespace image_processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pB_original = new System.Windows.Forms.PictureBox();
            this.pB_convert = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.parlaklik_arttir = new System.Windows.Forms.Button();
            this.parlaklik_dusur = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_convert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_original
            // 
            this.pB_original.Location = new System.Drawing.Point(51, 29);
            this.pB_original.Name = "pB_original";
            this.pB_original.Size = new System.Drawing.Size(494, 514);
            this.pB_original.TabIndex = 0;
            this.pB_original.TabStop = false;
            // 
            // pB_convert
            // 
            this.pB_convert.Location = new System.Drawing.Point(645, 29);
            this.pB_convert.Name = "pB_convert";
            this.pB_convert.Size = new System.Drawing.Size(435, 514);
            this.pB_convert.TabIndex = 1;
            this.pB_convert.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "gri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "kırmızı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 632);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "yeşil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 667);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "mavi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 562);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "negatif";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(629, 622);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // parlaklik_arttir
            // 
            this.parlaklik_arttir.Location = new System.Drawing.Point(171, 598);
            this.parlaklik_arttir.Name = "parlaklik_arttir";
            this.parlaklik_arttir.Size = new System.Drawing.Size(94, 29);
            this.parlaklik_arttir.TabIndex = 8;
            this.parlaklik_arttir.Text = "Parlaklik+";
            this.parlaklik_arttir.UseVisualStyleBackColor = true;
            this.parlaklik_arttir.Click += new System.EventHandler(this.button7_Click);
            // 
            // parlaklik_dusur
            // 
            this.parlaklik_dusur.Location = new System.Drawing.Point(171, 631);
            this.parlaklik_dusur.Name = "parlaklik_dusur";
            this.parlaklik_dusur.Size = new System.Drawing.Size(94, 29);
            this.parlaklik_dusur.TabIndex = 9;
            this.parlaklik_dusur.Text = "parlaklik-";
            this.parlaklik_dusur.UseVisualStyleBackColor = true;
            this.parlaklik_dusur.Click += new System.EventHandler(this.parlaklik_dusur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 562);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 705);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.parlaklik_dusur);
            this.Controls.Add(this.parlaklik_arttir);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pB_convert);
            this.Controls.Add(this.pB_original);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_convert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_original;
        private System.Windows.Forms.PictureBox pB_convert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button parlaklik_arttir;
        private System.Windows.Forms.Button parlaklik_dusur;
        private System.Windows.Forms.TextBox textBox1;
    }
}

