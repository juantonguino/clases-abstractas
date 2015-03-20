using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases_abstractas.figuras
{
    interface IFigura
    {
        public void calcular();
        public void calcularVolumen();
        public void pintar();
        public void cambiarTexto(String texto);
    }
}
