
namespace ServidorEjercicio_4._1
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
            this.Ejecutar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.TextBox();
            this.NombrePalindro = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Ejecutar
            // 
            this.Ejecutar.Location = new System.Drawing.Point(278, 278);
            this.Ejecutar.Name = "Ejecutar";
            this.Ejecutar.Size = new System.Drawing.Size(193, 70);
            this.Ejecutar.TabIndex = 0;
            this.Ejecutar.Text = "Iniciar";
            this.Ejecutar.UseVisualStyleBackColor = true;
            this.Ejecutar.Click += new System.EventHandler(this.Ejecutar_Click);
            // 
            // Datos
            // 
            this.Datos.Location = new System.Drawing.Point(137, 82);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(160, 26);
            this.Datos.TabIndex = 1;
            // 
            // NombrePalindro
            // 
            this.NombrePalindro.AutoSize = true;
            this.NombrePalindro.Location = new System.Drawing.Point(137, 154);
            this.NombrePalindro.Name = "NombrePalindro";
            this.NombrePalindro.Size = new System.Drawing.Size(329, 24);
            this.NombrePalindro.TabIndex = 2;
            this.NombrePalindro.TabStop = true;
            this.NombrePalindro.Text = "Saber si el nombre introducido es palindro";
            this.NombrePalindro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombrePalindro);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Ejecutar);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejecutar;
        private System.Windows.Forms.TextBox Datos;
        private System.Windows.Forms.RadioButton NombrePalindro;
    }
}

