using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq; // Necesario para Min() y Max()

namespace Algoritmos_Graficacion
{
    public class CRelleno
    {
        public delegate bool EsColorValido(int x, int y);

        public IEnumerable<List<Point>> FloodFillAnimado(int xSemilla, int ySemilla, int gridW, int gridH, EsColorValido esMismoColor, bool es8Vecinos)
        {
            if (xSemilla < 0 || xSemilla >= gridW || ySemilla < 0 || ySemilla >= gridH) yield break;
            if (!esMismoColor(xSemilla, ySemilla)) yield break;

            Queue<Point> cola = new Queue<Point>();
            bool[,] visitado = new bool[gridW, gridH];

            cola.Enqueue(new Point(xSemilla, ySemilla));
            visitado[xSemilla, ySemilla] = true;

            int[] dx = es8Vecinos ? new int[] { 0, 1, 0, -1, 1, 1, -1, -1 } : new int[] { 0, 1, 0, -1 };
            int[] dy = es8Vecinos ? new int[] { -1, 0, 1, 0, -1, 1, 1, -1 } : new int[] { -1, 0, 1, 0 };

            List<Point> lote = new List<Point>();
            int tamanoLote = 1; // 1 para ver pixel por pixel lento

            while (cola.Count > 0)
            {
                Point actual = cola.Dequeue();
                lote.Add(actual);

                if (lote.Count >= tamanoLote)
                {
                    yield return new List<Point>(lote);
                    lote.Clear();
                }

                for (int i = 0; i < dx.Length; i++)
                {
                    int nx = actual.X + dx[i];
                    int ny = actual.Y + dy[i];

                    if (nx >= 0 && nx < gridW && ny >= 0 && ny < gridH)
                    {
                        if (!visitado[nx, ny] && esMismoColor(nx, ny))
                        {
                            visitado[nx, ny] = true;
                            cola.Enqueue(new Point(nx, ny));
                        }
                    }
                }
            }
            if (lote.Count > 0) yield return lote;
        }

        public IEnumerable<List<Point>> ScanLineAnimado(List<Point> poligono, int gridW, int gridH)
        {
            if (poligono == null || poligono.Count < 3) yield break;

            int yMin = poligono.Min(p => p.Y);
            int yMax = poligono.Max(p => p.Y);

            for (int y = yMin; y <= yMax; y++)
            {
                List<int> interseccionesX = new List<int>();
                int n = poligono.Count;

                for (int i = 0; i < n; i++)
                {
                    Point p1 = poligono[i];
                    Point p2 = poligono[(i + 1) % n];

                    // Ignorar lineas horizontales
                    if (p1.Y == p2.Y) continue;

                    if ((p1.Y <= y && p2.Y > y) || (p2.Y <= y && p1.Y > y))
                    {
                        float x = p1.X + (float)(y - p1.Y) / (p2.Y - p1.Y) * (p2.X - p1.X);
                        interseccionesX.Add((int)x);
                    }
                }

                interseccionesX.Sort();
                List<Point> linea = new List<Point>();

                for (int i = 0; i < interseccionesX.Count; i += 2)
                {
                    if (i + 1 >= interseccionesX.Count) break;
                    int xStart = interseccionesX[i];
                    int xEnd = interseccionesX[i + 1];

                    for (int x = xStart; x <= xEnd; x++)
                    {
                        if (x >= 0 && x < gridW && y >= 0 && y < gridH)
                            linea.Add(new Point(x, y));
                    }
                }
                if (linea.Count > 0) yield return linea;
            }
        }
    }
}