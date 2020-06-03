namespace WindowsFigura__Video_10_ProgramacionOrObj_
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
            this.label1 = new System.Windows.Forms.Label();
            this.Elipse = new System.Windows.Forms.Button();
            this.Rectangulo = new System.Windows.Forms.Button();
            this.Seleccion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Elipse
            // 
            this.Elipse.Location = new System.Drawing.Point(169, 12);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(71, 36);
            this.Elipse.TabIndex = 1;
            this.Elipse.Text = "Elipse";
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.Click += new System.EventHandler(this.Elipse_Click);
            // 
            // Rectangulo
            // 
            this.Rectangulo.Location = new System.Drawing.Point(89, 12);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(74, 36);
            this.Rectangulo.TabIndex = 2;
            this.Rectangulo.Text = "Rectangulo";
            this.Rectangulo.UseVisualStyleBackColor = true;
            this.Rectangulo.Click += new System.EventHandler(this.Rectangulo_Click);
            // 
            // Seleccion
            // 
            this.Seleccion.Location = new System.Drawing.Point(9, 12);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(74, 36);
            this.Seleccion.TabIndex = 3;
            this.Seleccion.Text = "Seleccione Figura:";
            this.Seleccion.UseVisualStyleBackColor = true;
            this.Seleccion.Click += new System.EventHandler(this.Seleccion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(564, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Panel de Colores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Seleccion);
            this.Controls.Add(this.Rectangulo);
            this.Controls.Add(this.Elipse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Elipse;
        private System.Windows.Forms.Button Rectangulo;
        private System.Windows.Forms.Button Seleccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}