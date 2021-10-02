using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2_G4
{
    class Universitario: Estudiante
    {
        string universidad;
        string carrera;
        string materia1;
        string materia2;
        string materia3;
        float nota1;
        float nota2;
        float nota3;
        float cum;

        public string Universidad { get => universidad; set => universidad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public float Cum { get => cum; set => cum = value; }
        public string Materia1 { get => materia1; set => materia1 = value; }
        public string Materia2 { get => materia2; set => materia2 = value; }
        public string Materia3 { get => materia3; set => materia3 = value; }
        public float Nota1 { get => nota1; set => nota1 = value; }
        public float Nota2 { get => nota2; set => nota2 = value; }
        public float Nota3 { get => nota3; set => nota3 = value; }
    }
}
