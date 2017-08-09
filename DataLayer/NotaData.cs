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
    public class NotaData : Nota
    {
        #region GuardarNota
        public void GuardaNota()
        {
            string connString = ConfigurationManager.AppSettings["connString"];

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
                        cmd.Parameters["estudiante"].Value = Matricula;
                        cmd.Parameters["estudiante"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("asignatura", MySqlDbType.Int16);
                        cmd.Parameters["asignatura"].Value = Asignatura;
                        cmd.Parameters["asignatura"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("nivel", MySqlDbType.Int16);
                        cmd.Parameters["nivel"].Value = Nivel;
                        cmd.Parameters["nivel"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("periodo", MySqlDbType.Int16);
                        cmd.Parameters["periodo"].Value = Periodo;
                        cmd.Parameters["periodo"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("nota", MySqlDbType.Decimal);
                        cmd.Parameters["nota"].Value = Calificacion;
                        cmd.Parameters["nota"].Direction = ParameterDirection.Input;

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

        #region ActualizarNota
        public void ActualizaNota()
        {
            string connString = ConfigurationManager.AppSettings["connString"];

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
                        cmd.Parameters["pidnota"].Value = IdNota;
                        cmd.Parameters["pidnota"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pestudiante", MySqlDbType.Int16);
                        cmd.Parameters["pestudiante"].Value = Matricula;
                        cmd.Parameters["pestudiante"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pasignatura", MySqlDbType.Int16);
                        cmd.Parameters["pasignatura"].Value = Asignatura;
                        cmd.Parameters["pasignatura"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnivel", MySqlDbType.Int16);
                        cmd.Parameters["pnivel"].Value = Nivel;
                        cmd.Parameters["pnivel"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pperiodo", MySqlDbType.Int16);
                        cmd.Parameters["pperiodo"].Value = Periodo;
                        cmd.Parameters["pperiodo"].Direction = ParameterDirection.Input;
                        cmd.Parameters.Add("pnota", MySqlDbType.Decimal);
                        cmd.Parameters["pnota"].Value = Calificacion;
                        cmd.Parameters["pnota"].Direction = ParameterDirection.Input;

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

        #region BorrarNota
        public void BorraNota()
        {
            string connString = ConfigurationManager.AppSettings["connString"];

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
                        cmd.Parameters["pidnota"].Value = IdNota;
                        cmd.Parameters["pidnota"].Direction = ParameterDirection.Input;

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
    }
}
