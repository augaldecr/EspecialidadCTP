using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace DataLayer
{
    public class GrupoData
    {

        #region ListGrupos
        public List<Grupo> ListGrupo()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            List<Grupo> lista = new List<Grupo>(); ;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM grupos_curso_activo;", conn))
                    {
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.FieldCount > 0)
                        {
                            while (dr.Read())
                            {
                                Grupo grp = new Grupo();
                                grp.IdGrupo = int.Parse(dr[0].ToString());
                                grp.Numero = dr[1].ToString();

                                lista.Add(grp);
                            }
                            dr.Close();
                        }
                        conn.Close();
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
