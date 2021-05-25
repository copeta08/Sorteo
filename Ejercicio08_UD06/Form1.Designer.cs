
namespace Ejercicio08_UD06
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
            this.bSorteo = new System.Windows.Forms.Button();
            this.bJugar = new System.Windows.Forms.Button();
            this.bResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSorteo
            // 
            this.bSorteo.Location = new System.Drawing.Point(62, 40);
            this.bSorteo.Name = "bSorteo";
            this.bSorteo.Size = new System.Drawing.Size(200, 39);
            this.bSorteo.TabIndex = 0;
            this.bSorteo.Text = "Realizar sorteo";
            this.bSorteo.UseVisualStyleBackColor = true;
            this.bSorteo.Click += new System.EventHandler(this.bSorteo_Click);
            // 
            // bJugar
            // 
            this.bJugar.Location = new System.Drawing.Point(62, 109);
            this.bJugar.Name = "bJugar";
            this.bJugar.Size = new System.Drawing.Size(200, 39);
            this.bJugar.TabIndex = 1;
            this.bJugar.Text = "Introducir números del jugador";
            this.bJugar.UseVisualStyleBackColor = true;
            this.bJugar.Click += new System.EventHandler(this.bJugar_Click);
            // 
            // bResultado
            // 
            this.bResultado.Location = new System.Drawing.Point(62, 180);
            this.bResultado.Name = "bResultado";
            this.bResultado.Size = new System.Drawing.Size(200, 39);
            this.bResultado.TabIndex = 2;
            this.bResultado.Text = "Resultado";
            this.bResultado.UseVisualStyleBackColor = true;
            this.bResultado.Click += new System.EventHandler(this.bResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 267);
            this.Controls.Add(this.bResultado);
            this.Controls.Add(this.bJugar);
            this.Controls.Add(this.bSorteo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Ejercicio 08";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSorteo;
        private System.Windows.Forms.Button bJugar;
        private System.Windows.Forms.Button bResultado;
    }
}

