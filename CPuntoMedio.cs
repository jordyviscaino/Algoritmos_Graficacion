using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    // ----------------------------------------------------------
    // ALGORITMO PARAMÉTRICO (Trigonométrico)
    // ----------------------------------------------------------
    public class CCirculoParametrico
    {
        // Este algoritmo NO usa simetría de octantes, dibuja secuencialmente usando ángulos.
        public IEnumerable<Point> Calcular(int xc, int yc, int radio)
        {
            // Paso angular: Ajustamos el paso según el radio para evitar huecos.
            // A mayor radio, necesitamos pasos más pequeños (1/r).
            double paso = 1.0 / radio;

            for (double theta = 0; theta <= 2 * Math.PI; theta += paso)
            {
                int x = (int)Math.Round(xc + radio * Math.Cos(theta));
                int y = (int)Math.Round(yc + radio * Math.Sin(theta));

                yield return new Point(x, y);
            }
        }
    }

    // ----------------------------------------------------------
    // ALGORITMO BRESENHAM (Simetría de 8 lados)
    // ----------------------------------------------------------
    public class CCirculoBresenham
    {
        // Devuelve una lista de puntos (los 8 simétricos) en cada paso del cálculo
        public IEnumerable<Point[]> Calcular(int xc, int yc, int radio)
        {
            int x = 0;
            int y = radio;
            int d = 3 - 2 * radio; // Parámetro de decisión inicial

            while (x <= y)
            {
                // Devolvemos los 8 puntos de simetría para el paso actual
                yield return ObtenerSimetria8(xc, yc, x, y);

                if (d < 0)
                {
                    d = d + 4 * x + 6;
                }
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }
        }

        private Point[] ObtenerSimetria8(int xc, int yc, int x, int y)
        {
            return new Point[]
            {
                new Point(xc + x, yc + y), // Octante 1
                new Point(xc - x, yc + y), // Octante 2
                new Point(xc + x, yc - y), // Octante 3
                new Point(xc - x, yc - y), // Octante 4
                new Point(xc + y, yc + x), // Octante 5
                new Point(xc - y, yc + x), // Octante 6
                new Point(xc + y, yc - x), // Octante 7
                new Point(xc - y, yc - x)  // Octante 8
            };
        }
    }

    // ----------------------------------------------------------
    // ALGORITMO PUNTO MEDIO (Midpoint)
    // ----------------------------------------------------------
    public class CCirculoPuntoMedio
    {
        public IEnumerable<Point[]> Calcular(int xc, int yc, int radio)
        {
            int x = 0;
            int y = radio;
            // P = 1 - r (versión entera de 5/4 - r)
            int p = 1 - radio;

            while (x <= y)
            {
                yield return ObtenerSimetria8(xc, yc, x, y);

                x++;

                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
            }
        }

        private Point[] ObtenerSimetria8(int xc, int yc, int x, int y)
        {
            return new Point[]
            {
                new Point(xc + x, yc + y), new Point(xc - x, yc + y),
                new Point(xc + x, yc - y), new Point(xc - x, yc - y),
                new Point(xc + y, yc + x), new Point(xc - y, yc + x),
                new Point(xc + y, yc - x), new Point(xc - y, yc - x)
            };
        }
    }
}