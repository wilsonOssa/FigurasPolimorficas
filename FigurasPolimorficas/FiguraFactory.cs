using System;
using System.Drawing;

namespace FigurasPolimorficas
{
    public static class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Color color, Point posicion)
        {
            switch (tipo)
            {
                case "Círculo":
                    return new Circulo(color, posicion, 50);
                case "Línea":
                    return new Linea(color, posicion, new Point(posicion.X + 100, posicion.Y));
                case "Triángulo":
                    return new Triangulo(color, posicion, 50);
                default:
                    return null;
            }
        }
    }
}
