using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CursoLectivoData
    {
        #region Curso Activo
        public int CursoActivo()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            int cursoActivo = 0;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    //TODO: Selecciona Curso Lectivo activo
                    using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM curso_activo;", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cursoActivo = Convert.ToInt32(cmd.ExecuteScalar());
                        conn.Close();
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cursoActivo;
        }
        #endregion
    }
}
