using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    public class CSutherlandTriangulo
    {
        // Define una ventana triangular fija o configurable
        public List<Point> VentanaTriangular { get; set; }

        public IEnumerable<EstadoPoligono> RecortarAnimado(List<Point> sujeto)
        {
            if (VentanaTriangular == null || VentanaTriangular.Count < 3) yield break;

            List<Point> listaActual = new List<Point>(sujeto);

            // El triángulo tiene 3 aristas que actúan como "cuchillos" infinitos
            for (int i = 0; i < 3; i++)
            {
                Point bordeA = VentanaTriangular[i];
                Point bordeB = VentanaTriangular[(i + 1) % 3];

                yield return new EstadoPoligono(listaActual, $"Recortando contra arista {i + 1} del triángulo...", false);

                listaActual = RecortarContraArista(listaActual, bordeA, bordeB);

                if (listaActual.Count == 0) break;
            }

            yield return new EstadoPoligono(listaActual, "Recorte Triangular Finalizado", true);
        }

        private List<Point> RecortarContraArista(List<Point> entrada, Point a, Point b)
        {
            List<Point> salida = new List<Point>();
            if (entrada.Count == 0) return salida;

            for (int i = 0; i < entrada.Count; i++)
            {
                Point S = entrada[i];
                Point E = entrada[(i + 1) % entrada.Count];

                bool sIn = EstaDentro(S, a, b);
                bool eIn = EstaDentro(E, a, b);

                if (sIn && eIn) salida.Add(E);
                else if (sIn && !eIn) salida.Add(Interseccion(S, E, a, b));
                else if (!sIn && eIn)
                {
                    salida.Add(Interseccion(S, E, a, b));
                    salida.Add(E);
                }
            }
            return salida;
        }

        // Determina si el punto P está "dentro" de la línea AB
        // Usamos el Producto Cruz (Cross Product) para saber el lado (Izquierda/Derecha)
        // Asumimos que el triángulo se define en sentido horario (Clockwise)
        private bool EstaDentro(Point p, Point a, Point b)
        {
            // Vector AB
            int ax = b.X - a.X;
            int ay = b.Y - a.Y;
            // Vector AP
            int bx = p.X - a.X;
            int by = p.Y - a.Y;

            // Cross Product 2D: (B - A) x (P - A)
            // Si es positivo, está a un lado; si negativo, al otro.
            return (ax * by - ay * bx) >= 0;
        }

        // Intersección de recta P1-P2 con recta A-B
        private Point Interseccion(Point p1, Point p2, Point a, Point b)
        {
            // Fórmula de intersección de dos rectas dadas por dos puntos
            // L1: P1 + t(P2-P1)
            // L2: A + u(B-A)

            float x1 = p1.X, y1 = p1.Y, x2 = p2.X, y2 = p2.Y;
            float x3 = a.X, y3 = a.Y, x4 = b.X, y4 = b.Y;

            float den = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);

            if (den == 0) return new Point(0, 0); // Paralelas (no debería pasar con la lógica In/Out)

            float t = ((x1 - x3) * (y3 - y4) - (y1 - y3) * (x3 - x4)) / den;

            int x = (int)(x1 + t * (x2 - x1));
            int y = (int)(y1 + t * (y2 - y1));

            return new Point(x, y);
        }
    }
}