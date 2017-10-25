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
    public class AsignaturaData
    {
        #region Lista asignaturas básicas
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

        #region Lista talleres por cédula
        public List<Asignatura> listarTalleresXCedula(string cedula)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<Asignatura> talleres = new List<Asignatura>();

            //TODO: Recuperar las matriculas por el curso lectivo
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "talleres_x_cedula";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pcedula", MySqlDbType.String);
                        cmd.Parameters["pcedula"].Value = cedula;
                        cmd.Parameters["pcedula"].Direction = ParameterDirection.Input;

                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                Asignatura taller = new Asignatura();
                                taller.IdAsignatura = dr.GetInt32(0);
                                taller.Nombre = dr.GetString(1);

                                talleres.Add(taller);
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
            return talleres;
        }
        #endregion
    }
}
