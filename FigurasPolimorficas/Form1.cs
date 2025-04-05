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
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configurar ComboBox
            cmbFigura.Items.AddRange(new string[] { "Rectángulo", "Círculo", "Línea", "Triángulo" });
            cmbFigura.SelectedIndex = 0;

            // Configurar PictureBox de color
            pictureBoxcolor.BackColor = colorSeleccionado;
            pictureBoxcolor.BorderStyle = BorderStyle.FixedSingle;

            // Configurar PictureBox de dibujo
            pictureBoxcolor.BackColor = Color.White;
            pictureBoxcolor.BorderStyle = BorderStyle.FixedSingle;

            // Configurar TextBox de contador
            txtContador.ReadOnly = true;
            txtContador.Text = "0";

            // Conectar eventos
            btnCrear.Click += btnCrear_Click;
            pictureBoxcolor.Click += pictureBoxColor_Click;
            pictureBoxcolor.Paint += pictureBox1_Paint;
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSeleccionado = colorDialog1.Color;
                pictureBoxcolor.BackColor = colorSeleccionado;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCoordenadas(out int x, out int y))
                    return;

                string tipoFigura = cmbFigura.SelectedItem.ToString();
                Figura nuevaFigura = FiguraFactory.CrearFigura(tipoFigura, colorSeleccionado, new Point(x, y));

                if (nuevaFigura != null)
                {
                    figuras.Add(nuevaFigura);
                    txtContador.Text = figuras.Count.ToString();
                    pictureBoxcolor.Invalidate();
                }
                else
                {
                    MessageBox.Show("Error al crear la figura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCoordenadas(out int x, out int y)
        {
            x = y = 0;

            if (!int.TryParse(txtPosX.Text, out x) || !int.TryParse(txtPosY.Text, out y))
            {
                MessageBox.Show("Ingrese coordenadas válidas (números enteros).", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (x < 0 || y < 0)
            {
                MessageBox.Show("Las coordenadas no pueden ser negativas.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.White);

            foreach (var figura in figuras)
            {
                figura.Dibujar(e.Graphics);
            }
        }
    }
}