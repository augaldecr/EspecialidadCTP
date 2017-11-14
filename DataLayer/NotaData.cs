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

        #region GuardarNota
        public void GuardaNotaEleccion(Nota nota)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UpdateEleccionEspecialidad";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pmatricula", MySqlDbType.Int32);
                        cmd.Parameters["pmatricula"].Value = nota.Matricula;
                        cmd.Parameters["pmatricula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pespecialidad", MySqlDbType.Int32);
                        cmd.Parameters["pespecialidad"].Value = nota.Asignatura;
                        cmd.Parameters["pespecialidad"].Direction = ParameterDirection.Input;

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
                        cmd.Parameters.Add("pidnota", MySqlDbType.Int32);
                        cmd.Parameters["pidnota"].Value = nota.IdNota;
                        cmd.Parameters["pidnota"].Direction = ParameterDirection.Input;
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

        #region ActualizarNota de eleccion especialidad
        public void ActualizaNotaEleccEsp(Nota nota)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UpdateNotaEleccionEspecialidad";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pidnota", MySqlDbType.Int32);
                        cmd.Parameters["pidnota"].Value = nota.IdNota;
                        cmd.Parameters["pidnota"].Direction = ParameterDirection.Input;
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

        #region BorrarNotaOrienta
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

        #region BorrarNotaOrientaXMatricula
        public void BorraNotaOrientaXMAt(int mat)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DeleteNotaOrientaXMat";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pmatricula", MySqlDbType.Int32);
                        cmd.Parameters["pmatricula"].Value = mat;
                        cmd.Parameters["pmatricula"].Direction = ParameterDirection.Input;

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

        #region BorrarNota por matrícula y nivel
        public void BorraNotasXMatYNivel(int mat, int nivel)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DeleteNotaXMatYNivel";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pmatricula", MySqlDbType.Int32);
                        cmd.Parameters["pmatricula"].Value = mat;
                        cmd.Parameters["pmatricula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnivel", MySqlDbType.Int32);
                        cmd.Parameters["pnivel"].Value = nivel;
                        cmd.Parameters["pnivel"].Direction = ParameterDirection.Input;

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

        #region Borrar Notas por matrícula, nivel y asignatura
        public void BorraNotasXMatNivelAsig(int mat, int nivel, int asig)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DeleteNotasXMatNivelAsig";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pmatricula", MySqlDbType.Int32);
                        cmd.Parameters["pmatricula"].Value = mat;
                        cmd.Parameters["pmatricula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnivel", MySqlDbType.Int32);
                        cmd.Parameters["pnivel"].Value = nivel;
                        cmd.Parameters["pnivel"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pasig", MySqlDbType.Int32);
                        cmd.Parameters["pasig"].Value = asig;
                        cmd.Parameters["pasig"].Direction = ParameterDirection.Input;

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
                                nota.Vocacional = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(7);
                                nota.Esp1_id = dr.GetValue(8) == DBNull.Value ? (int?)null : dr.GetInt32(8);
                                nota.Esp1_nombre = dr.GetString(9);
                                nota.Esp1_nota = dr.GetValue(10) == DBNull.Value ? (decimal?)null : dr.GetDecimal(10);
                                nota.Esp2_id = dr.GetValue(11) == DBNull.Value ? (int?)null : dr.GetInt32(11);
                                nota.Esp2_nombre = dr.GetString(12);
                                nota.Esp2_nota = dr.GetValue(13) == DBNull.Value ? (decimal?)null : dr.GetDecimal(13);
                                nota.Esp3_id = dr.GetValue(14) == DBNull.Value ? (int?)null : dr.GetInt32(14);
                                nota.Esp3_nombre = dr.GetString(15);
                                nota.Esp3_nota = dr.GetValue(16) == DBNull.Value ? (decimal?)null : dr.GetDecimal(16);

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

        #region SeleccionaNotaXID
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

        #region SeleccionaNotaOrientaXID
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
                                //nota.Entrevista = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(3);
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

        #region Listar notas básicas 8
        public List<NotasBasicas> listarNotasBasicas8()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<NotasBasicas> lista = new List<NotasBasicas>(); ;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_curso_activo8;", conn))
                    {
                        conn.Open();
                        #region Utilizando una List de Clases
                                                MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                NotasBasicas notas = new NotasBasicas();
                                notas.idMatricula = dr.GetInt32(0);
                                notas.nombreCompleto = dr.GetString(1);
                                notas.esp1 = dr.GetValue(2) == DBNull.Value ? (decimal?)null : dr.GetDecimal(2);
                                notas.esp2 = dr.GetValue(3) == DBNull.Value ? (decimal?)null : dr.GetDecimal(3);
                                notas.esp3 = dr.GetValue(4) == DBNull.Value ? (decimal?)null : dr.GetDecimal(4);
                                notas.cie1 = dr.GetValue(5) == DBNull.Value ? (decimal?)null : dr.GetDecimal(5);
                                notas.cie2 = dr.GetValue(6) == DBNull.Value ? (decimal?)null : dr.GetDecimal(6);
                                notas.cie3 = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(7);
                                notas.estsoc1 = dr.GetValue(8) == DBNull.Value ? (decimal?)null : dr.GetDecimal(8);
                                notas.estsoc2 = dr.GetValue(9) == DBNull.Value ? (decimal?)null : dr.GetDecimal(9);
                                notas.estsoc3 = dr.GetValue(10) == DBNull.Value ? (decimal?)null : dr.GetDecimal(10);
                                notas.mat1 = dr.GetValue(11) == DBNull.Value ? (decimal?)null : dr.GetDecimal(11);
                                notas.mat2 = dr.GetValue(12) == DBNull.Value ? (decimal?)null : dr.GetDecimal(12);
                                notas.mat3 = dr.GetValue(13) == DBNull.Value ? (decimal?)null : dr.GetDecimal(13);
                                notas.ing1 = dr.GetValue(14) == DBNull.Value ? (decimal?)null : dr.GetDecimal(14);
                                notas.ing2 = dr.GetValue(15) == DBNull.Value ? (decimal?)null : dr.GetDecimal(15);
                                notas.ing3 = dr.GetValue(16) == DBNull.Value ? (decimal?)null : dr.GetDecimal(16);
                                notas.civ1 = dr.GetValue(17) == DBNull.Value ? (decimal?)null : dr.GetDecimal(17);
                                notas.civ2 = dr.GetValue(18) == DBNull.Value ? (decimal?)null : dr.GetDecimal(18);
                                notas.civ3 = dr.GetValue(19) == DBNull.Value ? (decimal?)null : dr.GetDecimal(19);
                                notas.talI1 = dr.GetValue(20) == DBNull.Value ? (decimal?)null : dr.GetDecimal(20);
                                notas.talI2 = dr.GetValue(21) == DBNull.Value ? (decimal?)null : dr.GetDecimal(21);
                                notas.talI3 = dr.GetValue(22) == DBNull.Value ? (decimal?)null : dr.GetDecimal(22);
                                notas.talII1 = dr.GetValue(23) == DBNull.Value ? (decimal?)null : dr.GetDecimal(23);
                                notas.talII2 = dr.GetValue(24) == DBNull.Value ? (decimal?)null : dr.GetDecimal(24);
                                notas.talII3 = dr.GetValue(25) == DBNull.Value ? (decimal?)null : dr.GetDecimal(25);

                                lista.Add(notas);
                            }
                            dr.Close();
                        }
                        #endregion

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

        #region Listar notas básicas 9
        public List<NotasBasicas> listarNotasBasicas9()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<NotasBasicas> lista = new List<NotasBasicas>(); ;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_curso_activo9;", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                NotasBasicas notas = new NotasBasicas();
                                notas.idMatricula = dr.GetInt32(0);
                                notas.nombreCompleto = dr.GetString(1);
                                notas.esp1 = dr.GetValue(2) == DBNull.Value ? (decimal?)null : dr.GetDecimal(2);
                                notas.esp2 = dr.GetValue(3) == DBNull.Value ? (decimal?)null : dr.GetDecimal(3);
                                notas.cie1 = dr.GetValue(4) == DBNull.Value ? (decimal?)null : dr.GetDecimal(4);
                                notas.cie2 = dr.GetValue(5) == DBNull.Value ? (decimal?)null : dr.GetDecimal(5);
                                notas.estsoc1 = dr.GetValue(6) == DBNull.Value ? (decimal?)null : dr.GetDecimal(6);
                                notas.estsoc2 = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(7);
                                notas.mat1 = dr.GetValue(8) == DBNull.Value ? (decimal?)null : dr.GetDecimal(8);
                                notas.mat2 = dr.GetValue(9) == DBNull.Value ? (decimal?)null : dr.GetDecimal(9);
                                notas.ing1 = dr.GetValue(10) == DBNull.Value ? (decimal?)null : dr.GetDecimal(10);
                                notas.ing2 = dr.GetValue(11) == DBNull.Value ? (decimal?)null : dr.GetDecimal(11);
                                notas.civ1 = dr.GetValue(12) == DBNull.Value ? (decimal?)null : dr.GetDecimal(12);
                                notas.civ2 = dr.GetValue(13) == DBNull.Value ? (decimal?)null : dr.GetDecimal(13);
                                notas.talI1 = dr.GetValue(14) == DBNull.Value ? (decimal?)null : dr.GetDecimal(14);
                                notas.talI2 = dr.GetValue(15) == DBNull.Value ? (decimal?)null : dr.GetDecimal(15);
                                notas.talII1 = dr.GetValue(16) == DBNull.Value ? (decimal?)null : dr.GetDecimal(16);
                                notas.talII2 = dr.GetValue(17) == DBNull.Value ? (decimal?)null : dr.GetDecimal(17);

                                lista.Add(notas);
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

        #region Notas x matrícula y nivel
        public NotasBasicas notasBasicasXMatricula(int mat, int nivel)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            NotasBasicas notas = new NotasBasicas();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "notas_estudiante_matricula";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pidmatricula", MySqlDbType.Int32);
                        cmd.Parameters["pidmatricula"].Value = mat;
                        cmd.Parameters["pidmatricula"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnivel", MySqlDbType.Int32);
                        cmd.Parameters["pnivel"].Value = nivel;
                        cmd.Parameters["pnivel"].Direction = ParameterDirection.Input;

                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                notas.idMatricula = dr.GetInt32(0);
                                notas.nombreCompleto = dr.GetString(1);
                                notas.id_esp1 = dr.GetValue(2) == DBNull.Value ? (int?)null : dr.GetInt32(2);
                                notas.esp1 = dr.GetValue(3) == DBNull.Value ? (decimal?)null : dr.GetDecimal(3);
                                notas.id_esp2 = dr.GetValue(4) == DBNull.Value ? (int?)null : dr.GetInt32(4);
                                notas.esp2 = dr.GetValue(5) == DBNull.Value ? (decimal?)null : dr.GetDecimal(5);
                                notas.id_esp3 = dr.GetValue(6) == DBNull.Value ? (int?)null : dr.GetInt32(6);
                                notas.esp3 = dr.GetValue(7) == DBNull.Value ? (decimal?)null : dr.GetDecimal(7);
                                notas.id_cie1 = dr.GetValue(8) == DBNull.Value ? (int?)null : dr.GetInt32(8);
                                notas.cie1 = dr.GetValue(9) == DBNull.Value ? (decimal?)null : dr.GetDecimal(9);
                                notas.id_cie2 = dr.GetValue(10) == DBNull.Value ? (int?)null : dr.GetInt32(10);
                                notas.cie2 = dr.GetValue(11) == DBNull.Value ? (decimal?)null : dr.GetDecimal(11);
                                notas.id_cie3 = dr.GetValue(12) == DBNull.Value ? (int?)null : dr.GetInt32(12);
                                notas.cie3 = dr.GetValue(13) == DBNull.Value ? (decimal?)null : dr.GetDecimal(13);
                                notas.id_estsoc1 = dr.GetValue(14) == DBNull.Value ? (int?)null : dr.GetInt32(14);
                                notas.estsoc1 = dr.GetValue(15) == DBNull.Value ? (decimal?)null : dr.GetDecimal(15);
                                notas.id_estsoc2 = dr.GetValue(16) == DBNull.Value ? (int?)null : dr.GetInt32(16);
                                notas.estsoc2 = dr.GetValue(17) == DBNull.Value ? (decimal?)null : dr.GetDecimal(17);
                                notas.id_estsoc3 = dr.GetValue(18) == DBNull.Value ? (int?)null : dr.GetInt32(18);
                                notas.estsoc3 = dr.GetValue(19) == DBNull.Value ? (decimal?)null : dr.GetDecimal(19);
                                notas.id_mat1 = dr.GetValue(20) == DBNull.Value ? (int?)null : dr.GetInt32(20);
                                notas.mat1 = dr.GetValue(21) == DBNull.Value ? (decimal?)null : dr.GetDecimal(21);
                                notas.id_mat2 = dr.GetValue(22) == DBNull.Value ? (int?)null : dr.GetInt32(22);
                                notas.mat2 = dr.GetValue(23) == DBNull.Value ? (decimal?)null : dr.GetDecimal(23);
                                notas.id_mat3 = dr.GetValue(24) == DBNull.Value ? (int?)null : dr.GetInt32(24);
                                notas.mat3 = dr.GetValue(25) == DBNull.Value ? (decimal?)null : dr.GetDecimal(25);
                                notas.id_ing1 = dr.GetValue(26) == DBNull.Value ? (int?)null : dr.GetInt32(26);
                                notas.ing1 = dr.GetValue(27) == DBNull.Value ? (decimal?)null : dr.GetDecimal(27);
                                notas.id_ing2 = dr.GetValue(28) == DBNull.Value ? (int?)null : dr.GetInt32(28);
                                notas.ing2 = dr.GetValue(29) == DBNull.Value ? (decimal?)null : dr.GetDecimal(29);
                                notas.id_ing3 = dr.GetValue(30) == DBNull.Value ? (int?)null : dr.GetInt32(30);
                                notas.ing3 = dr.GetValue(31) == DBNull.Value ? (decimal?)null : dr.GetDecimal(31);
                                notas.id_civ1 = dr.GetValue(32) == DBNull.Value ? (int?)null : dr.GetInt32(32);
                                notas.civ1 = dr.GetValue(33) == DBNull.Value ? (decimal?)null : dr.GetDecimal(33);
                                notas.id_civ2 = dr.GetValue(34) == DBNull.Value ? (int?)null : dr.GetInt32(34);
                                notas.civ2 = dr.GetValue(35) == DBNull.Value ? (decimal?)null : dr.GetDecimal(35);
                                notas.id_civ3 = dr.GetValue(36) == DBNull.Value ? (int?)null : dr.GetInt32(36);
                                notas.civ3 = dr.GetValue(37) == DBNull.Value ? (decimal?)null : dr.GetDecimal(37);
                                notas.id_talI1 = dr.GetValue(38) == DBNull.Value ? (int?)null : dr.GetInt32(38);
                                notas.talI1 = dr.GetValue(39) == DBNull.Value ? (decimal?)null : dr.GetDecimal(39);
                                notas.id_talI2 = dr.GetValue(40) == DBNull.Value ? (int?)null : dr.GetInt32(40);
                                notas.talI2 = dr.GetValue(41) == DBNull.Value ? (decimal?)null : dr.GetDecimal(41);
                                notas.id_talI3 = dr.GetValue(42) == DBNull.Value ? (int?)null : dr.GetInt32(42);
                                notas.talI3 = dr.GetValue(43) == DBNull.Value ? (decimal?)null : dr.GetDecimal(43);
                                notas.id_talII1 = dr.GetValue(44) == DBNull.Value ? (int?)null : dr.GetInt32(44);
                                notas.talII1 = dr.GetValue(45) == DBNull.Value ? (decimal?)null : dr.GetDecimal(45);
                                notas.id_talII2 = dr.GetValue(46) == DBNull.Value ? (int?)null : dr.GetInt32(46);
                                notas.talII2 = dr.GetValue(47) == DBNull.Value ? (decimal?)null : dr.GetDecimal(47);
                                notas.id_talII3 = dr.GetValue(48) == DBNull.Value ? (int?)null : dr.GetInt32(48);
                                notas.talII3 = dr.GetValue(49) == DBNull.Value ? (decimal?)null : dr.GetDecimal(49);
                            }
                            dr.Close();
                            conn.Close();
                        }
                    }
                }
                return notas;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Listar notas faltantes 8 para reporte
        public DataTable listarNotasFaltantes8(string path, string name)
        {
            DataTable table = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_faltantes8;", conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dat = new DataTable())
                            {
                                sda.Fill(dat);
                                Utilities.ExportDataSet(path, dat, name);
                                return dat;
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Listar notas faltantes 9 para reporte
        public DataTable listarNotasFaltantes9(string path, string name)
        {
            DataTable table = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_faltantes9;", conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dat = new DataTable())
                            {
                                sda.Fill(dat);
                                Utilities.ExportDataSet(path, dat, name);
                                return dat;
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Listar notas 8 para reporte
        public DataTable listarNotas8(string path, string name)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_curso_activo8;", conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dat = new DataTable())
                            {
                                sda.Fill(dat);
                                Utilities.ExportDataSet(path, dat, name);
                                return dat;
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Listar notas 9  para reporte
        public DataTable listarNotas9(string path, string name)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notas_curso_activo9;", conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            sda.SelectCommand = cmd;
                            using (DataTable dat = new DataTable())
                            {
                                sda.Fill(dat);
                                Utilities.ExportDataSet(path, dat, name);
                                return dat;
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Seleccionar nota desde anual
        public decimal seleccNotaDesdeAnual(string cedula, int nivel, int asignatura)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CALL selecc_nota_desde_anual('" + cedula + "', "+ nivel +","+ asignatura+");", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                return dr.GetDecimal(0);
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
