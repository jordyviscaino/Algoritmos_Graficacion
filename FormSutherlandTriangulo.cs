using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormSutherlandTriangulo : Form
    {
        private CSutherlandTriangulo _clipper = new CSutherlandTriangulo();
        private CRelleno _relleno = new CRelleno();

        private List<Point> _poligonoOriginal = new List<Point>();
        private List<Point> _poligonoActual = new List<Point>();
        private bool _dibujando = true;
        private bool _recortado = false;
        private bool _esperandoSemilla = false;

        public FormSutherlandTriangulo()
        {
            InitializeComponent();
            this.Text = "Variante 3: Recorte Convexo (Triángulo)";
            numPixelSize.Value = 20; numSpeed.Value = 20;

            // Ocultar controles de rectángulo que no usamos
            txtX.Visible = txtY.Visible = txtW.Visible = txtH.Visible = false;
            labelViewport.Text = "Ventana: Triángulo Fijo";

            this.Load += (s, e) => InicializarLienzo();
            pictureBox1.MouseClick += PictureBox1_MouseClick;
            btnCerrarPoligono.Click += (s, e) => CerrarPoligono();
            btnReiniciar.Click += (s, e) => Reset();
            btnRecortar.Click += async (s, e) => await Recortar();
            btnRellenar.Click += (s, e) => IniciarModoRelleno();
            btnColor.Click += (s, e) => { if (colorDialog1.ShowDialog() == DialogResult.OK) btnColor.BackColor = colorDialog1.Color; };
            btnSalir.Click += (s, e) => Close();
        }

        private void InicializarLienzo()
        {
            // Definir un triángulo grande fijo en el centro
            // Sentido Horario para que el Cross Product funcione
            _clipper.VentanaTriangular = new List<Point>
            {
                new Point(20, 5),  // Arriba Centro
                new Point(35, 25), // Abajo Derecha
                new Point(5, 25)   // Abajo Izquierda
            };
            DibujarEscena();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int ps = (int)numPixelSize.Value;
            int gx = e.X / ps; int gy = e.Y / ps;

            if (_dibujando)
            {
                _poligonoOriginal.Add(new Point(gx, gy));
                _poligonoActual = new List<Point>(_poligonoOriginal);
                DibujarEscena();
            }
            else if (_esperandoSemilla)
            {
                _esperandoSemilla = false; Cursor = Cursors.Default;
                EjecutarRelleno(gx, gy);
            }
        }

        private void CerrarPoligono()
        {
            if (_poligonoOriginal.Count < 3) return;
            _dibujando = false; btnCerrarPoligono.Enabled = false;
            lblEstado.Text = "Polígono cerrado.";
            DibujarEscena();
        }

        private void Reset()
        {
            _poligonoOriginal.Clear(); _poligonoActual.Clear();
            _dibujando = true; _recortado = false;
            btnCerrarPoligono.Enabled = true; btnRecortar.Enabled = true;
            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); pictureBox1.Image = null; }
            DibujarEscena();
        }

        private async Task Recortar()
        {
            if (_poligonoOriginal.Count < 3) return;
            _recortado = true; btnRecortar.Enabled = false;

            foreach (var est in _clipper.RecortarAnimado(_poligonoOriginal))
            {
                _poligonoActual = est.PoligonoActual;
                lblEstado.Text = est.Mensaje;
                DibujarEscena();
                if (numSpeed.Value > 0) await Task.Delay((int)numSpeed.Value);
            }
            lblEstado.Text = "Recorte finalizado.";
        }

        private void DibujarEscena()
        {
            if (pictureBox1.Image == null || pictureBox1.Image.Width != pictureBox1.Width || pictureBox1.Image.Height != pictureBox1.Height)
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            Bitmap bmp = (Bitmap)pictureBox1.Image;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (_dibujando || _recortado) g.Clear(Color.Black);
                if (chkGrid.Checked) DibujarGrid(g);

                // Dibujar Ventana Triangular
                DibujarPoligonoRasterizado(g, _clipper.VentanaTriangular, Color.Lime); // Verde para la ventana

                if (!_dibujando && _recortado)
                    DibujarPoligonoRasterizado(g, _poligonoOriginal, Color.DarkGray);

                Color c = _recortado ? Color.White : Color.Yellow;
                DibujarPoligonoRasterizado(g, _poligonoActual, c);
            }
            pictureBox1.Refresh();
        }

        // Reutilización de lógica de dibujado rasterizado
        private void DibujarPoligonoRasterizado(Graphics g, List<Point> pts, Color c)
        {
            if (pts.Count < 2) return;
            int ps = (int)numPixelSize.Value;
            using (Brush b = new SolidBrush(c))
            {
                foreach (var p in pts) g.FillRectangle(Brushes.Red, p.X * ps, p.Y * ps, ps, ps);
                for (int i = 0; i < pts.Count; i++)
                {
                    // Para la ventana triangular, siempre cerramos el polígono
                    // Para el dibujo del usuario, solo si no estamos dibujando
                    bool cerrar = (pts == _clipper.VentanaTriangular) || (!_dibujando || i < pts.Count - 1);
                    if (!cerrar) break;

                    Point p1 = pts[i];
                    Point p2 = pts[(i + 1) % pts.Count];

                    int x0 = p1.X, y0 = p1.Y, x1 = p2.X, y1 = p2.Y;
                    int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
                    int sx = x0 < x1 ? 1 : -1, sy = y0 < y1 ? 1 : -1;
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

        // --- RELLENO ---
        private void IniciarModoRelleno()
        {
            if (!_recortado) { MessageBox.Show("Primero recorte."); return; }
            if (rbScanline.Checked) EjecutarScanline();
            else { lblEstado.Text = "Click para rellenar..."; _esperandoSemilla = true; Cursor = Cursors.Cross; }
        }
        private async void EjecutarRelleno(int seedX, int seedY)
        {
            int ps = (int)numPixelSize.Value;
            int gw = pictureBox1.Width / ps; int gh = pictureBox1.Height / ps;
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            CRelleno.EsColorValido val = (x, y) =>
            {
                if (x < 0 || y < 0 || x >= gw || y >= gh) return false;
                Color c = bmp.GetPixel(x * ps + ps / 2, y * ps + ps / 2);
                return c.R == 0 && c.G == 0 && c.B == 0;
            };
            using (Graphics g = Graphics.FromImage(bmp)) using (Brush b = new SolidBrush(btnColor.BackColor))
            {
                foreach (var lote in _relleno.FloodFillAnimado(seedX, seedY, gw, gh, val, rbFlood8.Checked))
                {
                    foreach (Point p in lote) g.FillRectangle(b, p.X * ps, p.Y * ps, ps, ps);
                    pictureBox1.Refresh(); await Task.Delay((int)numSpeed.Value);
                }
            }
            lblEstado.Text = "Relleno completado.";
        }
        private async void EjecutarScanline()
        {
            int ps = (int)numPixelSize.Value;
            int gw = pictureBox1.Width / ps; int gh = pictureBox1.Height / ps;
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            using (Graphics g = Graphics.FromImage(bmp)) using (Brush b = new SolidBrush(btnColor.BackColor))
            {
                foreach (var linea in _relleno.ScanLineAnimado(_poligonoActual, gw, gh))
                {
                    foreach (Point p in linea) g.FillRectangle(b, p.X * ps, p.Y * ps, ps, ps);
                    pictureBox1.Refresh(); await Task.Delay((int)numSpeed.Value);
                }
            }
            lblEstado.Text = "Scanline completado.";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}