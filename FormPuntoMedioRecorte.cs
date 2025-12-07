using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    // NOTA: Copiar el Designer de FormCohenSutherland y cambiar el nombre de la clase parcial.
    public partial class FormPuntoMedioRecorte : Form
    {
        private CPuntoMedioRecorte _algoritmo = new CPuntoMedioRecorte();
        private CBresenham _dibujante = new CBresenham();

        public FormPuntoMedioRecorte()
        {
            InitializeComponent();
            this.Text = "Algoritmo Subdivisión Punto Medio";

            btnRecortar.Click += BtnRecortar_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
            this.Load += (s, e) => InicializarLienzo();
        }

        private void InicializarLienzo()
        {
            if (pictureBox1.Width == 0) return;
            int xmin = int.TryParse(txtXMin.Text, out int x) ? x : 150;
            int ymin = int.TryParse(txtYMin.Text, out int y) ? y : 100;
            int wR = int.TryParse(txtW.Text, out int w) ? w : 200;
            int hR = int.TryParse(txtH.Text, out int h) ? h : 150;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                DibujarEntorno(g, new Rectangle(xmin, ymin, wR, hR));
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
            // Validaciones
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

                // Animación
                foreach (var paso in _algoritmo.RecortarAnimado(p1, p2, rect))
                {
                    lblMsg.Text = paso.Mensaje;
                    g.Clear(Color.Black);
                    DibujarEntorno(g, rect);

                    // Fantasma
                    using (Pen pGhost = new Pen(Color.FromArgb(50, 50, 50)) { DashStyle = DashStyle.Dot })
                        g.DrawLine(pGhost, p1, p2);

                    // Línea Actual
                    Color c = paso.Terminado ? Color.Lime : Color.Orange;
                    if (paso.Mensaje.Contains("Rechazo")) c = Color.Red;

                    if (c != Color.Red)
                        _dibujante.DibujarLinea(g, paso.P1, paso.P2, c);

                    // Puntos
                    g.FillEllipse(Brushes.White, paso.P1.X - 3, paso.P1.Y - 3, 6, 6);
                    g.FillEllipse(Brushes.White, paso.P2.X - 3, paso.P2.Y - 3, 6, 6);

                    pictureBox1.Refresh();
                    if (delay > 0) await Task.Delay(delay);
                }
            }
        }

        private void DibujarEntorno(Graphics g, Rectangle r)
        {
            // En Punto Medio es útil ver el Grid 3x3 como en Cohen
            using (Pen p = new Pen(Color.White, 2)) g.DrawRectangle(p, r);
            using (Pen pGrid = new Pen(Color.Gray) { DashStyle = DashStyle.Dot })
            {
                g.DrawLine(pGrid, 0, r.Top, 2000, r.Top);
                g.DrawLine(pGrid, 0, r.Bottom, 2000, r.Bottom);
                g.DrawLine(pGrid, r.Left, 0, r.Left, 2000);
                g.DrawLine(pGrid, r.Right, 0, r.Right, 2000);
            }
        }
    }
}