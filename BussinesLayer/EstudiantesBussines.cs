using DataLayer;
using Entities;
using System.Collections.Generic;

namespace BussinesLayer
{
    public class EstudiantesBussines
    {
        public List<Estudiante> listar()
        {
            EstudianteData estu = new EstudianteData();
            return estu.ListEstudiante();
        }

        public Estudiante estudianteXID(int id)
        {
            EstudianteData dt = new EstudianteData();
            return dt.estudianteXId(id);
        }
    }
}
