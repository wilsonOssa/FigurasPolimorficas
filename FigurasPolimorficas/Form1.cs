using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FigurasPolimorficas
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>();
        private Color colorSeleccionado = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSeleccionado = colorDialog1.Color;
                pictureBoxColor.BackColor = colorSeleccionado;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtPosX.Text);
            int y = int.Parse(txtPosY.Text);
            string tipoFigura = cmbFigura.SelectedItem.ToString();

            Figura nuevaFigura = FiguraFactory.CrearFigura(tipoFigura, colorSeleccionado, new Point(x, y));
            if (nuevaFigura != null)
            {
                figuras.Add(nuevaFigura);
                txtContador.Text = figuras.Count.ToString();
                pictureBoxColor.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var figura in figuras)
            {
                figura.Dibujar(e.Graphics);
            }
        }
    }
}
