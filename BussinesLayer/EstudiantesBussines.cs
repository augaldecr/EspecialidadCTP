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
    }
}
