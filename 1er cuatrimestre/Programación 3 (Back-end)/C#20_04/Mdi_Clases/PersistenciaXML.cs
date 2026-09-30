using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Mdi_Clases
{
    public class PersistenciaXML
    {

        public void Guardar(string ruta , List<Persona> listaPersona)
        {
            XmlSerializer conversorXML = new XmlSerializer(typeof(List<Persona>));
            using (StreamWriter escritura = new StreamWriter(ruta))
            {
                conversorXML.Serialize(escritura, listaPersona);
            }
        }

        public List<Persona> Leer(string ruta)
        {
            if(string.IsNullOrEmpty(ruta))
                return  new List<Persona>();

            XmlSerializer conversorXML = new XmlSerializer(typeof(List<Persona>));

            using (StreamReader lectura = new StreamReader(ruta))
            {
                return (List<Persona>)conversorXML.Deserialize(lectura);
                
            }
        }
    }
}
