using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormBresenhamCirculos : Form
    {
        private readonly CCirculoBresenham _algoritmo = new CCirculoBresenham();

        public FormBresenhamCirculos()
        {
            InitializeComponent();
            btnDraw.Click += BtnDraw_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private async void BtnDraw_Click(object sender, EventArgs e)
        {
            btnDraw.Enabled = false;
            await EjecutarAnimacion();
            btnDraw.Enabled = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            txtXC.Clear(); txtYC.Clear(); txtRadio.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e) { this.Close(); }

        private async Task EjecutarAnimacion()
        {
            // 1. Validaciones
            if (!int.TryParse(txtXC.Text, out int xc) || !int.TryParse(txtYC.Text, out int yc) || !int.TryParse(txtRadio.Text, out int r))
            {
                MessageBox.Show("Ingrese valores enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (r <= 0)
            {
                MessageBox.Show("El radio debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Configuración Visual
            int pixelSize = (int)numPixelSize.Value;
            int delay = (int)numSpeed.Value;
            bool showGrid = chkGrid.Checked;
            bool showOctants = chkOctantes.Checked;

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
                if (showGrid) DibujarGrid(g, w, h, pixelSize);

                // --- DIBUJAR LÍNEAS DE OCTANTES (Visualización de Simetría) ---
                if (showOctants)
                {
                    using (Pen p = new Pen(Color.FromArgb(50, 50, 50)) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                    {
                        // Ejes X e Y
                        int centerX = xc * pixelSize + pixelSize / 2;
                        int centerY = yc * pixelSize + pixelSize / 2;

                        g.DrawLine(p, centerX, 0, centerX, h); // Vertical
                        g.DrawLine(p, 0, centerY, w, centerY); // Horizontal

                        // Diagonales (Aproximadas visualmente para el centro)
                        // y = x  && y = -x
                        int maxR = Math.Max(w, h);
                        g.DrawLine(p, centerX - maxR, centerY - maxR, centerX + maxR, centerY + maxR);
                        g.DrawLine(p, centerX - maxR, centerY + maxR, centerX + maxR, centerY - maxR);
                    }
                }

                pictureBox1.Refresh();

                // --- ALGORITMO BRESENHAM ---
                using (Brush brush = new SolidBrush(Color.Cyan))
                {
                    // Consumir el iterador de la clase lógica
                    foreach (Point[] puntosSimetricos in _algoritmo.Calcular(xc, yc, r))
                    {
                        // Dibujar los 8 puntos generados en este paso
                        foreach (Point p in puntosSimetricos)
                        {
                            if (p.X >= 0 && p.X < gridW && p.Y >= 0 && p.Y < gridH)
                            {
                                g.FillRectangle(brush, p.X * pixelSize + 1, p.Y * pixelSize + 1, pixelSize - 1, pixelSize - 1);
                            }
                        }

                        pictureBox1.Invalidate();
                        pictureBox1.Update();

                        if (delay > 0) await Task.Delay(delay);
                    }
                }
            }
        }

        private void DibujarGrid(Graphics g, int w, int h, int pixelSize)
        {
            using (Pen gridPen = new Pen(Color.FromArgb(30, 30, 30)))
            {
                for (int i = 0; i <= w; i += pixelSize) g.DrawLine(gridPen, i, 0, i, h);
                for (int j = 0; j <= h; j += pixelSize) g.DrawLine(gridPen, 0, j, w, j);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}