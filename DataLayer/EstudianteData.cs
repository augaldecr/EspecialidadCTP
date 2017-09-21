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
        public void GuardaEstudiante(Estudiante est)
        {
            //string connString = ConfigurationManager.AppSettings["connString"];
            string connString = "server=localhost;user=root;database=ctp_noveno;port=3306;password=Alonso7157344/*-;";

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
                        cmd.Parameters["cedula"].Value = est.Cedula;
                        cmd.Parameters["cedula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("nombre", MySqlDbType.VarChar);
                        cmd.Parameters["nombre"].Value = est.Nombre;
                        cmd.Parameters["nombre"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("apellido1", MySqlDbType.VarChar);
                        cmd.Parameters["apellido1"].Value = est.Apellido1;
                        cmd.Parameters["apellido1"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("apellido2", MySqlDbType.VarChar);
                        cmd.Parameters["apellido2"].Value = est.Apellido2;
                        cmd.Parameters["apellido2"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("direccion", MySqlDbType.VarChar);
                        cmd.Parameters["direccion"].Value = est.Direccion;
                        cmd.Parameters["direccion"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("telefono", MySqlDbType.VarChar);
                        cmd.Parameters["telefono"].Value = est.Telefono;
                        cmd.Parameters["telefono"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("celular", MySqlDbType.VarChar);
                        cmd.Parameters["celular"].Value = est.Celular;
                        cmd.Parameters["celular"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("email", MySqlDbType.VarChar);
                        cmd.Parameters["email"].Value = est.Email;
                        cmd.Parameters["email"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("ctpp", MySqlDbType.VarChar);
                        cmd.Parameters["ctpp"].Value = est.Ctpp;
                        cmd.Parameters["ctpp"].Direction = ParameterDirection.Input;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
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
        public void ActualizaEstudiante(Estudiante est)
        {
            //string connString = ConfigurationManager.AppSettings["connString"];
            string connString = "server=localhost;user=root;database=ctp_noveno;port=3306;password=Alonso7157344/*-;";

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
                        cmd.Parameters["pidestudiante"].Value = est.IdEstudiante;
                        cmd.Parameters["pidestudiante"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pcedula", MySqlDbType.VarChar);
                        cmd.Parameters["pcedula"].Value = est.Cedula;
                        cmd.Parameters["pcedula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnombre", MySqlDbType.VarChar);
                        cmd.Parameters["pnombre"].Value = est.Nombre;
                        cmd.Parameters["pnombre"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("papellido1", MySqlDbType.VarChar);
                        cmd.Parameters["papellido1"].Value = est.Apellido1;
                        cmd.Parameters["papellido1"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("papellido2", MySqlDbType.VarChar);
                        cmd.Parameters["papellido2"].Value = est.Apellido2;
                        cmd.Parameters["papellido2"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pdireccion", MySqlDbType.VarChar);
                        cmd.Parameters["pdireccion"].Value = est.Direccion;
                        cmd.Parameters["pdireccion"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("ptelefono", MySqlDbType.VarChar);
                        cmd.Parameters["ptelefono"].Value = est.Telefono;
                        cmd.Parameters["ptelefono"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pcelular", MySqlDbType.VarChar);
                        cmd.Parameters["pcelular"].Value = est.Celular;
                        cmd.Parameters["pcelular"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pemail", MySqlDbType.VarChar);
                        cmd.Parameters["pemail"].Value = est.Email;
                        cmd.Parameters["pemail"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pctpp", MySqlDbType.VarChar);
                        cmd.Parameters["pctpp"].Value = est.Ctpp;
                        cmd.Parameters["pctpp"].Direction = ParameterDirection.Input;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
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
        public void BorraEstudiante(int id)
        {
            //string connString = ConfigurationManager.AppSettings["connString"];
            string connString = "server=localhost;user=root;database=ctp_noveno;port=3306;password=Alonso7157344/*-;";

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
                        cmd.Parameters["pidestudiante"].Value = id;
                        cmd.Parameters["pidestudiante"].Direction = ParameterDirection.Input;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
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

        #region SeleccionaEstudiante
        public Estudiante estudianteXId(int id)
        {
            string connString = "server=localhost;user=root;database=ctp_noveno;port=3306;password=Alonso7157344/*-;";
            Estudiante est = new Estudiante();

            try
            {

                #region Procedure
                //using (MySqlConnection conn = new MySqlConnection())
                //{
                //    using (MySqlCommand cmd = new MySqlCommand())
                //    {
                //        conn.ConnectionString = connString;
                //        cmd.Connection = conn;
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.CommandText = "select_student_id";

                //        MySqlParameter pidestudiante = new MySqlParameter();
                //        pidestudiante.ParameterName = "@pidestudiante";
                //        pidestudiante.Direction = ParameterDirection.Input;
                //        pidestudiante.MySqlDbType = MySqlDbType.Int32;
                //        pidestudiante.Value = id;
                //        cmd.Parameters.Add(pidestudiante);

                //        MySqlParameter pcedula = new MySqlParameter();
                //        pcedula.ParameterName = "@pcedula";
                //        pcedula.Direction = ParameterDirection.ReturnValue;
                //        pcedula.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pcedula);

                //        MySqlParameter pnombre = new MySqlParameter();
                //        pnombre.ParameterName = "@pnombre";
                //        pnombre.Direction = ParameterDirection.ReturnValue;
                //        pnombre.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pnombre);

                //        MySqlParameter papellido1 = new MySqlParameter();
                //        papellido1.ParameterName = "@papellido1";
                //        papellido1.Direction = ParameterDirection.ReturnValue;
                //        papellido1.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(papellido1);

                //        MySqlParameter papellido2 = new MySqlParameter();
                //        papellido2.ParameterName = "@papellido2";
                //        papellido2.Direction = ParameterDirection.ReturnValue;
                //        papellido2.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(papellido2);

                //        MySqlParameter pdireccion = new MySqlParameter();
                //        pdireccion.ParameterName = "@pdireccion";
                //        pdireccion.Direction = ParameterDirection.ReturnValue;
                //        pdireccion.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pdireccion);

                //        MySqlParameter ptelefono = new MySqlParameter();
                //        ptelefono.ParameterName = "@ptelefono";
                //        ptelefono.Direction = ParameterDirection.ReturnValue;
                //        ptelefono.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(ptelefono);

                //        MySqlParameter pcelular = new MySqlParameter();
                //        pcelular.ParameterName = "@pcelular";
                //        pcelular.Direction = ParameterDirection.ReturnValue;
                //        pcelular.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pcelular);

                //        MySqlParameter pemail = new MySqlParameter();
                //        pemail.ParameterName = "@pemail";
                //        pemail.Direction = ParameterDirection.ReturnValue;
                //        pemail.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pemail);

                //        MySqlParameter pctpp = new MySqlParameter();
                //        pctpp.ParameterName = "@pctpp";
                //        pctpp.Direction = ParameterDirection.ReturnValue;
                //        pctpp.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pctpp);

                //        conn.Open();
                //        cmd.ExecuteNonQuery();

                //        est.Cedula = pcedula.Value.ToString();
                //        est.Nombre = pnombre.Value.ToString();
                //        est.Apellido1 = papellido1.Value.ToString();
                //        est.Apellido2 = papellido2.Value.ToString();
                //        est.Direccion = pdireccion.Value.ToString();
                //        est.Telefono = ptelefono.Value.ToString();
                //        est.Celular = pcelular.Value.ToString();
                //        est.Email = pemail.Value.ToString();
                //        est.Ctpp = int.Parse(pctpp.Value.ToString());
                //    }
                //}
                //return est;
                #endregion

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes WHERE idestudiante="+id+";", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                est.IdEstudiante = dr.GetInt32(0);
                                est.Cedula = dr.GetString(1);
                                est.Nombre = dr.GetString(2);
                                est.Apellido1 = dr.GetString(3);
                                est.Apellido2 = dr.GetString(4);
                                est.Celular = dr.GetString(7);
                                est.Telefono = dr.GetString(6);
                                est.Email = dr.GetString(5);
                                est.Direccion = dr.GetString(8);
                                est.Ctpp = dr.GetInt32(9);
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
            return est;
        }
        #endregion

        #region SeleccionaEstudianteXCedula
        public Estudiante estudianteXCedula(string cedula)
        {
            string connString = "server=localhost;user=root;database=ctp_noveno;port=3306;password=Alonso7157344/*-;";
            Estudiante est = new Estudiante();

            try
            {

                #region Procedure
                //using (MySqlConnection conn = new MySqlConnection())
                //{
                //    using (MySqlCommand cmd = new MySqlCommand())
                //    {
                //        conn.ConnectionString = connString;
                //        cmd.Connection = conn;
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.CommandText = "select_student_id";

                //        MySqlParameter pidestudiante = new MySqlParameter();
                //        pidestudiante.ParameterName = "@pidestudiante";
                //        pidestudiante.Direction = ParameterDirection.Input;
                //        pidestudiante.MySqlDbType = MySqlDbType.Int32;
                //        pidestudiante.Value = id;
                //        cmd.Parameters.Add(pidestudiante);

                //        MySqlParameter pcedula = new MySqlParameter();
                //        pcedula.ParameterName = "@pcedula";
                //        pcedula.Direction = ParameterDirection.ReturnValue;
                //        pcedula.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pcedula);

                //        MySqlParameter pnombre = new MySqlParameter();
                //        pnombre.ParameterName = "@pnombre";
                //        pnombre.Direction = ParameterDirection.ReturnValue;
                //        pnombre.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pnombre);

                //        MySqlParameter papellido1 = new MySqlParameter();
                //        papellido1.ParameterName = "@papellido1";
                //        papellido1.Direction = ParameterDirection.ReturnValue;
                //        papellido1.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(papellido1);

                //        MySqlParameter papellido2 = new MySqlParameter();
                //        papellido2.ParameterName = "@papellido2";
                //        papellido2.Direction = ParameterDirection.ReturnValue;
                //        papellido2.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(papellido2);

                //        MySqlParameter pdireccion = new MySqlParameter();
                //        pdireccion.ParameterName = "@pdireccion";
                //        pdireccion.Direction = ParameterDirection.ReturnValue;
                //        pdireccion.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pdireccion);

                //        MySqlParameter ptelefono = new MySqlParameter();
                //        ptelefono.ParameterName = "@ptelefono";
                //        ptelefono.Direction = ParameterDirection.ReturnValue;
                //        ptelefono.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(ptelefono);

                //        MySqlParameter pcelular = new MySqlParameter();
                //        pcelular.ParameterName = "@pcelular";
                //        pcelular.Direction = ParameterDirection.ReturnValue;
                //        pcelular.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pcelular);

                //        MySqlParameter pemail = new MySqlParameter();
                //        pemail.ParameterName = "@pemail";
                //        pemail.Direction = ParameterDirection.ReturnValue;
                //        pemail.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pemail);

                //        MySqlParameter pctpp = new MySqlParameter();
                //        pctpp.ParameterName = "@pctpp";
                //        pctpp.Direction = ParameterDirection.ReturnValue;
                //        pctpp.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pctpp);

                //        conn.Open();
                //        cmd.ExecuteNonQuery();

                //        est.Cedula = pcedula.Value.ToString();
                //        est.Nombre = pnombre.Value.ToString();
                //        est.Apellido1 = papellido1.Value.ToString();
                //        est.Apellido2 = papellido2.Value.ToString();
                //        est.Direccion = pdireccion.Value.ToString();
                //        est.Telefono = ptelefono.Value.ToString();
                //        est.Celular = pcelular.Value.ToString();
                //        est.Email = pemail.Value.ToString();
                //        est.Ctpp = int.Parse(pctpp.Value.ToString());
                //    }
                //}
                //return est;
                #endregion

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes WHERE cedula=" + cedula + ";", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                est.IdEstudiante = dr.GetInt32(0);
                                est.Cedula = dr.GetString(1);
                                est.Nombre = dr.GetString(2);
                                est.Apellido1 = dr.GetString(3);
                                est.Apellido2 = dr.GetString(4);
                                est.Celular = dr.GetString(5);
                                est.Telefono = dr.GetString(6);
                                est.Email = dr.GetString(7);
                                est.Direccion = dr.GetString(8);
                                est.Ctpp = dr.GetInt32(9);
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
            return est;
        }
        #endregion

        #region IdEstudianteXCedula
        public int idEstudianteXCedula(string cedula)
        {
            string connString = "server=localhost;user=root;database=ctp_noveno;port=3306;password=Alonso7157344/*-;";

            try
            {

                #region Procedure
                //using (MySqlConnection conn = new MySqlConnection())
                //{
                //    using (MySqlCommand cmd = new MySqlCommand())
                //    {
                //        conn.ConnectionString = connString;
                //        cmd.Connection = conn;
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.CommandText = "select_student_id";

                //        MySqlParameter pidestudiante = new MySqlParameter();
                //        pidestudiante.ParameterName = "@pidestudiante";
                //        pidestudiante.Direction = ParameterDirection.Input;
                //        pidestudiante.MySqlDbType = MySqlDbType.Int32;
                //        pidestudiante.Value = id;
                //        cmd.Parameters.Add(pidestudiante);

                //        MySqlParameter pcedula = new MySqlParameter();
                //        pcedula.ParameterName = "@pcedula";
                //        pcedula.Direction = ParameterDirection.ReturnValue;
                //        pcedula.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pcedula);

                //        MySqlParameter pnombre = new MySqlParameter();
                //        pnombre.ParameterName = "@pnombre";
                //        pnombre.Direction = ParameterDirection.ReturnValue;
                //        pnombre.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pnombre);

                //        MySqlParameter papellido1 = new MySqlParameter();
                //        papellido1.ParameterName = "@papellido1";
                //        papellido1.Direction = ParameterDirection.ReturnValue;
                //        papellido1.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(papellido1);

                //        MySqlParameter papellido2 = new MySqlParameter();
                //        papellido2.ParameterName = "@papellido2";
                //        papellido2.Direction = ParameterDirection.ReturnValue;
                //        papellido2.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(papellido2);

                //        MySqlParameter pdireccion = new MySqlParameter();
                //        pdireccion.ParameterName = "@pdireccion";
                //        pdireccion.Direction = ParameterDirection.ReturnValue;
                //        pdireccion.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pdireccion);

                //        MySqlParameter ptelefono = new MySqlParameter();
                //        ptelefono.ParameterName = "@ptelefono";
                //        ptelefono.Direction = ParameterDirection.ReturnValue;
                //        ptelefono.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(ptelefono);

                //        MySqlParameter pcelular = new MySqlParameter();
                //        pcelular.ParameterName = "@pcelular";
                //        pcelular.Direction = ParameterDirection.ReturnValue;
                //        pcelular.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pcelular);

                //        MySqlParameter pemail = new MySqlParameter();
                //        pemail.ParameterName = "@pemail";
                //        pemail.Direction = ParameterDirection.ReturnValue;
                //        pemail.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pemail);

                //        MySqlParameter pctpp = new MySqlParameter();
                //        pctpp.ParameterName = "@pctpp";
                //        pctpp.Direction = ParameterDirection.ReturnValue;
                //        pctpp.MySqlDbType = MySqlDbType.VarChar;
                //        cmd.Parameters.Add(pctpp);

                //        conn.Open();
                //        cmd.ExecuteNonQuery();

                //        est.Cedula = pcedula.Value.ToString();
                //        est.Nombre = pnombre.Value.ToString();
                //        est.Apellido1 = papellido1.Value.ToString();
                //        est.Apellido2 = papellido2.Value.ToString();
                //        est.Direccion = pdireccion.Value.ToString();
                //        est.Telefono = ptelefono.Value.ToString();
                //        est.Celular = pcelular.Value.ToString();
                //        est.Email = pemail.Value.ToString();
                //        est.Ctpp = int.Parse(pctpp.Value.ToString());
                //    }
                //}
                //return est;
                #endregion

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes WHERE cedula='" + cedula + "';", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                return dr.GetInt32(0);
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
            return 0;
        }
        #endregion
    }
}
