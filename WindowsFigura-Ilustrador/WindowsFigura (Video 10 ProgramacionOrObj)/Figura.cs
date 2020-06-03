using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFigura__Video_10_ProgramacionOrObj_
{
    abstract class Figura
    {
        protected Pen Pluma;
        public Color _Color;
        public Color Color
        {
            get => _Color;
            set
            {
                _Color = value;
                Brocha.Color = value;
            }
        }
        protected SolidBrush Brocha;
        protected int x, y;
        protected int Ancho, Alto;

        public Figura(int x, int y, int Ancho, int Alto)
        {
            this.x = x;
            this.y = y;
            this.Ancho = Ancho;
            this.Alto = Alto;
            _Color = Color.Yellow;
            Pluma = new Pen(Color);
            Brocha = new SolidBrush(Color.DeepSkyBlue);
        }

        abstract public void Dibuja(Form forma);
        public bool EstaContenido(int A, int B)
        {
            return (A >= x && A <= x + Ancho) && (B >= y && B <= y + Alto);
        }
    }

    class Rectangulo : Figura
    {

        public Rectangulo(int x, int y, int Ancho, int Alto): base(x, y, Ancho, Alto)
        {

        }
        public override void Dibuja(Form Forma)
        {
            Graphics graphics = Forma.CreateGraphics();

            //Pen, Brush, Color
            graphics.FillRectangle(Brocha, x, y, Ancho, Alto);
            graphics.DrawRectangle(Pluma, x, y, Ancho, Alto);
        }
    }

    class Elipse : Figura
    {

        public Elipse(int x, int y, int Ancho, int Alto) : base(x, y, Ancho, Alto)
        {

        }
        public override void Dibuja(Form Forma)
        {
            Graphics graphics = Forma.CreateGraphics();

            //Pen, Brush, Color
            graphics.FillEllipse(Brocha, x, y, Ancho, Alto);
            graphics.DrawEllipse(Pluma, x, y, Ancho, Alto);
        }
    }

}