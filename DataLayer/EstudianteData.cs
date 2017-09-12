using System.Data;
using Entities;
using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class EstudianteData : Estudiante
    {
        #region GuardarEstudiante
        public void GuardaEstudiante()
        {
            string connString = ConfigurationManager.AppSettings["connString"];

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "InsertEstudiante";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("cedula", MySqlDbType.VarChar);
                        cmd.Parameters["cedula"].Value = Cedula;
                        cmd.Parameters["cedula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("nombre", MySqlDbType.VarChar);
                        cmd.Parameters["nombre"].Value = Nombre;
                        cmd.Parameters["nombre"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("apellido1", MySqlDbType.VarChar);
                        cmd.Parameters["apellido1"].Value = Apellido1;
                        cmd.Parameters["apellido1"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("apellido2", MySqlDbType.VarChar);
                        cmd.Parameters["apellido2"].Value = Apellido2;
                        cmd.Parameters["apellido2"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("direccion", MySqlDbType.VarChar);
                        cmd.Parameters["direccion"].Value = Direccion;
                        cmd.Parameters["direccion"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("telefono", MySqlDbType.VarChar);
                        cmd.Parameters["telefono"].Value = Telefono;
                        cmd.Parameters["telefono"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("celular", MySqlDbType.VarChar);
                        cmd.Parameters["celular"].Value = Celular;
                        cmd.Parameters["celular"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("email", MySqlDbType.VarChar);
                        cmd.Parameters["email"].Value = Email;
                        cmd.Parameters["email"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("ctpp", MySqlDbType.VarChar);
                        cmd.Parameters["ctpp"].Value = Ctpp;
                        cmd.Parameters["ctpp"].Direction = ParameterDirection.Input;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ActualizarEstudiante
        public void ActualizaEstudiante()
        {
            string connString = ConfigurationManager.AppSettings["connString"];

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UpdateEstudiante";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pidestudiante", MySqlDbType.VarChar);
                        cmd.Parameters["pidestudiante"].Value = IdEstudiante;
                        cmd.Parameters["pidestudiante"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pcedula", MySqlDbType.VarChar);
                        cmd.Parameters["pcedula"].Value = Cedula;
                        cmd.Parameters["pcedula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnombre", MySqlDbType.VarChar);
                        cmd.Parameters["pnombre"].Value = Nombre;
                        cmd.Parameters["pnombre"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("papellido1", MySqlDbType.VarChar);
                        cmd.Parameters["papellido1"].Value = Apellido1;
                        cmd.Parameters["papellido1"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("papellido2", MySqlDbType.VarChar);
                        cmd.Parameters["papellido2"].Value = Apellido2;
                        cmd.Parameters["papellido2"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pdireccion", MySqlDbType.VarChar);
                        cmd.Parameters["pdireccion"].Value = Direccion;
                        cmd.Parameters["pdireccion"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("ptelefono", MySqlDbType.VarChar);
                        cmd.Parameters["ptelefono"].Value = Telefono;
                        cmd.Parameters["ptelefono"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pcelular", MySqlDbType.VarChar);
                        cmd.Parameters["pcelular"].Value = Celular;
                        cmd.Parameters["pcelular"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pemail", MySqlDbType.VarChar);
                        cmd.Parameters["pemail"].Value = Email;
                        cmd.Parameters["pemail"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pctpp", MySqlDbType.VarChar);
                        cmd.Parameters["pctpp"].Value = Ctpp;
                        cmd.Parameters["pctpp"].Direction = ParameterDirection.Input;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region BorrarEstudiante
        public void BorraEstudiante()
        {
            string connString = ConfigurationManager.AppSettings["connString"];

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DeleteEstudiante";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pidestudiante", MySqlDbType.VarChar);
                        cmd.Parameters["pidestudiante"].Value = IdEstudiante;
                        cmd.Parameters["pidestudiante"].Direction = ParameterDirection.Input;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ListarEstudiante
        public List<Estudiante> ListEstudiante()
        {
            //string connString = ConfigurationManager.AppSettings["connString"];
            string connString = "server=localhost;user=root;database=ctp_noveno;port=3306;password=Alonso7157344/*-;";
            List<Estudiante> lista = new List<Estudiante>(); ;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes_datos;", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                Estudiante est = new Estudiante();
                                est.IdEstudiante = dr.GetInt32(1);
                                est.Cedula = dr.GetString(2);
                                est.Nombre = dr.GetString(3);
                                est.Apellido1 = dr.GetString(4);
                                est.Apellido2 = dr.GetString(5);
                                est.Celular = dr.GetString(6);
                                est.Telefono = dr.GetString(7);
                                est.Email = dr.GetString(8);
                                est.Direccion = dr.GetString(9);
                                est.Ctpp = dr.GetInt32(10);

                                lista.Add(est);
                            }
                            dr.Close();
                        }
                    }
                }
                return lista;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
