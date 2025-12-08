using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    internal class CParametrico
    {
        // Dibuja un círculo usando la forma paramétrica: para borrar
        // x = xc + r * cos(t), y = yc + r * sin(t)
        // El radio se interpreta en píxeles (ya escalado por el formulario).
        public void DrawCircleParametric(Graphics g, Point center, int r, Color color)
        {
            if (r < 0) return;

            int xc = center.X;
            int yc = center.Y;

            if (r == 0)
            {
                using (var brush = new SolidBrush(color))
                    g.FillRectangle(brush, xc, yc, 1, 1);
                return;
            }

            // Paso angular: aproximadamente 1/píxel en arco (circunferencia ≈ 2πr),
            // tomar dθ = 1 / r garantiza un punto por cada ~1 píxel en el arco.
            double step = 1.0 / Math.Max(1, r);
            double twoPi = 2.0 * Math.PI;

            using (var brush = new SolidBrush(color))
            {
                // Para evitar dibujar muchas veces el mismo píxel, recordar el último punto dibujado.
                int lastX = int.MinValue;
                int lastY = int.MinValue;

                for (double t = 0.0; t <= twoPi + 1e-9; t += step)
                {
                    double fx = xc + r * Math.Cos(t);
                    double fy = yc + r * Math.Sin(t);

                    int x = (int)Math.Round(fx);
                    int y = (int)Math.Round(fy);

                    if (x == lastX && y == lastY) continue;

                    g.FillRectangle(brush, x, y, 1, 1);

                    lastX = x;
                    lastY = y;
                }
            }
        }

        // Mantener interfaz consistente con otras clases de algoritmo
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
