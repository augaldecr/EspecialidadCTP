using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AsignaturaData
    {
        #region Periodos de curso lectivo activo
        public List<Asignatura> listarAsignaturas()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<Asignatura> asignaturas = new List<Asignatura>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    //TODO: Seleccionar los periodos activos y los estudiantes y sus notas
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM asignaturas_all;", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                Asignatura asignatura = new Asignatura();
                                asignatura.IdAsignatura = dr.GetInt32(0);
                                asignatura.Nombre = dr.GetString(1);

                                asignaturas.Add(asignatura);
                            }
                            dr.Close();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return asignaturas;
        }
        #endregion
    }
}
