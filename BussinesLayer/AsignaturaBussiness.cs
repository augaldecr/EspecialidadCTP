using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class AsignaturaBussiness
    {
        public int[] TalleresDesdeAnual(string cedula, int nivel)
        {
            try
            {
                return new AsignaturaData().listarTalleresDesdeAnual(cedula, nivel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
