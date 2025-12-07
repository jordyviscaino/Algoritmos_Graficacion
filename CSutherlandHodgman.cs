using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    public struct EstadoPoligono
    {
        public List<Point> PoligonoActual;
        public string Mensaje;
        public bool Terminado;

        public EstadoPoligono(List<Point> pts, string msg, bool fin)
        {
            PoligonoActual = new List<Point>(pts);
            Mensaje = msg;
            Terminado = fin;
        }
    }

    public class CSutherlandHodgman
    {
        private enum Borde { Izquierda, Derecha, Abajo, Arriba }

        public IEnumerable<EstadoPoligono> RecortarAnimado(List<Point> verticesEntrada, Rectangle ventana)
        {
            if (verticesEntrada == null || verticesEntrada.Count == 0) yield break;

            List<Point> listaActual = new List<Point>(verticesEntrada);
            Borde[] bordes = { Borde.Izquierda, Borde.Arriba, Borde.Derecha, Borde.Abajo };

            foreach (var borde in bordes)
            {
                if (listaActual.Count == 0) break;
                yield return new EstadoPoligono(listaActual, $"Recortando Borde: {borde}...", false);
                listaActual = RecortarContraBorde(listaActual, ventana, borde);
            }

            yield return new EstadoPoligono(listaActual, "Recorte Finalizado", true);
        }

        private List<Point> RecortarContraBorde(List<Point> entrada, Rectangle rect, Borde borde)
        {
            List<Point> salida = new List<Point>();
            if (entrada.Count == 0) return salida;

            for (int i = 0; i < entrada.Count; i++)
            {
                Point S = entrada[i];
                Point E = entrada[(i + 1) % entrada.Count]; // Arista S -> E

                bool sDentro = EstaDentro(S, rect, borde);
                bool eDentro = EstaDentro(E, rect, borde);

                if (sDentro && eDentro)
                {
                    salida.Add(E);
                }
                else if (sDentro && !eDentro)
                {
                    salida.Add(CalcularInterseccion(S, E, rect, borde));
                }
                else if (!sDentro && eDentro)
                {
                    salida.Add(CalcularInterseccion(S, E, rect, borde));
                    salida.Add(E);
                }
            }
            return salida;
        }

        private bool EstaDentro(Point p, Rectangle r, Borde b)
        {
            switch (b)
            {
                case Borde.Izquierda: return p.X >= r.Left;
                case Borde.Derecha: return p.X <= r.Right;
                case Borde.Abajo: return p.Y <= r.Bottom;
                case Borde.Arriba: return p.Y >= r.Top;
                default: return false;
            }
        }

        private Point CalcularInterseccion(Point p1, Point p2, Rectangle r, Borde b)
        {
            // Evitar division por cero y calculos innecesarios
            if (p1.X == p2.X) // Linea Vertical
            {
                // Si es vertical, solo puede cortar Arriba o Abajo
                if (b == Borde.Arriba) return new Point(p1.X, r.Top);
                if (b == Borde.Abajo) return new Point(p1.X, r.Bottom);
                return p1; // No deberia ocurrir para Izq/Der
            }
            if (p1.Y == p2.Y) // Linea Horizontal
            {
                // Si es horizontal, solo puede cortar Izq o Der
                if (b == Borde.Izquierda) return new Point(r.Left, p1.Y);
                if (b == Borde.Derecha) return new Point(r.Right, p1.Y);
                return p1; // No deberia ocurrir para Top/Bottom
            }

            // Calculo estandar con pendiente m
            float m = (float)(p2.Y - p1.Y) / (p2.X - p1.X);
            int x = 0, y = 0;

            if (b == Borde.Izquierda)
            {
                x = r.Left;
                y = (int)(p1.Y + m * (r.Left - p1.X));
            }
            else if (b == Borde.Derecha)
            {
                x = r.Right;
                y = (int)(p1.Y + m * (r.Right - p1.X));
            }
            else if (b == Borde.Abajo)
            {
                y = r.Bottom;
                x = (int)(p1.X + (r.Bottom - p1.Y) / m);
            }
            else if (b == Borde.Arriba)
            {
                y = r.Top;
                x = (int)(p1.X + (r.Top - p1.Y) / m);
            }

            return new Point(x, y);
        }
    }
}