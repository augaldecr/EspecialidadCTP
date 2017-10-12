using Entities;
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
    public class PeriodoData
    {
        #region Periodos de curso lectivo activo
        public List<Periodo> periodosCursoActivo()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<Periodo> periodosCursoAct = new List<Periodo>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    //TODO: Seleccionar los periodos activos y los estudiantes y sus notas
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM periodos_curso_activo;", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                Periodo periodo = new Periodo();
                                periodo.IdPeriodo = dr.GetInt32(0);
                                periodo.Nombre = dr.GetString(1);

                                periodosCursoAct.Add(periodo);
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
            return periodosCursoAct;
        }
        #endregion

        #region Periodos de curso lectivo X id
        public List<Periodo> periodosXCurso(int curso)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<Periodo> periodos = new List<Periodo>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    //TODO: Seleccionar los periodos activos y los estudiantes y sus notas
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SeleccionarPeriodosXCursoLectivo";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pcurso_lectivo", MySqlDbType.Int32);
                        cmd.Parameters["pcurso_lectivo"].Value = curso;
                        cmd.Parameters["pcurso_lectivo"].Direction = ParameterDirection.Input;

                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                Periodo periodo = new Periodo();
                                periodo.IdPeriodo = dr.GetInt32(0);
                                periodo.Nombre = dr.GetString(1);
                                periodo.CursoLectivo = curso;

                                periodos.Add(periodo);
                            }
                            dr.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return periodos;
        }
        #endregion
    }
}