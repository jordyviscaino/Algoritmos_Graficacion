using System;
using System.Drawing;
using System.Windows.Forms;

namespace Algoritmos_Graficacion
{
    public class Cdda
    {
        public void DrawLineDDA(Graphics g, Point p0, Point p1, Color color)
        {
            int dx = p1.X - p0.X;
            int dy = p1.Y - p0.Y;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            // Si los puntos coinciden, dibujar un pixel y salir
            if (steps == 0)
            {
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, p0.X, p0.Y, 1, 1);
                }
                return;
            }

            float xInc = dx / (float)steps;
            float yInc = dy / (float)steps;

            float x = p0.X;
            float y = p0.Y;

            using (Brush brush = new SolidBrush(color))
            {
                for (int i = 0; i <= steps; i++)
                {
                    // Evitar valores no válidos
                    if (!float.IsNaN(x) && !float.IsNaN(y) && !float.IsInfinity(x) && !float.IsInfinity(y))
                    {
                        int xi = (int)Math.Round(x);
                        int yi = (int)Math.Round(y);
                        g.FillRectangle(brush, xi, yi, 1, 1);
                    }

                    x += xInc;
                    y += yInc;
                }
            }
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

