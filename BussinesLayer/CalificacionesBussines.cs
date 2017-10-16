using DataLayer;
using Entities;
using System;
using System.Collections.Generic;

namespace BussinesLayer
{
    public class CalificacionesBussines
    {
        public delegate void AddAvance();
        public event AddAvance addAvance;

        public List<Calificaciones> ListarCalificacionesTRendimiento()
        {
            try
            {
                CalificacionesData c = new CalificacionesData();
                c.addAvanceDT += C_addAvanceDT;
                return c.ListCalificacionesTRendimiento();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void C_addAvanceDT()
        {
            addAvance();
        }
    }
}
