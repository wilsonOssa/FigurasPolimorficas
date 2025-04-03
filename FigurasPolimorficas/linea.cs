using FigurasPolimorficas;
using System.Drawing;

public class Linea : Figura
{
    public Point Fin { get; set; }

    public Linea(Color color, Point inicio, Point fin) : base(color, inicio)
    {
        Fin = fin;
    }

    public override void Dibujar(Graphics g)
    {
        using (Pen pen = new Pen(Color, 2))
        {
            g.DrawLine(pen, Posicion, Fin);
        }
    }
}
