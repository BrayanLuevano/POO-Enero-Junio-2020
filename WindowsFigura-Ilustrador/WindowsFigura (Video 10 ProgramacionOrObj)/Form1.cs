using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFigura__Video_10_ProgramacionOrObj_
{
    enum EstadoActual { Seleccionando, Rectangulo, Elipse }
    public partial class Form1 : Form
    {
        List<Figura> Figuras = new List<Figura>();
        EstadoActual estado = EstadoActual.Seleccionando;
        bool Dibujando = false;
        int temp_x, temp_y;
        bool moving = false;
        Pen p = new Pen(Color.Red, 3);
        public Form1()
        {
            InitializeComponent();
            Figuras = new List<Figura>();
        }

        Figura GetFigura(int X, int Y)
        {
            foreach(Figura F in Figuras)
            {
                if(F.EstaContenido(X,Y))
                {
                    return F;
                }
            }

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.label1.Text = string.Format("{0}, {1}", e.X, e.Y);

            if (e.Button == MouseButtons.Left && this.estado == EstadoActual.Seleccionando)
            {
                Figura Seleccionada = null;
                Seleccionada = GetFigura(e.X, e.Y);

                 MessageBox.Show(Seleccionada.Color.ToString());

                if(Seleccionada != null)
                {
                    Seleccionada.Color = ForeColor = colorDialog1.Color; ;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Elipse E = new Elipse(e.X, e.Y, 100, 100);
                E.Dibuja(this);
                Figuras.Add(E);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura F in Figuras)
                F.Dibuja(this);
        }


        private void Elipse_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.Elipse;
        }

        private void Rectangulo_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.Rectangulo;
        }

        private void Seleccion_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.Seleccionando;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

            }
            button1.BackColor = colorDialog1.Color;
            p.Color = colorDialog1.Color;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            if (estado == EstadoActual.Rectangulo && Dibujando == true)
            {
                Rectangulo R = new Rectangulo(temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
                R.Dibuja(this);
                Figuras.Add(R);
                Dibujando = false;
            } else

            if (estado == EstadoActual.Elipse && Dibujando == true)
            {
                Elipse Elipse = new Elipse(temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
                Figuras.Add(Elipse);
                Elipse.Dibuja(this);
                Dibujando = false;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (estado == EstadoActual.Rectangulo && Dibujando == true)
            {
                Graphics graphics = CreateGraphics();
                graphics.DrawRectangle(new Pen(Color.Black), temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((estado == EstadoActual.Rectangulo || estado == EstadoActual.Elipse) && Dibujando == false)
            {
                Dibujando = true;
                temp_x = e.X;
                temp_y = e.Y;
                moving = true;
            }
        }
    }
}