using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases_abstractas.figuras
{
    public abstract class Figura:IFigura
    {
        protected double area;
        protected double volumen;
        protected String texto;

        public override abstract void calcular();

        public override abstract void calcularVolumen();

        public override abstract void pintar();

        public override void cambiarTexto(String ntexto){
            this.texto = ntexto;
        }
    }
}
