using System;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    // ===========================================
    // 1. ALGORITMO INCREMENTAL (Ecuación Básica)
    // ===========================================
    public class CIncremento
    {
        public void DibujarLinea(Graphics g, Point p1, Point p2, Color color)
        {
            using (Brush brush = new SolidBrush(color))
            {
                if (p1.X == p2.X) // Caso Vertical
                {
                    int start = Math.Min(p1.Y, p2.Y);
                    int end = Math.Max(p1.Y, p2.Y);
                    for (int y = start; y <= end; y++)
                    {
                        g.FillRectangle(brush, p1.X, y, 1, 1); // Pinta 1 pixel
                    }
                    return;
                }

                float m = (float)(p2.Y - p1.Y) / (p2.X - p1.X);
                float b = p1.Y - (m * p1.X);

                int xStart = Math.Min(p1.X, p2.X);
                int xEnd = Math.Max(p1.X, p2.X);

                for (int x = xStart; x <= xEnd; x++)
                {
                    float y = (m * x) + b;
                    g.FillRectangle(brush, x, (int)Math.Round(y), 1, 1);
                }
            }
        }
    }

    // ===========================================
    // 2. ALGORITMO DDA (Diferencial)
    // ===========================================
    public class CDDA
    {
        public void DibujarLinea(Graphics g, Point p1, Point p2, Color color)
        {
            using (Brush brush = new SolidBrush(color))
            {
                int dx = p2.X - p1.X;
                int dy = p2.Y - p1.Y;

                int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

                float xInc = (float)dx / steps;
                float yInc = (float)dy / steps;

                float x = p1.X;
                float y = p1.Y;

                // Primer pixel
                g.FillRectangle(brush, (int)Math.Round(x), (int)Math.Round(y), 1, 1);

                for (int k = 0; k < steps; k++)
                {
                    x += xInc;
                    y += yInc;
                    g.FillRectangle(brush, (int)Math.Round(x), (int)Math.Round(y), 1, 1);
                }
            }
        }
    }

    // ===========================================
    // 3. ALGORITMO BRESENHAM (Enteros)
    // ===========================================
    public class CBresenham
    {
        public void DibujarLinea(Graphics g, Point p1, Point p2, Color color)
        {
            using (Brush brush = new SolidBrush(color))
            {
                int x0 = p1.X;
                int y0 = p1.Y;
                int x1 = p2.X;
                int y1 = p2.Y;

                int dx = Math.Abs(x1 - x0);
                int dy = Math.Abs(y1 - y0);
                int sx = (x0 < x1) ? 1 : -1;
                int sy = (y0 < y1) ? 1 : -1;
                int err = dx - dy;

                while (true)
                {
                    g.FillRectangle(brush, x0, y0, 1, 1);

                    if (x0 == x1 && y0 == y1) break;

                    int e2 = 2 * err;
                    if (e2 > -dy)
                    {
                        err -= dy;
                        x0 += sx;
                    }
                    if (e2 < dx)
                    {
                        err += dx;
                        y0 += sy;
                    }
                }
            }
        }
    }
}