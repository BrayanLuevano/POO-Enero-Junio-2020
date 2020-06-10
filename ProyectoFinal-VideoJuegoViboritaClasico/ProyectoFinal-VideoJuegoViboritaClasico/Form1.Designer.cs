namespace ProyectoFinal_VideoJuegoViboritaClasico
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
            this.components = new System.ComponentModel.Container();
            this.VideoJuegoViborita = new System.Windows.Forms.PictureBox();
            this.PuntosDePartida = new System.Windows.Forms.Label();
            this.IntervaloTiempo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoJuegoViborita)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoJuegoViborita
            // 
            this.VideoJuegoViborita.Location = new System.Drawing.Point(-1, 0);
            this.VideoJuegoViborita.Name = "VideoJuegoViborita";
            this.VideoJuegoViborita.Size = new System.Drawing.Size(800, 430);
            this.VideoJuegoViborita.TabIndex = 0;
            this.VideoJuegoViborita.TabStop = false;
            // 
            // PuntosDePartida
            // 
            this.PuntosDePartida.AutoSize = true;
            this.PuntosDePartida.BackColor = System.Drawing.Color.Aquamarine;
            this.PuntosDePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntosDePartida.Location = new System.Drawing.Point(481, 441);
            this.PuntosDePartida.Name = "PuntosDePartida";
            this.PuntosDePartida.Size = new System.Drawing.Size(32, 33);
            this.PuntosDePartida.TabIndex = 2;
            this.PuntosDePartida.Text = "0";
            // 
            // IntervaloTiempo
            // 
            this.IntervaloTiempo.Enabled = true;
            this.IntervaloTiempo.Tick += new System.EventHandler(this.IntervaloTiempo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puntaje de partida actual:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PuntosDePartida);
            this.Controls.Add(this.VideoJuegoViborita);
            this.Name = "Form1";
            this.Text = "Proyecto Final - VideoJuego  Viborita Clasico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.VideoJuegoViborita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VideoJuegoViborita;
        private System.Windows.Forms.Label PuntosDePartida;
        private System.Windows.Forms.Timer IntervaloTiempo;
        private System.Windows.Forms.Label label1;
    }
}

