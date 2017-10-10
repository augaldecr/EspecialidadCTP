using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class CalificacionesBussines
    {
        public List<Calificaciones> ListarCalificaciones()
        {
            try
            {
                return new CalificacionesData().ListCalificaciones();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
