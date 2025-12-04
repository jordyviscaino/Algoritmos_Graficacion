using System;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    internal class CBresenham
    {
        public void DrawLineBresenham(Graphics g, Point p0, Point p1, Color color)
        {
            int x0 = p0.X, y0 = p0.Y;
            int x1 = p1.X, y1 = p1.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            using (Pen pen = new Pen(color, 1))
            {
                while (true)
                {
                    g.DrawRectangle(pen, x0, y0, 1, 1);

                    if (x0 == x1 && y0 == y1) break;

                    int e2 = 2 * err;
                    if (e2 > -dy) { err -= dy; x0 += sx; }
                    if (e2 < dx) { err += dx; y0 += sy; }
                }
            }
        }

        // Método añadido para cerrar el formulario desde el botón Salir (consistente con Cdda).
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
