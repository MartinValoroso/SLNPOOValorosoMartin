using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class AutoElectrico : Vehiculo
    {



        public double AutonomiaEnKm { get; set; }

        public string Puertas { get; set; }

        public AutoElectrico (double autonomiaEnKm, string puertas, string marca, string ruedas, string velocidadmaxima) : base(marca, ruedas, velocidadmaxima)
        {
            AutonomiaEnKm = autonomiaEnKm;
            Puertas = puertas;

        }

        public override string Acelerar()
        {
            return "El auto eléctrico esta acelerando";

        }

        public override string Frenar()
        {
            return "El auto eléctrico esta frenando";
        }

        public override string imprimir()
        {
            return base.imprimir() + $"\nEl auto tiene una autonomía de  : {AutonomiaEnKm}" + $"\nEl auto tiene {Puertas} puertas ";


        }
    }
}

