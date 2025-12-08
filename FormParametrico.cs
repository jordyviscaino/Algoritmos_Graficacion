using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormParametrico : Form
    {
        private readonly CCirculoParametrico _algoritmo = new CCirculoParametrico();

        public FormParametrico()
        {
            InitializeComponent();
            this.Text = "Círculo Paramétrico (Sin Octantes)";
            chkOctantes.Enabled = false; 
            chkOctantes.Text = "No aplica Octantes";

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
                MessageBox.Show("Ingrese valores válidos."); return;
            }

            if (r <= 0) { MessageBox.Show("Radio > 0"); return; }

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
                if (chkGrid.Checked)
                {
                    using (Pen gridPen = new Pen(Color.FromArgb(30, 30, 30)))
                    {
                        for (int i = 0; i <= w; i += pixelSize) g.DrawLine(gridPen, i, 0, i, h);
                        for (int j = 0; j <= h; j += pixelSize) g.DrawLine(gridPen, 0, j, w, j);
                    }
                }
                pictureBox1.Refresh();

                // --- ALGORITMO PARAMÉTRICO ---
                // Aquí se dibuja pixel a pixel dando la vuelta, NO 8 a la vez
                using (Brush brush = new SolidBrush(Color.LimeGreen))
                {
                    foreach (Point p in _algoritmo.Calcular(xc, yc, r))
                    {
                        if (p.X >= 0 && p.X < gridW && p.Y >= 0 && p.Y < gridH)
                        {
                            g.FillRectangle(brush, p.X * pixelSize + 1, p.Y * pixelSize + 1, pixelSize - 1, pixelSize - 1);
                        }

                        pictureBox1.Invalidate();
                        pictureBox1.Update();

                        // Delay muy pequeño porque son muchos más puntos
                        if (delay > 0) await Task.Delay(delay / 2);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}