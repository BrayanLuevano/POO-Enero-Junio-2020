using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_VideoJuegoViboritaClasico
{
    class ComidaVibora : ObjetoVibora
    {
        public ComidaVibora()
        {
            this.x = GenerarComidaAleatoria(80);
            this.y = GenerarComidaAleatoria(43);
        }

        public void Dibujar(Graphics G)
        {
            G.FillRectangle(new SolidBrush(Color.DarkGreen), this.x, this.y, this.Ancho, this.Ancho);
        }

        public void Colocar()
        {
            this.x = GenerarComidaAleatoria(80);
            this.y = GenerarComidaAleatoria(43);
        }

        public int GenerarComidaAleatoria(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
    }
}
