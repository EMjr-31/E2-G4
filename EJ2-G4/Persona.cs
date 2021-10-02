using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2_G4
{
    class Persona
    {
        string nombre;
        public string Nombre
        {
            get { return nombre;}
`           set {nombre=value;}
        }
        public string Apellido { get => apellido; set => apellido = value; }

        string apellido;
    }
}
