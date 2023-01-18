namespace PresentacionVehiculo
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
            this.btnMostrarCamion = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnQuitarRemolque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarCamion
            // 
            this.btnMostrarCamion.Location = new System.Drawing.Point(156, 72);
            this.btnMostrarCamion.Name = "btnMostrarCamion";
            this.btnMostrarCamion.Size = new System.Drawing.Size(385, 115);
            this.btnMostrarCamion.TabIndex = 0;
            this.btnMostrarCamion.Text = "Mostrar Camion";
            this.btnMostrarCamion.UseVisualStyleBackColor = true;
            this.btnMostrarCamion.Click += new System.EventHandler(this.btnMostrarCamion_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(156, 228);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(385, 115);
            this.btnFrenar.TabIndex = 1;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(156, 395);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(385, 115);
            this.btnAcelerar.TabIndex = 2;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarRemolque
            // 
            this.btnQuitarRemolque.Location = new System.Drawing.Point(156, 544);
            this.btnQuitarRemolque.Name = "btnQuitarRemolque";
            this.btnQuitarRemolque.Size = new System.Drawing.Size(385, 115);
            this.btnQuitarRemolque.TabIndex = 3;
            this.btnQuitarRemolque.Text = "Quitar Remolque";
            this.btnQuitarRemolque.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2172, 922);
            this.Controls.Add(this.btnQuitarRemolque);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.btnFrenar);
            this.Controls.Add(this.btnMostrarCamion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarCamion;
        private System.Windows.Forms.Button btnFrenar;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnQuitarRemolque;
    }
}

