using DataLayer;
using System;

namespace BussinesLayer
{
    public class CursoLectivoBussines
    {
        public int CursoLectivoActivo()
        {
            try
            {
                return new CursoLectivoData().CursoActivo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
