
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Mdi_Clases
{
    [Serializable]
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Apellido { get; set; } 
        // el signo de pregunTa al lado del string es para que
        // acepta null y no marque warning en el constructor


        public DateTime FechaNacimiento { get; set; }
        public Direccion Direccion { get; set; }

        [XmlIgnore]
        [JsonIgnore]
        public int Edad
        {
            get { return CalcularEdad(FechaNacimiento); }
        }
        [XmlIgnore]
        [JsonIgnore]
        public string DomicilioCompleto
        {
            get { return Direccion != null ? Direccion.ToString() : ""; }
        }

        public Persona()
        {
            Direccion = new Direccion();
        }

        public Persona(int id, string nombre, string apellido, DateTime fechaNacimiento, Direccion direccion)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
                edad--;

            return edad;
        }

        public override string ToString()
        {
            return $"{Id} - {Nombre} {Apellido} - {Edad} años - {Direccion}";
        }
    }
}