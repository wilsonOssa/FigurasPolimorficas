using System.Drawing;

namespace FigurasPolimorficas
{
    public class Rectangulo : Figura
    {
        public float Ancho { get; set; }
        public float Alto { get; set; }

        public Rectangulo(Color color, Point posicion, float ancho, float alto) : base(color, posicion)
        {
            Ancho = ancho > 0 ? ancho : 50;
            Alto = alto > 0 ? alto : 30;
        }

        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawRectangle(pen, Posicion.X, Posicion.Y, Ancho, Alto);
            }
        }
    }
}