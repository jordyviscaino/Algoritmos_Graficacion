using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormBresenham : Form
    {
        private readonly CBresenham _bres = new CBresenham();

        public FormBresenham()
        {
            InitializeComponent();

            btnDraw.Click += BtnDraw_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        // El handler del botón únicamente llama a la función que realiza el trabajo.
        private void BtnDraw_Click(object? sender, EventArgs e) => DrawScaledLine();

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            if (pictureBox1.Image is Image old)
            {
                pictureBox1.Image = null;
                old.Dispose();
            }

            txtX1.Text = string.Empty;
            txtY0.Text = string.Empty;
            txtX0.Text = string.Empty;
            txtY1.Text = string.Empty;

            btnSalir.Visible = false;
        }

        private void BtnSalir_Click(object? sender, EventArgs e)
        {
            _bres.CloseForm(this);
        }

        // Parsea, escala matemáticamente y llama al algoritmo de Bresenham.
        private void DrawScaledLine()
        {
            bool okX1 = int.TryParse(txtX1.Text.Trim(), out int x1);
            bool okY1 = int.TryParse(txtY0.Text.Trim(), out int y1);
            bool okX2 = int.TryParse(txtX0.Text.Trim(), out int x2);
            bool okY2 = int.TryParse(txtY1.Text.Trim(), out int y2);

            if (!okX1 || !okY1 || !okX2 || !okY2)
            {
                MessageBox.Show("Introduce valores enteros válidos en X1, Y1, X2, Y2.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int w = Math.Max(1, pictureBox1.Width);
            int h = Math.Max(1, pictureBox1.Height);

            if (pictureBox1.Image is Image prev) { pictureBox1.Image = null; prev.Dispose(); }

            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(pictureBox1.BackColor);

                Point p0 = new Point(x1, y1);
                Point p1 = new Point(x2, y2);

                int minX = Math.Min(p0.X, p1.X);
                int maxX = Math.Max(p0.X, p1.X);
                int minY = Math.Min(p0.Y, p1.Y);
                int maxY = Math.Max(p0.Y, p1.Y);

                float rangeW = Math.Max(1, maxX - minX);
                float rangeH = Math.Max(1, maxY - minY);

                const float margin = 10f;
                float availW = Math.Max(1f, w - 2 * margin);
                float availH = Math.Max(1f, h - 2 * margin);

                float scaleX = availW / rangeW;
                float scaleY = availH / rangeH;
                float scale = Math.Min(scaleX, scaleY);

                float usedW = rangeW * scale;
                float usedH = rangeH * scale;
                float offsetX = margin + (availW - usedW) / 2f;
                float offsetY = margin + (availH - usedH) / 2f;

                Point tp0 = new Point(
                    (int)Math.Round((p0.X - minX) * scale + offsetX),
                    (int)Math.Round((p0.Y - minY) * scale + offsetY)
                );

                Point tp1 = new Point(
                    (int)Math.Round((p1.X - minX) * scale + offsetX),
                    (int)Math.Round((p1.Y - minY) * scale + offsetY)
                );

                _bres.DrawLineBresenham(g, tp0, tp1, Color.Black);
            }

            pictureBox1.Image = bmp;
        }
    }
}
