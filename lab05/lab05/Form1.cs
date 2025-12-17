using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (LinearGradientBrush brush =
        new LinearGradientBrush(
            new Rectangle(20, 20, 150, 100),
            Color.LightBlue,
            Color.DarkBlue,
            45))
            {
                g.FillEllipse(brush, 20, 20, 150, 100);
            }

            // ===== 2. НАБОР ЛИНИЙ + EndCap =====
            using (Pen pen = new Pen(Color.Red, 3))
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                g.DrawLine(pen, 200, 30, 350, 30);
                g.DrawLine(pen, 200, 60, 350, 80);
                g.DrawLine(pen, 200, 100, 350, 130);
            }

            // ===== 3. КРИВЫЕ БЕЗЬЕ =====
            using (Pen bezierPen = new Pen(Color.Green, 2))
            {
                Point p1 = new Point(20, 150);
                Point p2 = new Point(100, 200);
                Point p3 = new Point(150, 100);
                Point p4 = new Point(250, 180);

                g.DrawBezier(bezierPen, p1, p2, p3, p4);
            }

            // ===== 4. ТЕКСТ =====
            using (Font font = new Font("Arial", 14, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(Color.Purple))
            {
                g.DrawString("Графика Windows Forms", font, textBrush, 20, 250);
            }

            GraphicsPath path = new GraphicsPath();

            int x = figurePosition.X;
            int y = figurePosition.Y;

            // Стрелка (сложная фигура)
            path.AddLine(x, y, x + 60, y);
            path.AddLine(x + 60, y, x + 60, y - 20);
            path.AddLine(x + 100, y + 20, x + 60, y + 60);
            path.AddLine(x + 60, y + 60, x + 60, y + 40);
            path.AddLine(x, y + 40, x, y);
            path.CloseFigure();

            // Заливка
            g.FillPath(Brushes.Orange, path);
            g.DrawPath(Pens.Black, path);
        }
        Color textColor = Color.Purple;
        Font textFont = new Font("Arial", 14, FontStyle.Bold);

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textColor = dlg.Color;
                Invalidate(); // перерисовка
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textFont = dlg.Font;
                Invalidate();
            }
        }
        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void radioButtonStretch_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButtonZoom_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.jpg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                e.Graphics.DrawImage(pictureBox1.Image, 10, 10, 100, 100);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            figurePosition = e.Location;
            Invalidate(); // перерисовать форму
        }
        Point figurePosition = new Point(150, 150);

        Bitmap bmp;

        private void btnLoadPixels_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.bmp;*.jpg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(dlg.FileName);
                pictureBoxPixels.Image = bmp;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (bmp == null) return;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    Color inverted = Color.FromArgb(
                        255 - c.R,
                        255 - c.G,
                        255 - c.B
                    );

                    bmp.SetPixel(x, y, inverted);
                }
            }

            pictureBoxPixels.Invalidate();
        }
    }
}