using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class impuestos
    {

        double iva = 21.00;
         double valorBruto = 120.50;
         double valorNeto;
       

        public double calcularImpuesto(double valor)
        {
           

            return valor + ((valor / 100)*iva);
        }

    }
}
