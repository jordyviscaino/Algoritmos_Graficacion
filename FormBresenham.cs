using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormBresenham : Form
    {
        public FormBresenham()
        {
            InitializeComponent();
            btnDraw.Click += BtnDraw_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private async void BtnDraw_Click(object sender, EventArgs e)
        {
            // Bloquear botón para evitar múltiples clics durante animación
            btnDraw.Enabled = false;
            await EjecutarDibujoAnimado();
            btnDraw.Enabled = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            // Limpiar textboxes
            txtX1.Clear(); txtY0.Clear(); txtX0.Clear(); txtY1.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task EjecutarDibujoAnimado()
        {
            // 1. Validar entradas
            if (!int.TryParse(txtX1.Text, out int x1) || !int.TryParse(txtY0.Text, out int y1) ||
                !int.TryParse(txtX0.Text, out int x2) || !int.TryParse(txtY1.Text, out int y2))
            {
                MessageBox.Show("Por favor ingrese coordenadas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Configuración Visual
            int pixelSize = (int)numPixelSize.Value; // Tamaño visual del píxel
            int delay = (int)numSpeed.Value;         // Retraso en ms
            bool showGrid = chkGrid.Checked;

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            // Calcular cuántos "píxeles lógicos" caben en la pantalla
            int gridW = w / pixelSize;
            int gridH = h / pixelSize;

            Bitmap bmp = new Bitmap(w, h);
            pictureBox1.Image = bmp;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);

                // --- DIBUJAR CUADRÍCULA ---
                if (showGrid)
                {
                    using (Pen gridPen = new Pen(Color.FromArgb(40, 40, 40)))
                    {
                        // Líneas Verticales
                        for (int i = 0; i <= w; i += pixelSize)
                            g.DrawLine(gridPen, i, 0, i, h);
                        // Líneas Horizontales
                        for (int j = 0; j <= h; j += pixelSize)
                            g.DrawLine(gridPen, 0, j, w, j);
                    }
                }

                // Refrescar para mostrar el grid base
                pictureBox1.Refresh();

                // --- ALGORITMO BRESENHAM (Lógica + Animación) ---

                // Mapear coordenadas lógicas (grid)
                // Nota: Si el usuario pone coordenadas mayores al grid, las ajustamos o dibujamos fuera
                // Aquí asumimos que el usuario ingresa coordenadas lógicas (ej: 0,0 a 20,15)

                int x0 = x1;
                int y0 = y1;
                int xEnd = x2;
                int yEnd = y2;

                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int sx = (x0 < xEnd) ? 1 : -1;
                int sy = (y0 < yEnd) ? 1 : -1;
                int err = dx - dy;

                using (Brush brush = new SolidBrush(Color.Cyan))
                {
                    while (true)
                    {
                        // DIBUJAR PÍXEL VISUAL (Rectángulo relleno)
                        // Validar límites visuales
                        if (x0 >= 0 && x0 < gridW && y0 >= 0 && y0 < gridH)
                        {
                            g.FillRectangle(brush, x0 * pixelSize + 1, y0 * pixelSize + 1, pixelSize - 1, pixelSize - 1);

                            // Forzar repintado del PictureBox para ver la animación
                            pictureBox1.Invalidate();
                            pictureBox1.Update(); // Update inmediato
                        }

                        if (x0 == xEnd && y0 == yEnd) break;

                        int e2 = 2 * err;
                        if (e2 > -dy)
                        {
                            err -= dy;
                            x0 += sx;
                        }
                        if (e2 < dx)
                        {
                            err += dx;
                            y0 += sy;
                        }

                        // RETRASO PARA ANIMACIÓN
                        if (delay > 0) await Task.Delay(delay);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click_1(object sender, EventArgs e)
        {

        }
    }
}