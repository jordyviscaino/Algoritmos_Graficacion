using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormParametrico : Form
    {
        private readonly CParametrico _param = new CParametrico();

        public FormParametrico()
        {
            InitializeComponent();

            btnDraw.Click += BtnDraw_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        // El handler del botón sólo llama a la función que realiza el trabajo.
        private void BtnDraw_Click(object? sender, EventArgs e) => DrawCircleNoScale();

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            if (pictureBox1.Image is Image old)
            {
                pictureBox1.Image = null;
                old.Dispose();
            }

            // Asumo que en este formulario el TextBox del radio se llama txtRadio (consistente con otros).
            txtRadio.Text = string.Empty;

            btnSalir.Visible = false;
        }

        private void BtnSalir_Click(object? sender, EventArgs e)
        {
            _param.CloseForm(this);
        }

        // Usa el radio literal (en píxeles). Centro en el centro del PictureBox.
        private void DrawCircleNoScale()
        {
            if (!int.TryParse(txtRadio.Text.Trim(), out int r) || r < 0)
            {
                MessageBox.Show("Introduce un radio entero no negativo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int w = Math.Max(1, pictureBox1.Width);
            int h = Math.Max(1, pictureBox1.Height);

            if (pictureBox1.Image is Image prev) { pictureBox1.Image = null; prev.Dispose(); }

            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(pictureBox1.BackColor);

                Point center = new Point(w / 2, h / 2);

                if (r == 0)
                {
                    using (var brush = new SolidBrush(Color.Black))
                        g.FillRectangle(brush, center.X, center.Y, 1, 1);

                    pictureBox1.Image = bmp;
                    return;
                }

                int maxR = Math.Min(w, h) / 2;
                if (r > maxR)
                {
                    var res = MessageBox.Show($"El radio {r} excede la mitad del área de dibujo ({maxR}). El círculo será recortado. ¿Continuar?",
                                              "Radio grande", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                    {
                        pictureBox1.Image = bmp;
                        return;
                    }
                }

                _param.DrawCircleParametric(g, center, r, Color.Black);
            }

            pictureBox1.Image = bmp;
        }
    }
}
