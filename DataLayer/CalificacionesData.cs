using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace DataLayer
{
    public class CalificacionesData
    {
        #region ListarCalificaciones
        public List<Calificaciones> ListCalificaciones()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            int cursoActivo = 0;
            List<Periodo> periodosCursoAct = new List<Periodo>();
            List<Matricula> matriculas = new List<Matricula>();
            List<Estudiante> estudiantes = new List<Estudiante>();
            List<Calificaciones> calificaciones = new List<Calificaciones>();

            #region Curso Activo
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    //TODO: Selecciona Curso Lectivo activo
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM curso_activo;", conn))
                    {
                        cmd.CommandType = CommandType.TableDirect;
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
            #endregion

            #region Periodos de Curso Activo
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
            #endregion


            #region Recupera matriculas
            //TODO: Recuperar las matriculas por el curso lectivo
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
            #endregion
        }
    }
    #endregion
}
