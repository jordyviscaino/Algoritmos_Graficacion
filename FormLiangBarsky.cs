using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    // NOTA: Copiar el Designer de FormCohenSutherland y cambiar el nombre de la clase parcial.
    public partial class FormLiangBarsky : Form
    {
        private CLiangBarsky _algoritmo = new CLiangBarsky();
        private CBresenham _dibujante = new CBresenham();

        public FormLiangBarsky()
        {
            InitializeComponent();
            this.Text = "Algoritmo Liang-Barsky (Paramétrico)";

            btnRecortar.Click += BtnRecortar_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
            this.Load += (s, e) => InicializarLienzo();
        }

        private void InicializarLienzo()
        {
            if (pictureBox1.Width == 0) return;
            // Valores por defecto
            int xmin = int.TryParse(txtXMin.Text, out int x) ? x : 150;
            int ymin = int.TryParse(txtYMin.Text, out int y) ? y : 100;
            int wR = int.TryParse(txtW.Text, out int w) ? w : 200;
            int hR = int.TryParse(txtH.Text, out int h) ? h : 150;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                // En Liang Barsky no dibujamos el grid de 9 zonas, solo el viewport
                DibujarViewport(g, new Rectangle(xmin, ymin, wR, hR));
            }
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = bmp;
        }

        private async void BtnRecortar_Click(object sender, EventArgs e)
        {
            btnRecortar.Enabled = false;
            await EjecutarAnimacion();
            btnRecortar.Enabled = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            InicializarLienzo();
            lblMsg.Text = "...";
            txtX1.Clear(); txtY1.Clear(); txtX2.Clear(); txtY2.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e) => Close();

        private async Task EjecutarAnimacion()
        {
            // Validaciones (Igual que Cohen)
            if (!int.TryParse(txtX1.Text, out int x1) || !int.TryParse(txtY1.Text, out int y1) ||
                !int.TryParse(txtX2.Text, out int x2) || !int.TryParse(txtY2.Text, out int y2) ||
                !int.TryParse(txtXMin.Text, out int xmin) || !int.TryParse(txtYMin.Text, out int ymin) ||
                !int.TryParse(txtW.Text, out int wRect) || !int.TryParse(txtH.Text, out int hRect))
            {
                MessageBox.Show("Datos inválidos."); return;
            }

            Rectangle rect = new Rectangle(xmin, ymin, wRect, hRect);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            int delay = (int)numSpeed.Value;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                // 1. Mostrar estado inicial (Línea infinita conceptual)
                g.Clear(Color.Black);
                DibujarViewport(g, rect);

                // Dibujar línea extendida (representando t de -inf a +inf)
                using (Pen pExt = new Pen(Color.DarkGray) { DashStyle = DashStyle.Dot })
                    g.DrawLine(pExt, p1.X - (p2.X - p1.X), p1.Y - (p2.Y - p1.Y), p2.X + (p2.X - p1.X), p2.Y + (p2.Y - p1.Y));

                _dibujante.DibujarLinea(g, p1, p2, Color.White); // Segmento original
                pictureBox1.Refresh();
                if (delay > 0) await Task.Delay(delay);

                // 2. Animación
                foreach (var paso in _algoritmo.RecortarAnimado(p1, p2, rect))
                {
                    lblMsg.Text = paso.Mensaje;

                    g.Clear(Color.Black);
                    DibujarViewport(g, rect);

                    // Fantasma original
                    using (Pen pGhost = new Pen(Color.FromArgb(60, 60, 60)) { DashStyle = DashStyle.Dot })
                        g.DrawLine(pGhost, p1, p2);

                    // Línea recortada actual (Bresenham)
                    if (!paso.Terminado)
                        _dibujante.DibujarLinea(g, paso.P1, paso.P2, Color.Cyan); // Calculando
                    else if (!paso.Mensaje.Contains("Rechazo"))
                        _dibujante.DibujarLinea(g, paso.P1, paso.P2, Color.Lime); // Final

                    // Puntos
                    g.FillEllipse(Brushes.Yellow, paso.P1.X - 3, paso.P1.Y - 3, 6, 6);
                    g.FillEllipse(Brushes.Yellow, paso.P2.X - 3, paso.P2.Y - 3, 6, 6);

                    pictureBox1.Refresh();
                    if (delay > 0) await Task.Delay(delay);
                }
            }
        }

        private void DibujarViewport(Graphics g, Rectangle r)
        {
            using (Pen p = new Pen(Color.White, 2)) g.DrawRectangle(p, r);
            g.DrawString("Viewport", this.Font, Brushes.LightGray, r.Left, r.Top - 15);
        }
    }
}