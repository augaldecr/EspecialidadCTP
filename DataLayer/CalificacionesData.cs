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
        public delegate void AddAvanceDT();
        public event AddAvanceDT addAvanceDT;

        #region ListarCalificacionesTRendimiento
        public List<Calificaciones> ListCalificacionesTRendimiento()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            int cursoActivo = 0;
            int cursoInicial = 0;
            List<Matricula> matriculas;
            List<Calificaciones> calificaciones = new List<Calificaciones>();
            List<Asignatura> asignaturas = new List<Asignatura>();

            try
            {
                cursoActivo = new CursoLectivoData().CursoActivo();
                cursoInicial = cursoActivo - 2;

                matriculas = new MatriculaData().MatriculasXCursoLectivo(cursoActivo);
                asignaturas = new AsignaturaData().listarAsignaturas();

                foreach (Matricula mat in matriculas)
                {
                    calificaciones.Add(calificacion(mat, cursoInicial, cursoActivo,
                        asignaturas));
                    addAvanceDT();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return calificaciones;
        }

        private Calificaciones calificacion(Matricula mat, int cursoInicial,
            int cursoActivo, List<Asignatura> asignaturas)
        {
            Calificaciones calificacion = new Calificaciones();
            calificacion.matricula = mat;
            calificacion.estudiante = new EstudianteData().estudianteXId(mat.Estudiante);
            int tallerI8 = 0;
            int tallerI9 = 0;
            List<Periodo> periodos;

            foreach (Asignatura asig in new AsignaturaData().listarTalleresXCedula(calificacion.estudiante.Cedula))
            {
                asignaturas.Add(asig);
            }

            for (int nivel = 8; nivel <= 9; nivel++)
            {
                foreach (Asignatura asignatura in asignaturas)
                {
                    for (int curso = cursoInicial; curso <= cursoActivo; curso++)
                    {
                        periodos = new PeriodoData().periodosXCurso(curso);
                        foreach (Periodo periodo in periodos)
                        {
                            Nota nota = notaXParam(calificacion.estudiante.Cedula, periodo.IdPeriodo, asignatura.IdAsignatura, nivel, mat.IdMatricula);
                            if (nota != null)
                            {
                                #region Talleres 
                                if (nota.Asignatura > 11)
                                {
                                    #region Seleccion de taller 1 para octavo
                                    if (nota.Nivel == 8)
                                    {

                                        if (tallerI8 == 0)
                                        {
                                            tallerI8 = (int)nota.Asignatura;
                                        }

                                        #region Selección de taller 1 o 2
                                        if (tallerI8 == nota.Asignatura)
                                        {
                                            nota.Asignatura = 312;
                                        }
                                        else
                                        {
                                            nota.Asignatura = 313;
                                        }
                                        #endregion
                                    }
                                    #endregion
                                    #region Seleccion de taller 1 para noveno
                                    if (nota.Nivel == 9)
                                    {
                                        if (tallerI9 == 0)
                                        {
                                            tallerI9 = (int)nota.Asignatura;
                                        }

                                        #region Selección de taller 1 o 2
                                        if (tallerI9 == nota.Asignatura)
                                        {
                                            nota.Asignatura = 312;
                                        }
                                        else
                                        {
                                            nota.Asignatura = 313;
                                        }
                                        #endregion
                                    }
                                    #endregion
                                }
                                #endregion

                                #region Selección de período
                                if (nota.PeriodoNombre.Contains("Primer periodo") ||
                                        nota.PeriodoNombre.Contains("Segundo periodo") ||
                                        nota.PeriodoNombre.Contains("Tercer periodo"))
                                {
                                    if (nota.PeriodoNombre.Contains("Primer periodo"))
                                    {
                                        nota.Periodo = 1;
                                    }
                                    else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                    {
                                        nota.Periodo = 2;
                                    }
                                    else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                    {
                                        nota.Periodo = 3;
                                    }
                                    calificacion.Notas.Add(nota);
                                    Console.WriteLine(nota.Matricula + ", " + nota.Asignatura + ", " + nota.Nivel + ", " + nota.Periodo + ", " + nota.Calificacion);
                                }
                                else
                                {
                                    calificacion.Notas.RemoveAll(n =>
                                        n.Matricula == nota.Matricula &&
                                        n.Asignatura == nota.Asignatura &&
                                        n.Nivel == nota.Nivel);

                                    calificacion.Notas.Add(new Nota()
                                    {
                                        Asignatura = nota.Asignatura,
                                        Calificacion = nota.Calificacion,
                                        Matricula = nota.Matricula,
                                        Nivel = nota.Nivel,
                                        Periodo = 1,
                                        PeriodoNombre = "Primer periodo",
                                    });
                                    Console.WriteLine(nota.Matricula + ", " + nota.Asignatura + ", " + nota.Nivel + ", " + nota.Periodo + ", " + nota.Calificacion);

                                    calificacion.Notas.Add(new Nota()
                                    {
                                        Asignatura = nota.Asignatura,
                                        Calificacion = nota.Calificacion,
                                        Matricula = nota.Matricula,
                                        Nivel = nota.Nivel,
                                        Periodo = 2,
                                        PeriodoNombre = "Segundo periodo",
                                    });
                                    Console.WriteLine(nota.Matricula + ", " + nota.Asignatura + ", " + nota.Nivel + ", " + nota.Periodo + ", " + nota.Calificacion);

                                    calificacion.Notas.Add(new Nota()
                                    {
                                        Asignatura = nota.Asignatura,
                                        Calificacion = nota.Calificacion,
                                        Matricula = nota.Matricula,
                                        Nivel = nota.Nivel,
                                        Periodo = 3,
                                        PeriodoNombre = "Tercer periodo",
                                    });
                                    Console.WriteLine(nota.Matricula + ", " + nota.Asignatura + ", " + nota.Nivel + ", " + nota.Periodo + ", " + nota.Calificacion);
                                }
                                #endregion
                            }
                        }
                    }
                }
            }
            return calificacion;
        }

        private Nota notaXParam(string cedula, int periodo, int asignatura, int nivel, int idMatricula)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            #region SQL con texto
            /*using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //TODO: Selecciona la nota de trendimiento
                /*using (MySqlCommand cmd = new MySqlCommand("SELECT nota, periodo, tipo FROM ctp_noveno.notas_trendimiento " +
                    "WHERE cedula='" + cedula + "' AND codPeriodo=" + periodo +
                    " AND codAsignatura=" + asignatura + " AND numNivel=" + nivel + ";", conn))
                using (MySqlCommand cmd = new MySqlCommand("SELECT nota, periodo, tipo FROM ctp_noveno.notas_trendimiento " +
                    "WHERE cedula='" + cedula + "' AND codPeriodo=" + periodo +
                    " AND codAsignatura=" + asignatura + " AND numNivel=" + nivel + ";", conn))
                {
                    Nota nota = new Nota();
                    cmd.CommandType = CommandType.Text;
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.FieldCount > 0)
                    {
                        while (dr.Read())
                        {
                            nota.Calificacion = dr.GetDecimal(0);
                            nota.PeriodoNombre = dr.GetString(1);
                            //nota.Tipo = dr.GetInt32(2);
                        }
                        dr.Close();
                    }
                    conn.Close();*/
            #endregion
            using (MySqlConnection conn = new MySqlConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Nota nota = new Nota();

                    conn.ConnectionString = connString;
                    conn.Open();
                    
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "nota_x_param_viejo";

                    cmd.Parameters.Add("@pnumNivel", MySqlDbType.Int32).Value = nivel;
                    cmd.Parameters.Add("@pcodPeriodo", MySqlDbType.Int32).Value = periodo;
                    cmd.Parameters.Add("@pasignatura", MySqlDbType.Int32).Value = asignatura;
                    cmd.Parameters.Add("@pcedula", MySqlDbType.VarChar).Value = cedula;

                    MySqlParameter pnota = new MySqlParameter();
                    pnota.ParameterName = "@pnota";
                    pnota.Direction = ParameterDirection.Output;
                    pnota.MySqlDbType = MySqlDbType.Decimal;
                    cmd.Parameters.Add(pnota);

                    MySqlParameter pperiodo = new MySqlParameter();
                    pperiodo.ParameterName = "@pperiodo";
                    pperiodo.Direction = ParameterDirection.Output;
                    pperiodo.MySqlDbType = MySqlDbType.VarChar;
                    cmd.Parameters.Add(pperiodo);

                    cmd.ExecuteNonQuery();

                    nota.Calificacion = cmd.Parameters["@pnota"].Value == DBNull.Value ? 0 : (Decimal)cmd.Parameters["@pnota"].Value;
                    nota.PeriodoNombre = cmd.Parameters["@pperiodo"].Value == DBNull.Value ? null : (string)cmd.Parameters["@pperiodo"].Value;

                    conn.Close();

                    if (nota.Calificacion > 100)
                    {
                        nota.Calificacion = 100;
                    }

                    if (nota.Calificacion > 0)
                    {
                        nota.Matricula = idMatricula;
                        nota.Asignatura = asignatura;
                        nota.Nivel = nivel;
                        nota.Periodo = periodo;
                        return nota;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        #endregion
    }
}
