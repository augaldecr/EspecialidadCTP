using DataLayer;
using Entities;
using System.Collections.Generic;

namespace BussinesLayer
{
    public class GrupoBussines
    {
        #region listar grupos
        public List<Grupo> listar()
        {
            GrupoData grpD = new GrupoData();
            return grpD.ListGrupo();
        }
        #endregion
    }
}
