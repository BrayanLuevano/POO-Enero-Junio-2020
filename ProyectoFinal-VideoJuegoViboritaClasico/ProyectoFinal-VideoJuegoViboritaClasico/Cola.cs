using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_VideoJuegoViboritaClasico
{
    class Cola : ObjetoVibora
    {
        Cola Siguiente;
        //Constructor
        public Cola(int x, int y)
        {
            this.x = x;
            this.y = y;
            Siguiente = null;
        }

        public void Dibujar(Graphics G)
        {
            if (Siguiente != null)
            {
                Siguiente.Dibujar(G);
            }
            G.FillRectangle(new SolidBrush(Color.DarkGreen), this.x, this.y, this.Ancho, this.Ancho);
        }

        public void SetEje(int x, int y)
        {
            if(Siguiente != null)
            {
                Siguiente.SetEje(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }

        public void Meter()
        {
            if (Siguiente == null)
            {
                Siguiente = new Cola(this.x, this.y);
            }
            else
            {
                Siguiente.Meter();
            }
        }

        public int DevolX()
        {
            return this.x;
        }

        public int DevolY()
        {
            return this.y;
        }
        public Cola VerSiguiente()
        {
            return Siguiente;
        }
    }
}
