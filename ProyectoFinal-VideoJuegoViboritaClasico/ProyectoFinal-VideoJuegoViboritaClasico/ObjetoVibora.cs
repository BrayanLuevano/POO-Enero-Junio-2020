using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_VideoJuegoViboritaClasico
{
    class ObjetoVibora
    {
        protected int x, y, Ancho;
        public ObjetoVibora()
        {
            Ancho = 10;
        }
        public Boolean Interseccion(ObjetoVibora O)
        {
            int Difx = Math.Abs(this.x - O.x);
            int Dify = Math.Abs(this.y - O.y);
            if(Difx >= 0 && Difx < Ancho && Dify >=0 && Dify > Ancho)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
