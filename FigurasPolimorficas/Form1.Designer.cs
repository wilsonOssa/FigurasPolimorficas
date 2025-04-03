namespace FigurasPolimorficas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Location = new System.Drawing.Point(12, 92);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(171, 21);
            this.cmbFigura.TabIndex = 0;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(12, 131);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(100, 20);
            this.txtPosX.TabIndex = 1;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(13, 170);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 20);
            this.txtPosY.TabIndex = 2;
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(13, 208);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(100, 20);
            this.txtContador.TabIndex = 3;
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Location = new System.Drawing.Point(202, 76);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(491, 348);
            this.pictureBoxColor.TabIndex = 4;
            this.pictureBoxColor.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(713, 389);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.cmbFigura);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

