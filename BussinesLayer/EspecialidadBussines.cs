using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
