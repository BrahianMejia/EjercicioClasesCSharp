using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosCentigradosAFarenheit
{
    class Temperatura
    {
        private double grados;

        public void setGrados(double valor)
        {
            this.grados = valor;
        }

        public double getGrados()
        {
            return this.grados;
        }

        public double calculo()
        {
            return ((this.getGrados() * 9/5) + (32));
        }

    }
}
