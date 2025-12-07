using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormCohenSutherland : Form
    {
        private CCohenSutherland _algoritmoRecorte = new CCohenSutherland();
        private CBresenham _dibujanteLinea = new CBresenham();

        public FormCohenSutherland()
        {
            InitializeComponent();

            // Eventos
            btnRecortar.Click += BtnRecortar_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;

            // Dibujar el estado inicial apenas carga el formulario
            this.Load += (s, e) => InicializarLienzo();
        }

        // Método para dibujar el grid inicial sin necesidad de animar
        private void InicializarLienzo()
        {
            if (pictureBox1.Width == 0 || pictureBox1.Height == 0) return;

            // Valores por defecto seguros o los que tenga el textbox
            int xmin = int.TryParse(txtXMin.Text, out int x) ? x : 150;
            int ymin = int.TryParse(txtYMin.Text, out int y) ? y : 100;
            int wR = int.TryParse(txtW.Text, out int w) ? w : 200;
            int hR = int.TryParse(txtH.Text, out int h) ? h : 150;

            Rectangle rectVentana = new Rectangle(xmin, ymin, wR, hR);

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                DibujarEntorno(g, rectVentana, pictureBox1.Width, pictureBox1.Height);
            }

            // Liberar imagen anterior si existe para evitar fugas de memoria
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = bmp;
        }

        private async void BtnRecortar_Click(object sender, EventArgs e)
        {
            btnRecortar.Enabled = false;
            await EjecutarRecorte();
            btnRecortar.Enabled = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "...";
            txtX1.Clear(); txtY1.Clear(); txtX2.Clear(); txtY2.Clear();
            // Restaurar el lienzo limpio con el grid
            InicializarLienzo();
        }

        private void BtnSalir_Click(object sender, EventArgs e) => Close();

        private async Task EjecutarRecorte()
        {
            // Validaciones
            if (!int.TryParse(txtX1.Text, out int x1) || !int.TryParse(txtY1.Text, out int y1) ||
                !int.TryParse(txtX2.Text, out int x2) || !int.TryParse(txtY2.Text, out int y2) ||
                !int.TryParse(txtXMin.Text, out int xmin) || !int.TryParse(txtYMin.Text, out int ymin) ||
                !int.TryParse(txtW.Text, out int wRect) || !int.TryParse(txtH.Text, out int hRect))
            {
                MessageBox.Show("Valores inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Rectangle rectVentana = new Rectangle(xmin, ymin, wRect, hRect);
            Point pOriginal1 = new Point(x1, y1);
            Point pOriginal2 = new Point(x2, y2);

            int delay = (int)numSpeed.Value;
            int wCanvas = pictureBox1.Width;
            int hCanvas = pictureBox1.Height;

            // Reutilizamos el bitmap actual o creamos uno nuevo
            Bitmap bmp = new Bitmap(wCanvas, hCanvas);
            pictureBox1.Image = bmp;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                // 1. Estado Inicial
                g.Clear(Color.Black);
                DibujarEntorno(g, rectVentana, wCanvas, hCanvas);

                // Línea Fantasma
                using (Pen penGhost = new Pen(Color.Gray, 1) { DashStyle = DashStyle.Dot })
                {
                    g.DrawLine(penGhost, pOriginal1, pOriginal2);
                }
                pictureBox1.Refresh();
                if (delay > 0) await Task.Delay(delay);

                // 2. Animación
                foreach (EstadoRecorte paso in _algoritmoRecorte.RecortarAnimado(pOriginal1, pOriginal2, rectVentana))
                {
                    lblMsg.Text = paso.Mensaje;

                    // Redibujar fondo (Grid + Ventana)
                    g.Clear(Color.Black);
                    DibujarEntorno(g, rectVentana, wCanvas, hCanvas);

                    // Redibujar Fantasma
                    using (Pen penGhost = new Pen(Color.FromArgb(50, 50, 50), 1) { DashStyle = DashStyle.Dot })
                    {
                        g.DrawLine(penGhost, pOriginal1, pOriginal2);
                    }

                    // DIBUJAR ESTADO ACTUAL
                    if (!paso.Terminado)
                    {
                        // En proceso (Amarillo)
                        _dibujanteLinea.DibujarLinea(g, paso.P1, paso.P2, Color.Yellow);
                    }
                    else
                    {
                        // Terminado (Verde o Rojo si fue rechazo total)
                        if (!paso.Mensaje.Contains("Rechazo"))
                        {
                            _dibujanteLinea.DibujarLinea(g, paso.P1, paso.P2, Color.Lime);
                        }
                        else
                        {
                            // Si es rechazo, dibujamos una X roja pequeña en el centro o nada
                            g.DrawLine(Pens.Red, paso.P1.X - 5, paso.P1.Y - 5, paso.P1.X + 5, paso.P1.Y + 5);
                            g.DrawLine(Pens.Red, paso.P1.X + 5, paso.P1.Y - 5, paso.P1.X - 5, paso.P1.Y + 5);
                        }
                    }

                    // Resaltar puntos
                    g.FillEllipse(Brushes.White, paso.P1.X - 3, paso.P1.Y - 3, 6, 6);
                    g.FillEllipse(Brushes.White, paso.P2.X - 3, paso.P2.Y - 3, 6, 6);

                    pictureBox1.Refresh();
                    if (delay > 0) await Task.Delay(delay);
                }
            }
        }

        private void DibujarEntorno(Graphics g, Rectangle r, int w, int h)
        {
            // CORRECCIÓN: No usar 'using' para Brushes del sistema (LightGray, Lime, etc)
            // O crear pinceles sólidos nuevos si quieres usar 'using'.

            using (Pen penWindow = new Pen(Color.White, 2))
            using (Pen penGrid = new Pen(Color.FromArgb(60, 60, 60), 1) { DashStyle = DashStyle.Dash })
            using (Font font = new Font("Consolas", 10))
            {
                // 1. Grid Extendido
                g.DrawLine(penGrid, 0, r.Top, w, r.Top);
                g.DrawLine(penGrid, 0, r.Bottom, w, r.Bottom);
                g.DrawLine(penGrid, r.Left, 0, r.Left, h);
                g.DrawLine(penGrid, r.Right, 0, r.Right, h);

                // 2. Viewport
                g.DrawRectangle(penWindow, r);

                // 3. Códigos de Región (Usamos Brushes del sistema directamente)

                // Centro
                DrawCode(g, "0000", r.Left + r.Width / 2 - 15, r.Top + r.Height / 2 - 5, font, Brushes.Lime);

                // Esquinas Superiores
                DrawCode(g, "1001", 10, 10, font, Brushes.LightGray);
                DrawCode(g, "1000", r.Left + r.Width / 2 - 15, 10, font, Brushes.LightGray);
                DrawCode(g, "1010", r.Right + 10, 10, font, Brushes.LightGray);

                // Laterales
                DrawCode(g, "0001", 10, r.Top + r.Height / 2, font, Brushes.LightGray);
                DrawCode(g, "0010", r.Right + 10, r.Top + r.Height / 2, font, Brushes.LightGray);

                // Esquinas Inferiores
                DrawCode(g, "0101", 10, r.Bottom + 10, font, Brushes.LightGray);
                DrawCode(g, "0100", r.Left + r.Width / 2 - 15, r.Bottom + 10, font, Brushes.LightGray);
                DrawCode(g, "0110", r.Right + 10, r.Bottom + 10, font, Brushes.LightGray);

                // Coordenadas
                g.DrawString($"({r.Left},{r.Top})", new Font("Arial", 8), Brushes.Yellow, r.Left - 30, r.Top - 15);
                g.DrawString($"({r.Right},{r.Bottom})", new Font("Arial", 8), Brushes.Yellow, r.Right, r.Bottom + 5);
            }
        }

        private void DrawCode(Graphics g, string text, int x, int y, Font f, Brush b)
        {
            // Validar coordenadas para evitar desbordamientos extremos (aunque en canvas es raro)
            if (x < -1000 || y < -1000 || x > 10000 || y > 10000) return;
            g.DrawString(text, f, b, x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}