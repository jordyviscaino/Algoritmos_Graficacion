using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormDDA : Form
    {
        public FormDDA()
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

                // --- ALGORITMO DDA ---
                using (Brush brush = new SolidBrush(Color.Blue))
                {
                    int dx = x2 - x1;
                    int dy = y2 - y1;

                    int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

                    float xInc = (float)dx / steps;
                    float yInc = (float)dy / steps;

                    float x = x1;
                    float y = y1;

                    // Dibujar primer punto
                    if (Math.Round(x) >= 0 && Math.Round(x) < gridW && Math.Round(y) >= 0 && Math.Round(y) < gridH)
                    {
                        g.FillRectangle(brush, (int)Math.Round(x) * pixelSize + 1, (int)Math.Round(y) * pixelSize + 1, pixelSize - 1, pixelSize - 1);
                        pictureBox1.Invalidate();
                        pictureBox1.Update();
                    }
                    if (delay > 0) await Task.Delay(delay);

                    for (int k = 0; k < steps; k++)
                    {
                        x += xInc;
                        y += yInc;

                        int xRound = (int)Math.Round(x);
                        int yRound = (int)Math.Round(y);

                        if (xRound >= 0 && xRound < gridW && yRound >= 0 && yRound < gridH)
                        {
                            g.FillRectangle(brush, xRound * pixelSize + 1, yRound * pixelSize + 1, pixelSize - 1, pixelSize - 1);
                            pictureBox1.Invalidate();
                            pictureBox1.Update();
                        }

                        if (delay > 0) await Task.Delay(delay);
                    }
                }
            }
        }
    }
}