using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        



        private void Form1_Load(object sender, EventArgs e)
        {
            //görüntüyü okuma 
            Bitmap bmp = new Bitmap("D:\\Lenna.png");


            pB_original.Image = Image.FromFile("D:\\Lenna.png");
            



        }
        void setgreyscale()
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            //x ve y ekseni alma
            int width = bmp.Width;
            int height = bmp.Height;

            //pixel rengi 
            Color p;

            //griye dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //ort bulma 
                    int ort = (r + g + b) / 3;

                    //yeni değerli girme
                    bmp.SetPixel(x, y, Color.FromArgb(a, ort, ort, ort));



                }
            }

            //pb_converte yükleme
            pB_convert.Image = bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            //x ve y ekseni alma
            int width = bmp.Width;
            int height = bmp.Height;

            //pixel rengi 
            Color p;

            //griye dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //ort bulma 
                    int ort = (r + g + b) / 3;

                    //yeni değerli girme
                    bmp.SetPixel(x, y, Color.FromArgb(a, ort, ort, ort));



                }
            }

            //pb_converte yükleme
            pB_convert.Image = bmp;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void rgb(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(("D:\\Lenna.png"));
            int width = bmp.Width;
            int height = bmp.Height;

            // yeşil mavi kırmızı bitmap
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //kırmızı yapma 
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                    //yeşil yapma
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    //mavi yapma
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                    pB_convert.Image = rbmp;



                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(("D:\\Lenna.png"));
            int width = bmp.Width;
            int height = bmp.Height;

            // yeşil mavi kırmızı bitmap
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //kırmızı yapma 
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                    //yeşil yapma
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    //mavi yapma
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                    pB_convert.Image = gbmp;

                }
            }
        }






        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(("D:\\Lenna.png"));
            int width = bmp.Width;
            int height = bmp.Height;

            // yeşil mavi kırmızı bitmap
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //kırmızı yapma 
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                    //yeşil yapma
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    //mavi yapma
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                    pB_convert.Image = bbmp;

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap nbmp = new Bitmap(("D:\\Lenna.png"));
            int width = nbmp.Width;
            int height = nbmp.Height;


            //renklere dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    Color p = nbmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                    //negatif değeri bulma
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;


                    nbmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));

                    
                }
            }

            pB_convert.Image = nbmp;
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            //x ve y ekseni alma
            int width = bmp.Width;
            int height = bmp.Height;

            //pixel rengi 
            Color p;

            //griye dönüştürme 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pixel değerlini alma
                    p = bmp.GetPixel(x, y);

                    //argbye gönüştürme 
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //ort bulma 
                    int ort = (r + g + b) / 3;

                    //yeni değerli girme
                    
                    bmp.SetPixel(x, y, Color.FromArgb(a = 0 , r, g, b));
                    
                    



                }
            }

            //pb_converte yükleme
            pB_convert.Image = bmp;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            int width = bmp.Width;
            int height = bmp.Height;

            

            Color c;
            int a,r, g, b;
            int anti_color;
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen bir değer giriniz","warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                anti_color = Convert.ToInt32(textBox1.Text);
                for(int i = 0; i<width;i++)
                {
                    for(int j =0;j<height; j++ )
                    {
                        c = bmp.GetPixel(i, j);
                        r = c.R + anti_color;
                        if (r > 255) r = 255;
                        g = c.G + anti_color;
                        if (r > 255) g = 255;
                        b = c.B + anti_color;
                        if (r > 255) b = 255;
                        bmp.SetPixel(i, j, Color.FromArgb(r, g, b)); 
                        
                       




                    }

                }
                pB_convert.Image = bmp;
            }
        }

        private void parlaklik_dusur_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("D:\\Lenna.png");
            Color c;
            int a,r, g, b;
            int anti_color;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir değer giriniz", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                anti_color = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height; j++)
                    {

                        c = bmp.GetPixel(i, j);
                        r = c.R + anti_color;
                        if (r > 255) r = 255;
                        g = c.G + anti_color;
                        if (g > 255) g = 255;
                        b = c.B + anti_color;
                        if (b > 255) b = 255;
                        a = c.A;
                        int ort = (r + g + b) / 3;

                        //yeni değerli girme
                        bmp.SetPixel(i, j, Color.FromArgb(a, ort, ort, ort));



                    }
                }
                
            }
        }
    }
    
}

       