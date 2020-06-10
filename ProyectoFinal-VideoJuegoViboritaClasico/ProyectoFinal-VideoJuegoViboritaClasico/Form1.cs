using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_VideoJuegoViboritaClasico
{
    public partial class Form1 : Form
    {
        Cola CabezaVibora;
        ComidaVibora Comida;
        int PuntajePartida = 0;
        Graphics G;
        int xDir = 0, yDir = 0;
        int Cuadro = 10;
        Boolean Ejex = true, Ejey = true;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            CabezaVibora = new Cola(10, 10);
            Comida = new ComidaVibora();
            G = VideoJuegoViborita.CreateGraphics();
        }

        //Cambia la direccion de la vivora(Sube, Baje, Izquierda, Derecha)
        public  void Movimiento()
        {
            CabezaVibora.SetEje(CabezaVibora.DevolX() + xDir, CabezaVibora.DevolY() + yDir);
        }

        private void IntervaloTiempo_Tick(object sender, EventArgs e)
        {
            G.Clear(Color.White);
            CabezaVibora.Dibujar(G);
            Comida.Dibujar(G);
            Movimiento();
            ChoqueCuerpo();
            ChoquePared();
            if (CabezaVibora.Interseccion(Comida))
            {
                Comida.Colocar();
                CabezaVibora.Meter();
                PuntajePartida++;
                PuntosDePartida.Text = PuntajePartida.ToString();
            }
        }

        public void ChoquePared()
        {
            if (CabezaVibora.DevolX() < 0 || CabezaVibora.DevolX() > 790 || CabezaVibora.DevolY() < 0 || CabezaVibora.DevolY() > 420)
            {
                FinJuego();
            }
        }

        public void FinJuego()
        {
            PuntajePartida = 0;
            PuntosDePartida.Text = "0";
            Ejex = true;
            Ejey = true;
            xDir = 0;
            yDir = 0;
            CabezaVibora = new Cola(10, 10);
            Comida = new ComidaVibora();
            MessageBox.Show("Has Perdido la partida");
        }
        public void ChoqueCuerpo()
        {
            Cola Temp;
            try
            {
                Temp = CabezaVibora.VerSiguiente().VerSiguiente();
            }
            catch (Exception Error)
            {
                Temp = null;
            }
            while (Temp != null)
            {
                if (CabezaVibora.Interseccion(Temp))
                {
                    FinJuego();
                }
                else
                {
                    Temp = Temp.VerSiguiente();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Ejex)
            {
                if(e.KeyCode == Keys.Up)
                {
                    yDir = - Cuadro;
                    xDir = 0;

                    //Deshabilitar Eje x
                    Ejex = false;

                    //Habilitar Eje y
                    Ejey = true;
                }
                if(e.KeyCode == Keys.Down)
                {
                    //Habilitar Direccion de y
                    yDir = Cuadro;
                    //Deshabilitar Direccion de x
                    xDir = 0;

                    //Deshabilitar Eje x
                    Ejex = false;

                    //Habilitar Eje y
                    Ejey = true;
                }
            }
            if (Ejey)
            {
                if(e.KeyCode == Keys.Right)
                {
                    //Deshabilitar Direccion de y
                    yDir = 0;

                    //Habilitar Direccion de x
                    xDir = Cuadro;

                    //Habilitar Eje x
                    Ejex = true;

                    //Deshabilitar Eje y
                    Ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    //Deshabilitar Direccion de y
                    yDir = 0;

                    //Habilitar Direccion de x
                    xDir = - Cuadro;

                    //Habilitar Eje x
                    Ejex = true;

                    //Deshabilitar Eje y
                    Ejey = false;
                }
            }
        }
    }
}
