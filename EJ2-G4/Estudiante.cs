using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2_G4
{
    class Estudiante :  Persona
    {
        string carnet;
        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }
        string nivel;
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

    }
}
