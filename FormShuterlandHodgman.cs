using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormSutherlandHodgman : Form
    {
        private CSutherlandHodgman _clipper = new CSutherlandHodgman();
        private CRelleno _relleno = new CRelleno();

        // Estado
        private List<Point> _poligonoOriginal = new List<Point>();
        private List<Point> _poligonoActual = new List<Point>();
        private bool _dibujando = true;
        private bool _recortado = false;
        private bool _esperandoSemilla = false;

        public FormSutherlandHodgman()
        {
            InitializeComponent();

            // Configuración inicial de UI para que sea visible
            numPixelSize.Value = 20;
            numSpeed.Value = 20;

            // CORRECCIÓN: Ajustar valores por defecto del Viewport para que sean visibles en el Grid
            // Si el grid es de 20px, una pantalla de 800px tiene 40 celdas de ancho.
            // Ponemos la ventana en coordenadas lógicas visibles (ej. 5, 2).
            txtX.Text = "5";
            txtY.Text = "2";
            txtW.Text = "25";
            txtH.Text = "15";

            this.Load += (s, e) => InicializarLienzo();

            pictureBox1.MouseClick += PictureBox1_MouseClick;
            btnCerrarPoligono.Click += (s, e) => CerrarPoligono();
            btnReiniciar.Click += (s, e) => Reset();
            btnRecortar.Click += async (s, e) => await Recortar();
            btnRellenar.Click += (s, e) => IniciarModoRelleno();
            btnColor.Click += (s, e) => { if (colorDialog1.ShowDialog() == DialogResult.OK) btnColor.BackColor = colorDialog1.Color; };
            btnSalir.Click += (s, e) => Close();
        }

        private void InicializarLienzo() { DibujarEscena(); }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int ps = (int)numPixelSize.Value;
            int gx = e.X / ps;
            int gy = e.Y / ps;

            if (_dibujando)
            {
                _poligonoOriginal.Add(new Point(gx, gy));
                _poligonoActual = new List<Point>(_poligonoOriginal);
                DibujarEscena();
            }
            else if (_esperandoSemilla)
            {
                _esperandoSemilla = false;
                Cursor = Cursors.Default;
                EjecutarRelleno(gx, gy);
            }
        }

        private void CerrarPoligono()
        {
            if (_poligonoOriginal.Count < 3) return;
            _dibujando = false;
            _recortado = false;
            btnCerrarPoligono.Enabled = false;
            lblEstado.Text = "Polígono cerrado. Configure ventana y recorte.";
            DibujarEscena();
        }

        private void Reset()
        {
            _poligonoOriginal.Clear();
            _poligonoActual.Clear();
            _dibujando = true;
            _recortado = false;
            btnCerrarPoligono.Enabled = true;
            btnRecortar.Enabled = true;

            // Aquí sí queremos destruir la imagen anterior para empezar de cero (limpiar rellenos)
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            DibujarEscena();
        }

        private void DibujarEscena()
        {
            // Gestión segura del Bitmap
            if (pictureBox1.Image == null || pictureBox1.Image.Width != pictureBox1.Width || pictureBox1.Image.Height != pictureBox1.Height)
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            Bitmap bmp = (Bitmap)pictureBox1.Image;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Limpiar fondo si estamos en fase vectorial
                if (_dibujando || _recortado) g.Clear(Color.Black);

                if (chkGrid.Checked) DibujarGrid(g);

                Rectangle view = ObtenerViewport();
                Rectangle viewScaled = ScaleRect(view);

                // --- CORRECCIÓN VISUAL: Sombreado de zona "Fuera de Límites" ---
                // Esto ayuda a ver claramente dónde se va a recortar.
                // Usamos Region para excluir el centro y pintar el resto semitransparente.
                using (Region regionOutside = new Region(new Rectangle(0, 0, bmp.Width, bmp.Height)))
                {
                    regionOutside.Exclude(viewScaled);
                    using (SolidBrush brushDim = new SolidBrush(Color.FromArgb(100, 50, 0, 0))) // Rojo oscuro semitransparente
                    {
                        g.FillRegion(brushDim, regionOutside);
                    }
                }

                // Dibujar borde del Viewport
                using (Pen p = new Pen(Color.Lime, 2)) g.DrawRectangle(p, viewScaled);

                // Dibujar etiqueta
                g.DrawString($"Viewport ({view.X},{view.Y})", this.Font, Brushes.Lime, viewScaled.X + 5, viewScaled.Y + 5);

                if (!_dibujando && _recortado)
                    DibujarPoligonoRasterizado(g, _poligonoOriginal, Color.DarkGray);

                Color c = _recortado ? Color.White : Color.Yellow;
                DibujarPoligonoRasterizado(g, _poligonoActual, c);
            }

            pictureBox1.Refresh();
        }

        // DIBUJA BLOQUES SÓLIDOS USANDO BRESENHAM LOCAL
        private void DibujarPoligonoRasterizado(Graphics g, List<Point> pts, Color c)
        {
            if (pts.Count < 2) return;
            int ps = (int)numPixelSize.Value;

            using (Brush b = new SolidBrush(c))
            {
                // Vértices
                foreach (var p in pts) g.FillRectangle(Brushes.Red, p.X * ps, p.Y * ps, ps, ps);

                // Aristas
                for (int i = 0; i < pts.Count; i++)
                {
                    if (_dibujando && i == pts.Count - 1) break;

                    Point p1 = pts[i];
                    Point p2 = pts[(i + 1) % pts.Count];

                    // Bresenham Local
                    int x0 = p1.X, y0 = p1.Y;
                    int x1 = p2.X, y1 = p2.Y;
                    int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
                    int sx = x0 < x1 ? 1 : -1;
                    int sy = y0 < y1 ? 1 : -1;
                    int err = dx - dy;

                    while (true)
                    {
                        g.FillRectangle(b, x0 * ps, y0 * ps, ps, ps);
                        if (x0 == x1 && y0 == y1) break;
                        int e2 = 2 * err;
                        if (e2 > -dy) { err -= dy; x0 += sx; }
                        if (e2 < dx) { err += dx; y0 += sy; }
                    }
                }
            }
        }

        private async Task Recortar()
        {
            if (_poligonoOriginal.Count < 3) return;
            _recortado = true;
            btnRecortar.Enabled = false;

            Rectangle view = ObtenerViewport();
            foreach (var est in _clipper.RecortarAnimado(_poligonoOriginal, view))
            {
                _poligonoActual = est.PoligonoActual;
                lblEstado.Text = est.Mensaje;
                DibujarEscena();
                if (numSpeed.Value > 0) await Task.Delay((int)numSpeed.Value);
            }
            lblEstado.Text = "Recorte finalizado.";
        }

        private void IniciarModoRelleno()
        {
            if (!_recortado) { MessageBox.Show("Primero recorte."); return; }

            if (rbScanline.Checked) EjecutarScanline();
            else
            {
                lblEstado.Text = "Click dentro para rellenar...";
                _esperandoSemilla = true;
                Cursor = Cursors.Cross;
            }
        }

        private async void EjecutarRelleno(int seedX, int seedY)
        {
            int ps = (int)numPixelSize.Value;
            int gw = pictureBox1.Width / ps;
            int gh = pictureBox1.Height / ps;
            Bitmap bmp = (Bitmap)pictureBox1.Image;

            // Validador: Mira el centro del bloque
            CRelleno.EsColorValido val = (x, y) =>
            {
                if (x < 0 || y < 0 || x >= gw || y >= gh) return false;
                Color c = bmp.GetPixel(x * ps + ps / 2, y * ps + ps / 2);
                return c.R == 0 && c.G == 0 && c.B == 0; // Solo fondo negro es válido
            };

            using (Graphics g = Graphics.FromImage(bmp))
            using (Brush b = new SolidBrush(btnColor.BackColor))
            {
                foreach (var lote in _relleno.FloodFillAnimado(seedX, seedY, gw, gh, val, rbFlood8.Checked))
                {
                    foreach (Point p in lote) g.FillRectangle(b, p.X * ps, p.Y * ps, ps, ps);
                    pictureBox1.Refresh();
                    await Task.Delay((int)numSpeed.Value);
                }
            }
            lblEstado.Text = "Relleno completado.";
        }

        private async void EjecutarScanline()
        {
            int ps = (int)numPixelSize.Value;
            int gw = pictureBox1.Width / ps;
            int gh = pictureBox1.Height / ps;
            Bitmap bmp = (Bitmap)pictureBox1.Image;

            using (Graphics g = Graphics.FromImage(bmp))
            using (Brush b = new SolidBrush(btnColor.BackColor))
            {
                foreach (var linea in _relleno.ScanLineAnimado(_poligonoActual, gw, gh))
                {
                    foreach (Point p in linea) g.FillRectangle(b, p.X * ps, p.Y * ps, ps, ps);
                    pictureBox1.Refresh();
                    await Task.Delay((int)numSpeed.Value);
                }
            }
            lblEstado.Text = "Scanline completado.";
        }

        private Rectangle ObtenerViewport()
        {
            int.TryParse(txtX.Text, out int x); int.TryParse(txtY.Text, out int y);
            int.TryParse(txtW.Text, out int w); int.TryParse(txtH.Text, out int h);
            return new Rectangle(x, y, w, h);
        }

        private Rectangle ScaleRect(Rectangle r)
        {
            int ps = (int)numPixelSize.Value;
            return new Rectangle(r.X * ps, r.Y * ps, r.Width * ps, r.Height * ps);
        }

        private void DibujarGrid(Graphics g)
        {
            int ps = (int)numPixelSize.Value;
            using (Pen pen = new Pen(Color.FromArgb(30, 30, 30)))
            {
                for (int x = 0; x < pictureBox1.Width; x += ps) g.DrawLine(pen, x, 0, x, pictureBox1.Height);
                for (int y = 0; y < pictureBox1.Height; y += ps) g.DrawLine(pen, 0, y, pictureBox1.Width, y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}