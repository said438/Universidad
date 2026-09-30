using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mdi_Clases
{
    [Serializable]
    public class Direccion
    {
        public string? Calle { get; set; }
        public string? Numero { get; set; }
        public string? Ciudad { get; set; }
        public string? Provincia { get; set; }

        public Direccion()
        {
        }

        public Direccion(string calle, string numero, string ciudad, string provincia)
        {
            Calle = calle;
            Numero = numero;
            Ciudad = ciudad;
            Provincia = provincia;
        }

        public override string ToString()
        {
            return $"{Calle} {Numero}, {Ciudad}, {Provincia}";
        }
    }
}
