using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2_G4
{
    class Ingenieria: Universitario
    {
        string proyecto;
        int total_horas;
        int horas_compl;

        public string Proyecto { get => proyecto; set => proyecto = value; }
        public int Total_horas { get => total_horas; set => total_horas = value; }
        public int Horas_compl { get => horas_compl; set => horas_compl = value; }
    }
}
