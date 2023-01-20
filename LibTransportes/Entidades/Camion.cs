using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion : Vehiculo
    {
        public Remolque Remolque { get; set; }

        public double PesoCargaMax { get; set; }
        public string CantAcoplados { get; set; }

        public Camion (double pesoCargaMax, string cantacoplados, string marca, string ruedas, string velocidadmax) :base (marca,ruedas,velocidadmax)
        {
            PesoCargaMax= pesoCargaMax;
            CantAcoplados = cantacoplados;
            




        }


        public override string Acelerar()
        {
            return "El camion esta acelerando"; 

        }

        public override string Frenar()
        {
            return "El camion esta frenando";
        }

        public string QuitarRemolque ()
        {
            Remolque = null;
            return "el remolque ha sido quitado";
        }

        public override string ToString()
        {
            return base.imprimir() + $"Peso Carga máxima : {PesoCargaMax}\n" +
                   $"Cant Acoplados : {CantAcoplados}\n";

                /*$"Peso Carga máxima : {PesoCargaMax}\n" +
                   $"Cant Acoplados : {CantAcoplados}\n" +
                   $"Marca: {Marca}\n" +
                   $"Ruedas: {Ruedas}\n" +
                   $"Vel. Máxima: {Velocidadmax}";*/

        }
    }

}
