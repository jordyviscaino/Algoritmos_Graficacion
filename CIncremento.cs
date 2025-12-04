using System;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    internal class CIncremento
    {
        public void DrawLineMidpoint(Graphics g, Point p0, Point p1, Color color)
        {
            int x0 = p0.X;
            int y0 = p0.Y;
            int x1 = p1.X;
            int y1 = p1.Y;

            if (x0 == x1 && y0 == y1)
            {
                using (var brush = new SolidBrush(color))
                    g.FillRectangle(brush, x0, y0, 1, 1);
                return;
            }

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }

            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }

            int dx = x1 - x0;
            int dy = Math.Abs(y1 - y0);
            int d = 2 * dy - dx;
            int ystep = (y0 < y1) ? 1 : -1;
            int y = y0;

            using (var brush = new SolidBrush(color))
            {
                for (int x = x0; x <= x1; x++)
                {
                    if (steep)
                    {
                        g.FillRectangle(brush, y, x, 1, 1);
                    }
                    else
                    {
                        g.FillRectangle(brush, x, y, 1, 1);
                    }

                    if (d > 0)
                    {
                        y += ystep;
                        d -= 2 * dx;
                    }
                    d += 2 * dy;
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int t = a; a = b; b = t;
        }

        // Método añadido para cerrar el formulario desde el botón Salir (consistente con Cdda).
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
