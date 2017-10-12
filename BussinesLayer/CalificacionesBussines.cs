using DataLayer;
using Entities;
using System;
using System.Collections.Generic;

namespace BussinesLayer
{
    public class CalificacionesBussines
    {
        public List<Calificaciones> ListarCalificacionesTRendimiento()
        {
            try
            {
                return new CalificacionesData().ListCalificacionesTRendimiento();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
