using DataLayer;
using Entities;
using System.Collections.Generic;

namespace BussinesLayer
{
    public class EspecialidadBussines
    {
        public List<Especialidad> listar()
        {
            EspecialidadData espe = new EspecialidadData();
            return espe.ListEspecialidad();
        }
    }
}
