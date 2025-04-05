using System.Drawing;

namespace FigurasPolimorficas
{
    public class Circulo : Figura
    {
        public float Radio { get; set; }

        public Circulo(Color color, Point posicion, float radio) : base(color, posicion)
        {
            Radio = radio > 0 ? radio : 25;
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawEllipse(pen, Posicion.X - Radio, Posicion.Y - Radio, Radio * 2, Radio * 2);
            }
        }
    }
}