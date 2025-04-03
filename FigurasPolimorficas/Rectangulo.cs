using System.Drawing;

namespace FigurasPolimorficas
{
    public class Rectangulo : Figura
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Rectangulo(Color color, Point posicion, int ancho, int alto) : base(color, posicion)
        {
            Ancho = ancho;
            Alto = alto;
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
