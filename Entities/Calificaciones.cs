using System.Collections.Generic;

namespace Entities
{
    public class Calificaciones
    {
        public Matricula matricula { get; set; }
        public Estudiante estudiante { get; set; }
        public List<Nota> Notas = new List<Nota>();
    }
}
