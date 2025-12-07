using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    // Estructura para reportar el estado de la animación paso a paso
    public struct EstadoRecorte
    {
        public Point P1;
        public Point P2;
        public string Mensaje;
        public bool Terminado; // Indica si se aceptó o rechazó totalmente

        public EstadoRecorte(Point p1, Point p2, string msg, bool fin)
        {
            P1 = p1; P2 = p2; Mensaje = msg; Terminado = fin;
        }
    }

    public class CCohenSutherland
    {
        // Constantes de códigos de región
        public const int INSIDE = 0; // 0000
        public const int LEFT = 1;   // 0001
        public const int RIGHT = 2;  // 0010
        public const int BOTTOM = 4; // 0100
        public const int TOP = 8;    // 1000

        // Límites de la ventana de recorte
        private int xMin, yMin, xMax, yMax;

        // Calcula el código de región para un punto (x, y)
        public int CalcularCodigo(int x, int y, Rectangle ventana)
        {
            int code = INSIDE;

            if (x < ventana.Left) code |= LEFT;
            else if (x > ventana.Right) code |= RIGHT;

            if (y < ventana.Top) code |= TOP; // Nota: En GDI+, Y crece hacia abajo. Top es menor Y.
            else if (y > ventana.Bottom) code |= BOTTOM;

            return code;
        }

        // Método principal que devuelve la secuencia de recorte paso a paso
        public IEnumerable<EstadoRecorte> RecortarAnimado(Point p1, Point p2, Rectangle ventana)
        {
            // Asignar límites para facilitar cálculos
            xMin = ventana.Left;
            yMin = ventana.Top;
            xMax = ventana.Right;
            yMax = ventana.Bottom;

            int code1 = CalcularCodigo(p1.X, p1.Y, ventana);
            int code2 = CalcularCodigo(p2.X, p2.Y, ventana);

            bool accept = false;

            yield return new EstadoRecorte(p1, p2, $"Inicio: P1({Convert.ToString(code1, 2).PadLeft(4, '0')}), P2({Convert.ToString(code2, 2).PadLeft(4, '0')})", false);

            while (true)
            {
                // Caso 1: Aceptación Trivial (Ambos dentro)
                if ((code1 | code2) == 0)
                {
                    accept = true;
                    yield return new EstadoRecorte(p1, p2, "Aceptación Trivial (Ambos dentro)", true);
                    break;
                }
                // Caso 2: Rechazo Trivial (Ambos fuera en la misma zona)
                else if ((code1 & code2) != 0)
                {
                    yield return new EstadoRecorte(p1, p2, "Rechazo Trivial (Fuera misma zona)", true);
                    break;
                }
                // Caso 3: Necesita Recorte
                else
                {
                    int codeOut = (code1 != 0) ? code1 : code2;
                    int x = 0, y = 0;

                    // Fórmulas de intersección:
                    // y = y1 + slope * (x - x1)
                    // x = x1 + (1/slope) * (y - y1)

                    // Nota: Usamos double para precisión intermedia

                    if ((codeOut & TOP) != 0)
                    { // Punto encima de la ventana
                        x = p1.X + (p2.X - p1.X) * (yMin - p1.Y) / (p2.Y - p1.Y);
                        y = yMin;
                    }
                    else if ((codeOut & BOTTOM) != 0)
                    { // Punto debajo de la ventana
                        x = p1.X + (p2.X - p1.X) * (yMax - p1.Y) / (p2.Y - p1.Y);
                        y = yMax;
                    }
                    else if ((codeOut & RIGHT) != 0)
                    { // Punto a la derecha
                        y = p1.Y + (p2.Y - p1.Y) * (xMax - p1.X) / (p2.X - p1.X);
                        x = xMax;
                    }
                    else if ((codeOut & LEFT) != 0)
                    { // Punto a la izquierda
                        y = p1.Y + (p2.Y - p1.Y) * (xMin - p1.X) / (p2.X - p1.X);
                        x = xMin;
                    }

                    // Actualizar el punto que estaba fuera
                    if (codeOut == code1)
                    {
                        p1 = new Point(x, y);
                        code1 = CalcularCodigo(p1.X, p1.Y, ventana);
                        yield return new EstadoRecorte(p1, p2, "Recortando P1...", false);
                    }
                    else
                    {
                        p2 = new Point(x, y);
                        code2 = CalcularCodigo(p2.X, p2.Y, ventana);
                        yield return new EstadoRecorte(p1, p2, "Recortando P2...", false);
                    }
                }
            }
        }
    }
}