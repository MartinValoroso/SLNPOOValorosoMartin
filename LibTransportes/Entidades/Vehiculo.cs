using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Vehiculo
    {

        public Vehiculo(string marca, string ruedas, string velocidadmax)
        {
            Marca = marca;
            Ruedas = ruedas;
            Velocidadmax = velocidadmax;
        }

        public string Marca { get; set; }
        public string Ruedas { get; set; }
        public string Velocidadmax { get; set; }

        public abstract string Acelerar();
        public abstract string Frenar();

        public virtual string imprimir()
        {
            return $"Marca: {Marca}\n" +
                   $"Ruedas: {Ruedas}\n" +
                   $"Velocidad Máxima : {Velocidadmax}\n";
        }
    }
}

