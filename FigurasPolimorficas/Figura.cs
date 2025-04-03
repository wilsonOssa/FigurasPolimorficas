using System;
using System.Drawing;

namespace FigurasPolimorficas
{
    public abstract class Figura
    {
        public Color Color { get; set; }
        public Point Posicion { get; set; }

        public Figura(Color color, Point posicion)
        {
            Color = color;
            Posicion = posicion;
        }

        public abstract void Dibujar(Graphics g);
    }
}
