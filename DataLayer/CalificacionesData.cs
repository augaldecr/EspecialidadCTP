using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;

namespace DataLayer
{
    public class CalificacionesData
    {
        StringBuilder sb;

        public delegate void AddAvanceDT();
        public event AddAvanceDT addAvanceDT;

        int tallerI8 = 0;
        int tallerII8 = 0;
        int tallerI9 = 0;
        int tallerII9 = 0;

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
                    foreach (Asignatura asig in new AsignaturaData().listarTalleresXCedula(new EstudianteData().estudianteXId(mat.Estudiante).Cedula))
                    {
                        asignaturas.Add(asig);
                        if (asig.Nivel == 8)
                        {
                            if (tallerI8 == 0 && tallerII8 == 0)
                            {
                                tallerI8 = asig.IdAsignatura;
                            }
                            else if (tallerI8 != 0 && tallerII8 == 0)
                            {
                                tallerII8 = asig.IdAsignatura;
                            }
                        }
                        if (asig.Nivel == 9)
                        {
                            if (tallerI9 == 0 && tallerII9 == 0)
                            {
                                tallerI9 = asig.IdAsignatura;
                            }
                            else if (tallerI9 != 0 && tallerII9 == 0)
                            {
                                tallerII9 = asig.IdAsignatura;
                            }
                        }
                    }
                    calificaciones.Add(calificacion(mat, cursoInicial, cursoActivo,
                        asignaturas));
                    addAvanceDT();

                    tallerI8 = 0;
                    tallerII8 = 0;
                    tallerI9 = 0;
                    tallerII9 = 0;
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

            for (int nivel = 8; nivel <= 9; nivel++)
            {
                foreach (Asignatura asignatura in asignaturas)
                {
                    List<Nota> notas = notasXParam(calificacion.estudiante.Cedula, asignatura.IdAsignatura, nivel, mat.IdMatricula);
                    foreach (Nota nota in notas)
                    {
                        #region Talleres 
                        if (nota.Asignatura > 11)
                        {
                            #region Seleccion de taller 1 para octavo
                            if (nota.Nivel == 8)
                            {
                                #region Selección de taller 1 o 2
                                if (nota.Asignatura == tallerI8)
                                {
                                    nota.Asignatura = 312;
                                }
                                else if (nota.Asignatura == tallerII8)
                                {
                                    nota.Asignatura = 313;
                                }
                                #endregion
                            }
                            #endregion
                            #region Seleccion de taller 1 para noveno
                            if (nota.Nivel == 9)
                            {
                                #region Selección de taller 1 o 2
                                if (nota.Asignatura == tallerI9)
                                {
                                    nota.Asignatura = 312;
                                }
                                else if (nota.Asignatura == tallerII9)
                                {
                                    nota.Asignatura = 313;
                                }
                                #endregion
                            }
                            #endregion
                        }
                        #endregion

                        #region Selección de período
                        if (nota.PeriodoNombre.Contains("Primer per") ||
                                nota.PeriodoNombre.Contains("Segundo per") ||
                                nota.PeriodoNombre.Contains("Tercer per"))
                        {
                            int per = 0;

                            if (nota.PeriodoNombre.Contains("Primer per"))
                            {
                                nota.Periodo = 1;
                                per = 1;
                            }
                            else if (nota.PeriodoNombre.Contains("Segundo per"))
                            {
                                nota.Periodo = 2;
                                per = 2;
                            }
                            else if (nota.PeriodoNombre.Contains("Tercer per"))
                            {
                                nota.Periodo = 3;
                                per = 3;
                            }

                            calificacion.Notas.RemoveAll(n =>
                                n.Asignatura == nota.Asignatura &&
                                n.Nivel == nota.Nivel &&
                                n.Periodo == per);

                            if (nota.Asignatura <= 11 || nota.Asignatura == 312 || nota.Asignatura == 313)
                            {
                                calificacion.Notas.Add(nota);
                            }

                            per = 0;
                        }
                        else
                        {
                            calificacion.Notas.RemoveAll(n =>
                                n.Asignatura == nota.Asignatura &&
                                n.Nivel == nota.Nivel);
                            if (nota.Nivel == 8)
                            {
                                calificacion.Notas.RemoveAll(n =>
                                n.Asignatura == nota.Asignatura &&
                                n.Nivel == 8);

                                Nota nota1 = new Nota()
                                {
                                    Asignatura = nota.Asignatura,
                                    Calificacion = nota.Calificacion,
                                    Matricula = nota.Matricula,
                                    Nivel = nota.Nivel,
                                    Periodo = 1,
                                    PeriodoNombre = "Primer periodo",
                                };
                                if (nota1.Asignatura <= 11 || nota1.Asignatura == 312 || nota1.Asignatura == 313)
                                {
                                    calificacion.Notas.Add(nota1);
                                }
                                nota1 = null;

                                Nota nota2 = new Nota()
                                {
                                    Asignatura = nota.Asignatura,
                                    Calificacion = nota.Calificacion,
                                    Matricula = nota.Matricula,
                                    Nivel = nota.Nivel,
                                    Periodo = 2,
                                    PeriodoNombre = "Segundo periodo",
                                };
                                if (nota2.Asignatura <= 11 || nota2.Asignatura == 312 || nota2.Asignatura == 313)
                                {
                                    calificacion.Notas.Add(nota2);
                                }
                                nota2 = null;

                                Nota nota3 = new Nota()
                                {
                                    Asignatura = nota.Asignatura,
                                    Calificacion = nota.Calificacion,
                                    Matricula = nota.Matricula,
                                    Nivel = nota.Nivel,
                                    Periodo = 3,
                                    PeriodoNombre = "Tercer periodo",
                                };
                                if (nota3.Asignatura <= 11 || nota3.Asignatura == 312 || nota3.Asignatura == 313)
                                {
                                    calificacion.Notas.Add(nota3);
                                }
                                nota3 = null;
                            }
                            if (nota.Nivel == 9)
                            {
                                calificacion.Notas.RemoveAll(n =>
                                    n.Asignatura == nota.Asignatura &&
                                    n.Nivel == 9);
                                Nota nota1 = new Nota()
                                {
                                    Asignatura = nota.Asignatura,
                                    Calificacion = nota.Calificacion,
                                    Matricula = nota.Matricula,
                                    Nivel = nota.Nivel,
                                    Periodo = 1,
                                    PeriodoNombre = "Primer periodo",
                                };
                                if (nota1.Asignatura <= 11 || nota1.Asignatura == 312 || nota1.Asignatura == 313)
                                {
                                    calificacion.Notas.Add(nota1);
                                }
                                nota1 = null;

                                Nota nota2 = new Nota()
                                {
                                    Asignatura = nota.Asignatura,
                                    Calificacion = nota.Calificacion,
                                    Matricula = nota.Matricula,
                                    Nivel = nota.Nivel,
                                    Periodo = 2,
                                    PeriodoNombre = "Segundo periodo",
                                };
                                if (nota2.Asignatura <= 11 || nota2.Asignatura == 312 || nota2.Asignatura == 313)
                                {
                                    calificacion.Notas.Add(nota2);
                                }
                                nota2 = null;
                            }
                        }
                        #endregion
                    }
                }
            }

            try
            {
                foreach (Nota nota in calificacion.Notas)
                {
                    sb.Append("Matricula: " + nota.Matricula + ", Nivel: " + nota.Nivel + ", Asignatura: " + nota.Asignatura +
                        ", Período: " + nota.Periodo + ", Calificación: " + nota.Calificacion);
                }

                File.AppendAllText("log.txt", sb.ToString());
                sb.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return calificacion;
        }

        private List<Nota> notasXParam(string cedula, int asignatura, int nivel, int idMatricula)
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            List<Nota> notas = new List<Nota>();

            using (MySqlConnection conn = new MySqlConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    Nota nota = new Nota();

                    conn.ConnectionString = connString;
                    conn.Open();

                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "nota_x_param";

                    cmd.Parameters.Add("@pnumNivel", MySqlDbType.Int32).Value = nivel;
                    cmd.Parameters.Add("@pasignatura", MySqlDbType.Int32).Value = asignatura;
                    cmd.Parameters.Add("@pcedula", MySqlDbType.VarChar).Value = cedula;

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.FieldCount > 0)
                    {
                        while (dr.Read())
                        {
                            Nota not = new Nota
                            {
                                Calificacion = dr.GetValue(0) == DBNull.Value ? (decimal?)null : dr.GetDecimal(0),
                                Asignatura = dr.GetValue(1) == DBNull.Value ? (int?)null : dr.GetInt32(1),
                                PeriodoNombre = dr.GetString(2)
                            };

                            if (not.Calificacion > 100)
                            {
                                not.Calificacion = 100;
                            }

                            if (not.Calificacion > 0)
                            {
                                not.Matricula = idMatricula;
                                not.Nivel = nivel;
                                notas.Add(not);
                            }
                        }
                        dr.Close();
                        conn.Close();
                    }
                }
            }
            return notas;
        }
#endregion
    }
}