using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public partial class FormDDA : Form
    {
        private readonly Cdda _dda = new Cdda();

        public FormDDA()
        {
            InitializeComponent();

            // Registrar manejadores de eventos de forma explícita:
            btnDraw.Click += BtnDraw_Click;
            btnClear.Click += BtnClear_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        // El handler del botón solo llama a la función encargada del dibujo (según tu requisito).
        private void BtnDraw_Click(object? sender, EventArgs e)
        {
            DrawScaledLine();
        }

        // Borra el dibujo, los TextBox y oculta el botón "Salir".
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            // Liberar imagen previa si existe
            if (pictureBox1.Image is Image old)
            {
                pictureBox1.Image = null;
                old.Dispose();
            }

            // Limpiar campos de texto (mapeo según diseñador: txtX1=X1, txtY0=Y1, txtX0=X2, txtY1=Y2)
            txtX1.Text = string.Empty;
            txtY0.Text = string.Empty;
            txtX0.Text = string.Empty;
            txtY1.Text = string.Empty;

            // Ocultar el botón cerrar según tu instrucción ("borrar ... y el boton cerrar")
            btnSalir.Visible = false;
        }

        // Cierra el formulario usando la clase Cdda (se reutiliza la función ya presente).
        private void BtnSalir_Click(object? sender, EventArgs e)
        {
            _dda.CloseForm(this);
        }

        // Función que realiza parseo, escalado matemático y llama al DDA.
        // Implementación independiente del handler para que btnDraw solo llame a esta función.
        private void DrawScaledLine()
        {
            // Parseo seguro de los valores ingresados
            bool okX1 = int.TryParse(txtX1.Text.Trim(), out int x1);
            bool okY1 = int.TryParse(txtY0.Text.Trim(), out int y1); // txtY0 corresponde a Y1 en el diseñador
            bool okX2 = int.TryParse(txtX0.Text.Trim(), out int x2); // txtX0 corresponde a X2
            bool okY2 = int.TryParse(txtY1.Text.Trim(), out int y2); // txtY1 corresponde a Y2

            if (!okX1 || !okY1 || !okX2 || !okY2)
            {
                MessageBox.Show("Introduce valores enteros válidos en X1, Y1, X2, Y2.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear bitmap del tamaño del PictureBox y su Graphics
            int w = Math.Max(1, pictureBox1.Width);
            int h = Math.Max(1, pictureBox1.Height);

            // Liberar y reemplazar imagen previa
            if (pictureBox1.Image is Image prev) { pictureBox1.Image = null; prev.Dispose(); }

            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Fondo
                g.Clear(pictureBox1.BackColor);

                // Coordenadas originales ingresadas por el usuario
                Point p0 = new Point(x1, y1);
                Point p1 = new Point(x2, y2);

                // Determinar caja delimitadora en coordenadas del usuario
                int minX = Math.Min(p0.X, p1.X);
                int maxX = Math.Max(p0.X, p1.X);
                int minY = Math.Min(p0.Y, p1.Y);
                int maxY = Math.Max(p0.Y, p1.Y);

                // Tamaño del rango (evitar división por cero)
                float rangeW = Math.Max(1, maxX - minX);
                float rangeH = Math.Max(1, maxY - minY);

                // Márgenes internos para no dibujar exactamente en el borde
                const float margin = 10f;
                float availW = Math.Max(1f, w - 2 * margin);
                float availH = Math.Max(1f, h - 2 * margin);

                // Escalado uniforme para que la línea quepa en el PictureBox manteniendo proporciones
                float scaleX = availW / rangeW;
                float scaleY = availH / rangeH;
                float scale = Math.Min(scaleX, scaleY);

                // Offset para centrar la figura dentro del PictureBox
                float usedW = rangeW * scale;
                float usedH = rangeH * scale;
                float offsetX = margin + (availW - usedW) / 2f;
                float offsetY = margin + (availH - usedH) / 2f;

                // Transformación: trasladar de coordenadas de usuario a coordenadas de imagen
                Point tp0 = new Point(
                    (int)Math.Round((p0.X - minX) * scale + offsetX),
                    (int)Math.Round((p0.Y - minY) * scale + offsetY)
                );

                Point tp1 = new Point(
                    (int)Math.Round((p1.X - minX) * scale + offsetX),
                    (int)Math.Round((p1.Y - minY) * scale + offsetY)
                );

                // Llamada al algoritmo DDA (sin librerías automáticas; dibuja píxeles matemáticamente)
                _dda.DrawLineDDA(g, tp0, tp1, Color.Black);
            }

            // Asignar bitmap al PictureBox
            pictureBox1.Image = bmp;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
