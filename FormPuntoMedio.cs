using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormPuntoMedio : Form
    {
        private readonly CCirculoPuntoMedio _algoritmo = new CCirculoPuntoMedio();

        public FormPuntoMedio()
        {
            InitializeComponent();
            this.Text = "Círculo Punto Medio (Midpoint)";
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
            if (!int.TryParse(txtXC.Text, out int xc) || !int.TryParse(txtYC.Text, out int yc) || !int.TryParse(txtRadio.Text, out int r))
            {
                MessageBox.Show("Ingrese valores enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (r <= 0) { MessageBox.Show("Radio > 0", "Error", MessageBoxButtons.OK); return; }

            // Configuración visual
            int pixelSize = (int)numPixelSize.Value;
            int delay = (int)numSpeed.Value;
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            int gridW = w / pixelSize;
            int gridH = h / pixelSize;

            Bitmap bmp = new Bitmap(w, h);
            pictureBox1.Image = bmp;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                if (chkGrid.Checked) DibujarGrid(g, w, h, pixelSize);

                // Mostrar líneas de octantes si se selecciona
                if (chkOctantes.Checked) DibujarOctantes(g, xc, yc, w, h, pixelSize);

                pictureBox1.Refresh();

                // --- ALGORITMO PUNTO MEDIO ---
                using (Brush brush = new SolidBrush(Color.Magenta)) // Color distinto para diferenciar
                {
                    foreach (Point[] puntosSimetricos in _algoritmo.Calcular(xc, yc, r))
                    {
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

        private void DibujarOctantes(Graphics g, int xc, int yc, int w, int h, int pixelSize)
        {
            using (Pen p = new Pen(Color.FromArgb(60, 60, 60)) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot })
            {
                int cx = xc * pixelSize + pixelSize / 2;
                int cy = yc * pixelSize + pixelSize / 2;
                g.DrawLine(p, cx, 0, cx, h);
                g.DrawLine(p, 0, cy, w, cy);
                // Diagonales simples
                g.DrawLine(p, cx - 1000, cy - 1000, cx + 1000, cy + 1000);
                g.DrawLine(p, cx - 1000, cy + 1000, cx + 1000, cy - 1000);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}