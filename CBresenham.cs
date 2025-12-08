using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    internal class CBresenham2
    {
        /// <summary> para borrar
        /// Generador de puntos para el algoritmo de Bresenham (línea) — usa solo enteros.
        /// Produce cada punto en el orden en que se dibujaría.
        /// </summary>
        public IEnumerable<Point> GetLinePointsBresenham(Point p0, Point p1)
        {
            int x0 = p0.X, y0 = p0.Y;
            int x1 = p1.X, y1 = p1.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            // Primer punto
            yield return new Point(x0, y0);

            while (!(x0 == x1 && y0 == y1))
            {
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }

                yield return new Point(x0, y0);
            }
        }

        /// <summary>
        /// Dibuja con Bresenham usando el generador de puntos.
        /// </summary>
        public void DrawLineBresenham(Graphics g, Point p0, Point p1, Color color)
        {
            using (Pen pen = new Pen(color, 1))
            {
                foreach (var pt in GetLinePointsBresenham(p0, p1))
                {
                    // Dibujar un "pixel" como rectángulo 1x1 (consistente con el resto)
                    g.DrawRectangle(pen, pt.X, pt.Y, 1, 1);
                }
            }
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
