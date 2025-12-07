using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos_Graficacion
{
    // =========================================================
    // 1. ALGORITMO LIANG-BARSKY (Paramétrico)
    // =========================================================
    public class CLiangBarsky
    {
        // Devuelve el estado para animación
        public IEnumerable<EstadoRecorte> RecortarAnimado(Point p1, Point p2, Rectangle rect)
        {
            float t0 = 0.0f;
            float t1 = 1.0f;
            int x1 = p1.X, y1 = p1.Y;
            int x2 = p2.X, y2 = p2.Y;
            int dx = x2 - x1;
            int dy = y2 - y1;

            // Definir los 4 bordes como desigualdades: p * t <= q
            // p1 = -dx, q1 = x1 - xmin (Izquierda)
            // p2 =  dx, q2 = xmax - x1 (Derecha)
            // p3 = -dy, q3 = y1 - ymin (Arriba) // Ojo con coordenadas de pantalla
            // p4 =  dy, q4 = ymax - y1 (Abajo)

            int[] p = new int[] { -dx, dx, -dy, dy };
            int[] q = new int[] { x1 - rect.Left, rect.Right - x1, y1 - rect.Top, rect.Bottom - y1 };

            yield return new EstadoRecorte(p1, p2, "Iniciando Liang-Barsky (t0=0, t1=1)", false);

            for (int i = 0; i < 4; i++)
            {
                string borde = i == 0 ? "Izq" : i == 1 ? "Der" : i == 2 ? "Top" : "Bottom";

                if (p[i] == 0) // Línea paralela al borde
                {
                    if (q[i] < 0)
                    {
                        yield return new EstadoRecorte(p1, p2, $"Paralela fuera de {borde}. Rechazo total.", true);
                        yield break; // Linea fuera
                    }
                }
                else
                {
                    float t = (float)q[i] / p[i];

                    if (p[i] < 0) // Línea entrando a la ventana
                    {
                        if (t > t1) { yield return new EstadoRecorte(p1, p2, "Rechazo (t > t1)", true); yield break; }
                        if (t > t0)
                        {
                            t0 = t;
                            yield return new EstadoRecorte(p1, p2, $"Recorte Entrando ({borde}): t0 = {t0:F2}", false);
                        }
                    }
                    else // Línea saliendo de la ventana
                    {
                        if (t < t0) { yield return new EstadoRecorte(p1, p2, "Rechazo (t < t0)", true); yield break; }
                        if (t < t1)
                        {
                            t1 = t;
                            yield return new EstadoRecorte(p1, p2, $"Recorte Saliendo ({borde}): t1 = {t1:F2}", false);
                        }
                    }
                }
            }

            // Cálculo de nuevos puntos
            int newX1 = x1 + (int)(t0 * dx);
            int newY1 = y1 + (int)(t0 * dy);
            int newX2 = x1 + (int)(t1 * dx);
            int newY2 = y1 + (int)(t1 * dy);

            Point pFinal1 = new Point(newX1, newY1);
            Point pFinal2 = new Point(newX2, newY2);

            yield return new EstadoRecorte(pFinal1, pFinal2, "Línea Recortada Final", true);
        }
    }

    // =========================================================
    // 2. ALGORITMO SUBDIVISIÓN DE PUNTO MEDIO
    // =========================================================
    public class CPuntoMedioRecorte
    {
        private CCohenSutherland _helper = new CCohenSutherland(); // Usamos su lógica de códigos

        public IEnumerable<EstadoRecorte> RecortarAnimado(Point p1, Point p2, Rectangle rect)
        {
            // La estrategia es: Si un punto está fuera, buscar binariamente la intersección
            // moviéndonos hacia el punto medio.

            // 1. Validar P1
            Point tempP1 = p1;
            Point tempP2 = p2;

            // Recortar P1 si está fuera
            foreach (var paso in Biseccion(tempP1, tempP2, rect, true))
            {
                tempP1 = paso.P1;
                yield return paso;
            }

            // Recortar P2 si está fuera (hacia el nuevo P1)
            foreach (var paso in Biseccion(tempP2, tempP1, rect, false)) // Notar inversión para procesar P2 como 'inicio'
            {
                tempP2 = paso.P1; // Recibimos el punto ajustado en P1 de la estructura
                yield return new EstadoRecorte(tempP1, tempP2, paso.Mensaje, paso.Terminado);
            }

            // Verificación final
            int c1 = _helper.CalcularCodigo(tempP1.X, tempP1.Y, rect);
            int c2 = _helper.CalcularCodigo(tempP2.X, tempP2.Y, rect);

            if (c1 == 0 && c2 == 0)
                yield return new EstadoRecorte(tempP1, tempP2, "Recorte Finalizado", true);
            else
                yield return new EstadoRecorte(tempP1, tempP2, "Línea totalmente fuera", true);
        }

        private IEnumerable<EstadoRecorte> Biseccion(Point start, Point end, Rectangle rect, bool ajustandoP1)
        {
            int codeStart = _helper.CalcularCodigo(start.X, start.Y, rect);
            int codeEnd = _helper.CalcularCodigo(end.X, end.Y, rect);

            // Si está dentro, no hacemos nada
            if (codeStart == 0) yield break;

            // Si ambos están fuera en la misma zona, rechazo total
            if ((codeStart & codeEnd) != 0)
            {
                yield return new EstadoRecorte(start, end, "Rechazo Trivial", true);
                yield break;
            }

            Point pm = start;
            Point pBusqueda = end;
            Point pFuera = start;

            // Bucle de aproximación (máximo 10 iteraciones para no colgar si hay error de precisión)
            // En teoría se detiene cuando la distancia es < 1 pixel

            string label = ajustandoP1 ? "P1" : "P2";

            for (int i = 0; i < 15; i++)
            {
                // Calcular Punto Medio
                pm = new Point((pFuera.X + pBusqueda.X) / 2, (pFuera.Y + pBusqueda.Y) / 2);

                int codeM = _helper.CalcularCodigo(pm.X, pm.Y, rect);

                // Visualización de la subdivisión
                Point pShow1 = ajustandoP1 ? pFuera : end;
                Point pShow2 = ajustandoP1 ? end : pFuera;
                yield return new EstadoRecorte(pShow1, pShow2, $"Bisección {label}: Buscando borde...", false);

                // Si la distancia es muy pequeña, terminamos
                if (Math.Abs(pFuera.X - pBusqueda.X) <= 1 && Math.Abs(pFuera.Y - pBusqueda.Y) <= 1)
                {
                    pm = pBusqueda; // Tomamos el punto seguro de adentro
                    break;
                }

                if (codeM != 0) // El medio sigue fuera, descartamos la mitad exterior
                {
                    pFuera = pm;
                    // codeStart = codeM;
                }
                else // El medio está dentro, acercamos el punto de búsqueda al borde
                {
                    pBusqueda = pm;
                }
            }

            // Devolvemos el punto encontrado en la posición P1 del struct
            yield return new EstadoRecorte(pm, end, $"Borde encontrado para {label}", false);
        }
    }
}