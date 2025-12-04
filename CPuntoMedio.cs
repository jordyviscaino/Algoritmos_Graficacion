using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    internal class CPuntoMedio
    {
        // Dibuja un círculo usando el algoritmo del punto medio.
        // center y r deben estar en coordenadas de píxel (ya escaladas).
        public void DrawCircleMidPoint(Graphics g, Point center, int r, Color color)
        {
            if (r < 0) return;

            int xc = center.X;
            int yc = center.Y;

            if (r == 0)
            {
                using (var brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, xc, yc, 1, 1);
                }
                return;
            }

            int x = 0;
            int y = r;
            int p = 1 - r;

            using (var brush = new SolidBrush(color))
            {
                Plot8(g, brush, xc, yc, x, y);

                while (x < y)
                {
                    x++;
                    if (p < 0)
                    {
                        p = p + 2 * x + 1;
                    }
                    else
                    {
                        y--;
                        p = p + 2 * (x - y) + 1;
                    }
                    Plot8(g, brush, xc, yc, x, y);
                }
            }
        }

        // Dibuja los ocho puntos simétricos del círculo
        private static void Plot8(Graphics g, Brush brush, int xc, int yc, int x, int y)
        {
            // Evitar dibujar fuera de límites no es responsabilidad del algoritmo; Graphics ignorará parcialmente.
            g.FillRectangle(brush, xc + x, yc + y, 1, 1);
            g.FillRectangle(brush, xc - x, yc + y, 1, 1);
            g.FillRectangle(brush, xc + x, yc - y, 1, 1);
            g.FillRectangle(brush, xc - x, yc - y, 1, 1);
            g.FillRectangle(brush, xc + y, yc + x, 1, 1);
            g.FillRectangle(brush, xc - y, yc + x, 1, 1);
            g.FillRectangle(brush, xc + y, yc - x, 1, 1);
            g.FillRectangle(brush, xc - y, yc - x, 1, 1);
        }

        // Mantener interfaz consistente con otras clases de algoritmo
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
