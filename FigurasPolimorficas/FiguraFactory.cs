using System;
using System.Drawing;

namespace FigurasPolimorficas
{
    public static class FiguraFactory
    {
        private const int TAMANO_BASE = 50;

        public static Figura CrearFigura(string tipo, Color color, Point posicion)
        {
            if (string.IsNullOrWhiteSpace(tipo))
                throw new ArgumentException("El tipo de figura no puede estar vacío.");

            switch (tipo.ToLower())
            {
                case "rectángulo":
                case "rectangulo":
                    return new Rectangulo(color, posicion, TAMANO_BASE * 1.6f, TAMANO_BASE);
                case "círculo":
                case "circulo":
                    return new Circulo(color, posicion, TAMANO_BASE);
                case "línea":
                case "linea":
                    return new Linea(color, posicion, new Point(posicion.X + TAMANO_BASE * 2, posicion.Y));
                case "triángulo":
                case "triangulo":
                    return new Triangulo(color, posicion, TAMANO_BASE);
                default:
                    throw new ArgumentException($"Tipo de figura no soportado: {tipo}");
            }
        }
    }
}