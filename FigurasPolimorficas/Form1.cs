using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FigurasPolimorficas
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>();  // Lista de figuras creadas
        private Color colorSeleccionado = Color.Black;  // Color por defecto

        public Form1()
        {
            InitializeComponent();

            // Agregar opciones al ComboBox
            cmbFigura.Items.Add("Rectángulo");
            cmbFigura.Items.Add("Círculo");
            cmbFigura.Items.Add("Línea");
            cmbFigura.Items.Add("Triángulo");
            cmbFigura.SelectedIndex = 0;  // Seleccionar el primer elemento por defecto

            // Enlazar el evento Paint del PictureBox
            pictureBox1.Paint += pictureBox1_Paint;
        }

        // Seleccionar un color con el ColorDialog
        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSeleccionado = colorDialog1.Color;
                pictureBox1.BackColor = colorSeleccionado;  // Cambia el fondo al color seleccionado
            }
        }

        // Crear una nueva figura y redibujar
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtPosX.Text, out int x) || !int.TryParse(txtPosY.Text, out int y))
                {
                    MessageBox.Show("Ingrese coordenadas válidas (números enteros).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tipoFigura = cmbFigura.SelectedItem.ToString();
                Figura nuevaFigura = FiguraFactory.CrearFigura(tipoFigura, colorSeleccionado, new Point(x, y));

                if (nuevaFigura != null)
                {
                    figuras.Add(nuevaFigura);
                    txtContador.Text = figuras.Count.ToString();  // Actualizar contador
                    pictureBox1.Refresh();  // Forzar el redibujado
                }
                else
                {
                    MessageBox.Show("Error al crear la figura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Redibujar el PictureBox
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);  // Limpiar el área de dibujo

            foreach (var figura in figuras)
            {
                figura.Dibujar(g);
            }
        }
    }
}
