namespace PresentacionVehiculo1
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnQuitarRemolque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(221, 95);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(333, 125);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar Camion";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuitarRemolque
            // 
            this.btnQuitarRemolque.Location = new System.Drawing.Point(604, 101);
            this.btnQuitarRemolque.Name = "btnQuitarRemolque";
            this.btnQuitarRemolque.Size = new System.Drawing.Size(333, 113);
            this.btnQuitarRemolque.TabIndex = 1;
            this.btnQuitarRemolque.Text = "Quitar Remolque";
            this.btnQuitarRemolque.UseVisualStyleBackColor = true;
            this.btnQuitarRemolque.Click += new System.EventHandler(this.QuitarRemolque);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2194, 780);
            this.Controls.Add(this.btnQuitarRemolque);
            this.Controls.Add(this.btnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnQuitarRemolque;
    }
}

