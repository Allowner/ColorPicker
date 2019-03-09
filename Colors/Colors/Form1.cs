using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class Form1 : Form
    {
        public static Brush brush = new SolidBrush(Color.White);
        public static Rectangle rectangle = new Rectangle(150, 270, 150, 100);
        public static bool changed = false;
        public static bool rgbChanged = false;
        public static bool hsvChanged = false;
        public static bool labChanged = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog
            {
                AllowFullOpen = false
            };

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                brush = new SolidBrush(myDialog.Color);
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(brush, rectangle);
                RgbFromPalette(myDialog.Color);
            }
        }

        private void RgbFromPalette(Color color)
        {
            int red = color.R;
            int green = color.G;
            int blue = color.B;
            slRGB1.Value = red;
            slRGB2.Value = green;
            slRGB3.Value = blue;
        }

        private void RgbToHsv()
        {
            double red = slRGB1.Value;
            double green = slRGB2.Value;
            double blue = slRGB3.Value;
            double h = 0, s = 0, v = 0;
            double var_Min = Math.Min(Math.Min(red, green), blue);
            double var_Max = Math.Max(Math.Max(red, green), blue);
            double del_Max = var_Max - var_Min;

            v = var_Max;

            if (del_Max == 0)          
            {
                h = 0;                  
                s = 0;
            }
            else                      
            {
                s = del_Max / var_Max;

                if (red == var_Max)
                    h = (green - blue) / del_Max;
                else if (green == v)
                    h = 2 + (blue - red) / del_Max;
                else if (blue == v)
                    h = 4 + (red - green) / del_Max;

                h *= 60;

                if (h < 0.0)
                    h = h + 360;
            }
            
            slHSV1.Value = (int)Math.Round(h);
            slHSV2.Value = (int)Math.Round(s * 100);
            slHSV3.Value = (int)Math.Round(v / 2.55);

            tbHSV1.Text = slHSV1.Value.ToString();
            tbHSV2.Text = slHSV2.Value.ToString();
            tbHSV3.Text = slHSV3.Value.ToString();
        }

        private void HsvToRgb()
        {
            double h = Double.Parse(tbHSV1.Text) / 360;
            double s = Double.Parse(tbHSV2.Text) / 100;
            double v = Double.Parse(tbHSV3.Text) / 100;
            double r = 0, g = 0, b = 0;
            double f, p, q, t;
            int i = (int)(h * 6);
            f = h * 6 - i;
            p = v * (1 - s);
            q = v * (1 - f * s);
            t = v * (1 - (1 - f) * s);
            switch (i % 6)
            {
                case 0: r = v; g = t; b = p; break;
                case 1: r = q; g = v; b = p; break;
                case 2: r = p; g = v; b = t; break;
                case 3: r = p; g = q; b = v; break;
                case 4: r = t; g = p; b = v; break;
                case 5: r = v; g = p; b = q; break;
            }

            slRGB1.Value = (int)Math.Round(r * 255);
            slRGB2.Value = (int)Math.Round(g * 255);
            slRGB3.Value = (int)Math.Round(b * 255);

            tbRGB1.Text = slRGB1.Value.ToString();
            tbRGB2.Text = slRGB2.Value.ToString();
            tbRGB3.Text = slRGB3.Value.ToString();
        }

        private void RgbToLab()
        {
            double R = slRGB1.Value / 255.0;
            double G = slRGB2.Value / 255.0;
            double B = slRGB3.Value / 255.0;

            if (R > 0.04045)
                R = Math.Pow(((R + 0.055) / 1.055), 2.4);
            else
                R = R / 12.92;
            if (G > 0.04045)
                G = Math.Pow(((G + 0.055) / 1.055), 2.4);
            else
                G = G / 12.92;
            if (B > 0.04045)
                B = Math.Pow(((B + 0.055) / 1.055), 2.4);
            else
                B = B / 12.92;

            double X = R * 0.4124 + G * 0.3576 + B * 0.1805;
            double Y = R * 0.2126 + G * 0.7152 + B * 0.0722;
            double Z = R * 0.0193 + G * 0.1192 + B * 0.9505;

            double var_X = X / 0.95047;
            double var_Y = Y / 1.000;
            double var_Z = Z / 1.08883;

            if (var_X > 0.008856)
                var_X = Math.Pow(var_X, (1.0 / 3));
            else
                var_X = (7.787 * var_X) + (16.0 / 116);

            if (var_Y > 0.008856)
                var_Y = Math.Pow(var_Y, (1.0 / 3));
            else
                var_Y = (7.787 * var_Y) + (16.0 / 116);

            if (var_Z > 0.008856)
                var_Z = Math.Pow(var_Z, (1.0 / 3));
            else
                var_Z = (7.787 * var_Z) + (16.0 / 116);

            double L = (116 * var_Y) - 16;
            double a = 500 * (var_X - var_Y);
            double b = 200 * (var_Y - var_Z);
            
            slLAB1.Value = (int)Math.Round(L);
            slLAB2.Value = (int)Math.Round(a);
            slLAB3.Value = (int)Math.Round(b);
            
            tbLAB1.Text = slLAB1.Value.ToString();
            tbLAB2.Text = slLAB2.Value.ToString();
            tbLAB3.Text = slLAB3.Value.ToString();
        }

        private void LabToRgb()
        {
            double L = slLAB1.Value;
            double a = slLAB2.Value;
            double b = slLAB3.Value;

            double var_Y = (L + 16) / 116;
            double var_X = a / 500 + var_Y;
            double var_Z = var_Y - b / 200;

            if (Math.Pow(var_Y, 3) > 0.008856)
                var_Y = Math.Pow(var_Y, 3);
            else
                var_Y = (var_Y - 16.0 / 116) / 7.787;
            if (Math.Pow(var_X, 3) > 0.008856)
                var_X = Math.Pow(var_X, 3);
            else
                var_X = (var_X - 16.0 / 116) / 7.787;
            if (Math.Pow(var_Z, 3) > 0.008856)
                var_Z = Math.Pow(var_Z, 3);
            else
                var_Z = (var_Z - 16.0 / 116) / 7.787;

            double X = 0.95047 * var_X;    
            double Y = 1.00 * var_Y;   
            double Z = 1.08883 * var_Z;

            double R = X * 3.2406 + Y * -1.5372 + Z * -0.4986;
            double G = X * -0.9689 + Y * 1.8758 + Z * 0.0415;
            double B = X * 0.0557 + Y * -0.2040 + Z * 1.0570;

            if (R > 0.0031308)
                R = 1.055 * Math.Pow(R, (1 / 2.4)) - 0.055;
            else
                R = 12.92 * R;
            if (G > 0.0031308)
                G = 1.055 * Math.Pow(G, (1 / 2.4)) - 0.055;
            else
                G = 12.92 * G;
            if (B > 0.0031308)
                B = 1.055 * Math.Pow(B, (1 / 2.4)) - 0.055;
            else
                B = 12.92 * B;

            if (R < 0) R = 0;
            if (G < 0) G = 0;
            if (B < 0) B = 0;

            if (R > 1) R = 1;
            if (G > 1) G = 1;
            if (B > 1) B = 1;

            slRGB1.Value = (int)Math.Round(R * 255);
            slRGB2.Value = (int)Math.Round(G * 255);
            slRGB3.Value = (int)Math.Round(B * 255);

            tbRGB1.Text = slRGB1.Value.ToString();
            tbRGB2.Text = slRGB2.Value.ToString();
            tbRGB3.Text = slRGB3.Value.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            graphics.DrawRectangle(pen, rectangle);
            graphics.FillRectangle(brush, rectangle);  
        }

        private void tbRGB1_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slRGB1.Value = Int32.Parse(tbRGB1.Text);
                }
                catch (Exception) { slRGB1.Value = 0; tbRGB1.Text = "0"; }
            }
        }

        private void tbRGB2_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slRGB2.Value = Int32.Parse(tbRGB2.Text);
                }
                catch (Exception) { slRGB2.Value = 0; tbRGB2.Text = "0"; }
            }
        }

        private void tbRGB3_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slRGB3.Value = Int32.Parse(tbRGB3.Text);
                }
                catch (Exception) { slRGB3.Value = 0; tbRGB3.Text = "0"; }
            }
        }

        private void tbHSV1_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slHSV1.Value = Int32.Parse(tbHSV1.Text);
                }
                catch (Exception) { slHSV1.Value = 0; tbHSV1.Text = "0"; }
            }
        }

        private void tbHSV2_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slHSV2.Value = Int32.Parse(tbHSV2.Text);
                }
                catch (Exception) { slHSV2.Value = 0; tbHSV2.Text = "0"; }
            }
        }

        private void tbHSV3_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slHSV3.Value = Int32.Parse(tbHSV3.Text);
                }
                catch (Exception) { slHSV3.Value = 0; tbHSV3.Text = "0"; }
            }
        }

        private void tbLAB1_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slLAB1.Value = Int32.Parse(tbLAB1.Text);
                }
                catch (Exception) { slLAB1.Value = 0; tbLAB1.Text = "0"; }
            }
        }

        private void tbLAB2_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slLAB2.Value = Int32.Parse(tbLAB2.Text);
                }
                catch (Exception) { slLAB2.Value = 0; tbLAB2.Text = "0"; }
            }
        }

        private void tbLAB3_TextChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                try
                {
                    slLAB3.Value = Int32.Parse(tbLAB3.Text);
                }
                catch (Exception) { slLAB3.Value = 0; tbLAB3.Text = "0"; }
            }
        }

        private void RgbChanged(object sender, EventArgs e)
        {
            if (changed == false)
            {
                changed = true;
                tbRGB1.Text = slRGB1.Value.ToString();
                tbRGB2.Text = slRGB2.Value.ToString();
                tbRGB3.Text = slRGB3.Value.ToString();

                RgbToHsv();
                RgbToLab();
                Color color = Color.FromArgb(slRGB1.Value, slRGB2.Value, slRGB3.Value);
                brush = new SolidBrush(color);
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(brush, rectangle);
                changed = false;
            }
        }

        private void HsvChanged(object sender, EventArgs e)
        {
            if (changed == false)
            {
                changed = true;
                tbHSV1.Text = slHSV1.Value.ToString();
                tbHSV2.Text = slHSV2.Value.ToString();
                tbHSV3.Text = slHSV3.Value.ToString();

                HsvToRgb();
                RgbToLab();
                Color color = Color.FromArgb(slRGB1.Value, slRGB2.Value, slRGB3.Value);
                brush = new SolidBrush(color);
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(brush, rectangle);
                changed = false;
            }
        }

        private void LabChanged(object sender, EventArgs e)
        {
            if (changed == false)
            {
                changed = true;

                tbLAB1.Text = slLAB1.Value.ToString();
                tbLAB2.Text = slLAB2.Value.ToString();
                tbLAB3.Text = slLAB3.Value.ToString();

                LabToRgb();
                RgbToHsv();
                Color color = Color.FromArgb(slRGB1.Value, slRGB2.Value, slRGB3.Value);
                brush = new SolidBrush(color);
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.FillRectangle(brush, rectangle);
                changed = false;
            }
        }
    }
}
