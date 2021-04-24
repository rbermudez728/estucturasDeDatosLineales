using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatosArboles
{
    public class Impuesto
    {
        public Cliente cliente { set; get; }
        public Vehiculo vehiculo { set; get; }
        public decimal impuestoCalculado { set; get; }

        public Impuesto(Cliente cliente, Vehiculo vehiculo)
        {
            this.cliente = cliente;
            this.vehiculo = vehiculo;

            impuestoCalculado = calcularImpuesto(vehiculo.avaluoComercial);
        }

        public decimal calcularImpuesto(Decimal avaluo) {

            Decimal valorCalculado = 0m;
            Decimal factor0_025 = 0.025m;
            Decimal factor0_04 = 0.04m;


            if (avaluo <= 39000000)
            {

                valorCalculado = avaluo * factor0_025;
            }
            else {

                valorCalculado = avaluo * factor0_04;
            }

            return valorCalculado;
        }
    }
}
