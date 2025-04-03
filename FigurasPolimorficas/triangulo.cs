using FigurasPolimorficas;
using System.Drawing;

public class Triangulo : Figura
{
    public int Lado { get; set; }

    public Triangulo(Color color, Point posicion, int lado) : base(color, posicion)
    {
        Lado = lado;
    }

    public override void Dibujar(Graphics g)
    {
        using (Pen pen = new Pen(Color, 2))
        {
            Point[] puntos =
            {
                Posicion,
                new Point(Posicion.X + Lado, Posicion.Y),
                new Point(Posicion.X + (Lado / 2), Posicion.Y - Lado)
            };
            g.DrawPolygon(pen, puntos);
        }
    }
}
