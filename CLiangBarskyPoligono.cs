using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    public class CLiangBarskyPoligono
    {
        public IEnumerable<EstadoPoligono> RecortarAnimado(List<Point> sujeto, Rectangle rect)
        {
            if (sujeto.Count < 3) yield break;

            List<Point> salida = new List<Point>();
            int xmin = rect.Left, xmax = rect.Right;
            int ymin = rect.Top, ymax = rect.Bottom;

            yield return new EstadoPoligono(sujeto, "Inicio: Analizando aristas paramétricamente...", false);

            // Liang-Barsky procesa arista por arista
            for (int i = 0; i < sujeto.Count; i++)
            {
                Point p1 = sujeto[i];
                Point p2 = sujeto[(i + 1) % sujeto.Count]; // Siguiente vértice

                // Parametros t de entrada (0) y salida (1)
                double t0 = 0.0, t1 = 1.0;
                int dx = p2.X - p1.X;
                int dy = p2.Y - p1.Y;

                // Definimos los 4 bordes como desigualdades p*t <= q
                // Izquierda, Derecha, Arriba, Abajo
                double[] p = { -dx, dx, -dy, dy };
                double[] q = { p1.X - xmin, xmax - p1.X, p1.Y - ymin, ymax - p1.Y };

                bool aceptado = true;

                for (int edge = 0; edge < 4; edge++)
                {
                    if (p[edge] == 0) // Paralela
                    {
                        if (q[edge] < 0) { aceptado = false; break; } // Fuera
                    }
                    else
                    {
                        double t = q[edge] / p[edge];
                        if (p[edge] < 0) // Entrando
                        {
                            if (t > t1) { aceptado = false; break; }
                            if (t > t0) t0 = t;
                        }
                        else // Saliendo
                        {
                            if (t < t0) { aceptado = false; break; }
                            if (t < t1) t1 = t;
                        }
                    }
                }

                if (aceptado)
                {
                    // Si t0 > 0, hubo un recorte en la entrada -> agregamos punto intersección
                    if (t0 > 0)
                    {
                        salida.Add(new Point(
                            (int)(p1.X + t0 * dx),
                            (int)(p1.Y + t0 * dy)
                        ));
                    }

                    // Agregamos punto final (recortado en t1 o el original si t1=1)
                    salida.Add(new Point(
                        (int)(p1.X + t1 * dx),
                        (int)(p1.Y + t1 * dy)
                    ));
                }

                // Animación: mostramos cómo se va construyendo el nuevo polígono
                yield return new EstadoPoligono(salida, $"Procesando Arista {i + 1}/{sujeto.Count}", false);
            }

            yield return new EstadoPoligono(salida, "Recorte Paramétrico Finalizado", true);
        }
    }
}