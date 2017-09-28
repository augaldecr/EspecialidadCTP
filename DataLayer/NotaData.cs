using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace DataLayer
{
    public class NotaData
    {
        #region GuardarNota
        public void GuardaNota(Nota nota)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "InsertNota";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("estudiante", MySqlDbType.Int16);
                        cmd.Parameters["estudiante"].Value = nota.Matricula;
                        cmd.Parameters["estudiante"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("asignatura", MySqlDbType.Int16);
                        cmd.Parameters["asignatura"].Value = nota.Asignatura;
                        cmd.Parameters["asignatura"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("nivel", MySqlDbType.Int16);
                        cmd.Parameters["nivel"].Value = nota.Nivel;
                        cmd.Parameters["nivel"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("periodo", MySqlDbType.Int16);
                        cmd.Parameters["periodo"].Value = nota.Periodo;
                        cmd.Parameters["periodo"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("nota", MySqlDbType.Decimal);
                        cmd.Parameters["nota"].Value = nota.Calificacion;
                        cmd.Parameters["nota"].Direction = ParameterDirection.Input;

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

        #region GuardarNotaOrienta
        public void GuardaNotaOrienta(Nota nota)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "InsertNotaOrienta";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("matricula", MySqlDbType.Int32);
                        cmd.Parameters["matricula"].Value = nota.Matricula;
                        cmd.Parameters["matricula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("curso_lectivo", MySqlDbType.Int32);
                        cmd.Parameters["curso_lectivo"].Value = nota.Curso_lectivo;
                        cmd.Parameters["curso_lectivo"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("entrevista", MySqlDbType.Double);
                        cmd.Parameters["entrevista"].Value = nota.Entrevista;
                        cmd.Parameters["entrevista"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("vocacional", MySqlDbType.Double);
                        cmd.Parameters["vocacional"].Value = nota.Vocacional;
                        cmd.Parameters["vocacional"].Direction = ParameterDirection.Input;

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

        #region ActualizarNota
        public void ActualizaNota(Nota nota)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UpdateNota";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pidnota", MySqlDbType.Int16);
                        cmd.Parameters["pidnota"].Value = nota.IdNota;
                        cmd.Parameters["pidnota"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pestudiante", MySqlDbType.Int16);
                        cmd.Parameters["pestudiante"].Value = nota.Matricula;
                        cmd.Parameters["pestudiante"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pasignatura", MySqlDbType.Int16);
                        cmd.Parameters["pasignatura"].Value = nota.Asignatura;
                        cmd.Parameters["pasignatura"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnivel", MySqlDbType.Int16);
                        cmd.Parameters["pnivel"].Value = nota.Nivel;
                        cmd.Parameters["pnivel"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pperiodo", MySqlDbType.Int16);
                        cmd.Parameters["pperiodo"].Value = nota.Periodo;
                        cmd.Parameters["pperiodo"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnota", MySqlDbType.Decimal);
                        cmd.Parameters["pnota"].Value = nota.Calificacion;
                        cmd.Parameters["pnota"].Direction = ParameterDirection.Input;

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

        #region ActualizarNotaOrienta
        public void ActualizaNotaOrienta(Nota nota)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UpdateNotaOrienta";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("pidnota_orienta", MySqlDbType.Int32);
                        cmd.Parameters["pidnota_orienta"].Value = nota.IdNota;
                        cmd.Parameters["pidnota_orienta"].Direction = ParameterDirection.Input;

                        cmd.Parameters.Add("pentrevista", MySqlDbType.Double);
                        cmd.Parameters["pentrevista"].Value = nota.Entrevista;
                        cmd.Parameters["pentrevista"].Direction = ParameterDirection.Input;

                        cmd.Parameters.Add("pvocacional", MySqlDbType.Double);
                        cmd.Parameters["pvocacional"].Value = nota.Vocacional;
                        cmd.Parameters["pvocacional"].Direction = ParameterDirection.Input;

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

        #region BorrarNota
        public void BorraNota(int id)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DeleteNota";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pidnota", MySqlDbType.Int16);
                        cmd.Parameters["pidnota"].Value = id;
                        cmd.Parameters["pidnota"].Direction = ParameterDirection.Input;

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

        #region BorrarNota
        public void BorraNotaOrienta(int id)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DeleteNotaOrienta";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pidnota", MySqlDbType.Int16);
                        cmd.Parameters["pidnota"].Value = id;
                        cmd.Parameters["pidnota"].Direction = ParameterDirection.Input;

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

        #region ListarNotas
        public List<Nota> ListNotas()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<Nota> lista = new List<Nota>(); ;

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
                                Nota nota = new Nota();
                                nota.IdNota = dr.GetInt32(0);
                                nota.Matricula = dr.GetInt32(1);
                                nota.Asignatura = dr.GetInt32(2);
                                nota.Nivel = dr.GetInt32(3);
                                nota.Periodo = dr.GetInt32(4);
                                nota.Calificacion = dr.GetDecimal(5);

                                lista.Add(nota);
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

        #region ListarNotasOrienta
        public List<Nota> ListNotasOrienta()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<Nota> lista = new List<Nota>(); ;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_orientacion_all;", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                Nota nota = new Nota();

                                nota.IdNota = dr.GetValue(6) == DBNull.Value ? (int?)null : dr.GetInt32(6);
                                nota.Matricula = dr.GetInt32(0);
                                nota.Apellido1 = dr.GetString(2);
                                nota.Apellido2 = dr.GetString(3);
                                nota.Nombre = dr.GetString(4);
                                nota.Curso_lectivo = dr.GetInt32(5);
                                nota.Entrevista = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(7);
                                nota.Vocacional = dr.GetValue(8) == DBNull.Value ? (decimal?)null : dr.GetDecimal(8);

                                lista.Add(nota);
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

        #region SeleccionaNota
        public Nota notaXId(int id)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            Nota nota = new Nota();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas WHERE idnotas=" + id + ";", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                nota.IdNota = dr.GetInt32(0);
                                nota.Matricula = dr.GetInt32(1);
                                nota.Asignatura = dr.GetInt32(2);
                                nota.Nivel = dr.GetInt32(3);
                                nota.Periodo = dr.GetInt32(4);
                                nota.Calificacion = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(5);
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
            return nota;
        }
        #endregion

        #region SeleccionaNota
        public Nota notaOrientaXId(int id)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            Nota nota = new Nota();

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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_orienta WHERE idnotas_orienta=" + id + ";", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                nota.IdNota = dr.GetInt32(0);
                                nota.Matricula = dr.GetInt32(1);
                                nota.Curso_lectivo = dr.GetInt32(2);
                                nota.Entrevista = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(3);
                                nota.Vocacional = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(4);
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
            return nota;
        }
        #endregion

        #region SeleccionaEstudianteXCedula
        public Estudiante estudianteXCedula(string cedula)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
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
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

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
