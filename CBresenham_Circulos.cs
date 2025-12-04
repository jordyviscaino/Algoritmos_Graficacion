using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    internal class CBresenham_Circulos
    {
        // Implementación de Bresenham (algoritmo entero para círculos).
        // Dibuja los 8 puntos simétricos por iteración usando sólo operaciones enteras.
        public void DrawCircleBresenham(Graphics g, Point center, int r, Color color)
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

            int x = 0;
            int y = r;
            int d = 3 - 2 * r; // decisión inicial (enteros)

            using (var brush = new SolidBrush(color))
            {
                Plot8(g, brush, xc, yc, x, y);

                while (x < y)
                {
                    if (d < 0)
                    {
                        // El punto elegido está más cerca, sólo incrementar x
                        d = d + 4 * x + 6;
                    }
                    else
                    {
                        // Mover diagonalmente
                        d = d + 4 * (x - y) + 10;
                        y--;
                    }
                    x++;
                    Plot8(g, brush, xc, yc, x, y);
                }
            }
        }

        // Dibuja los ocho puntos simétricos del círculo en coordenadas enteras.
        private static void Plot8(Graphics g, Brush brush, int xc, int yc, int x, int y)
        {
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
