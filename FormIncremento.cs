using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormIncremento : Form
    {
        public FormIncremento()
        {
            InitializeComponent();
            btnDraw.Click += BtnDraw_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private async void BtnDraw_Click(object sender, EventArgs e)
        {
            btnDraw.Enabled = false;
            await EjecutarDibujoAnimado();
            btnDraw.Enabled = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            txtX1.Clear(); txtY0.Clear(); txtX0.Clear(); txtY1.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task EjecutarDibujoAnimado()
        {
            if (!int.TryParse(txtX1.Text, out int x1) || !int.TryParse(txtY0.Text, out int y1) ||
                !int.TryParse(txtX0.Text, out int x2) || !int.TryParse(txtY1.Text, out int y2))
            {
                MessageBox.Show("Por favor ingrese coordenadas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pixelSize = (int)numPixelSize.Value;
            int delay = (int)numSpeed.Value;
            bool showGrid = chkGrid.Checked;

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            int gridW = w / pixelSize;
            int gridH = h / pixelSize;

            Bitmap bmp = new Bitmap(w, h);
            pictureBox1.Image = bmp;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);

                // --- DIBUJAR GRID ---
                if (showGrid)
                {
                    using (Pen gridPen = new Pen(Color.FromArgb(40, 40, 40)))
                    {
                        for (int i = 0; i <= w; i += pixelSize) g.DrawLine(gridPen, i, 0, i, h);
                        for (int j = 0; j <= h; j += pixelSize) g.DrawLine(gridPen, 0, j, w, j);
                    }
                }
                pictureBox1.Refresh();

                // --- ALGORITMO INCREMENTAL (y = mx + b) ---
                using (Brush brush = new SolidBrush(Color.DarkViolet))
                {
                    // Caso Vertical
                    if (x1 == x2)
                    {
                        int start = Math.Min(y1, y2);
                        int end = Math.Max(y1, y2);
                        for (int y = start; y <= end; y++)
                        {
                            if (x1 >= 0 && x1 < gridW && y >= 0 && y < gridH)
                            {
                                g.FillRectangle(brush, x1 * pixelSize + 1, y * pixelSize + 1, pixelSize - 1, pixelSize - 1);
                                pictureBox1.Invalidate();
                                pictureBox1.Update();
                            }
                            if (delay > 0) await Task.Delay(delay);
                        }
                    }
                    else
                    {
                        float m = (float)(y2 - y1) / (x2 - x1);
                        float b = y1 - (m * x1);

                        int xStart = Math.Min(x1, x2);
                        int xEnd = Math.Max(x1, x2);

                        for (int x = xStart; x <= xEnd; x++)
                        {
                            float yFloat = (m * x) + b;
                            int y = (int)Math.Round(yFloat);

                            if (x >= 0 && x < gridW && y >= 0 && y < gridH)
                            {
                                g.FillRectangle(brush, x * pixelSize + 1, y * pixelSize + 1, pixelSize - 1, pixelSize - 1);
                                pictureBox1.Invalidate();
                                pictureBox1.Update();
                            }
                            if (delay > 0) await Task.Delay(delay);
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}