using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Nota
    {
        public int IdNota { get; set; }
        public int Matricula { get; set; }
        public int Periodo { get; set; }
        public int Asignatura { get; set; }
        public decimal Calificacion { get; set; }
    }
}
