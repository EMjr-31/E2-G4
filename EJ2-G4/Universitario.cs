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
        string[] materias= new string[3];
        float[] nota =new float[3];
       float cum;

        public string Universidad { get => universidad; set => universidad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string[] Materias { get => materias; set => materias = value; }
        public float[] Nota { get => nota; set => nota = value; }
        public float Cum { get => cum; set => cum = value; }

        public void cal_cum()
        {
            float suma=0;
            for (int i = 0; i < 3; i++)
            {
                suma = suma+nota[i];
            }
            Cum = suma/ 3;
        }
    }
}
