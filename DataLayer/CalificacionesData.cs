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

            int prueba = 0;

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
                    prueba++;
                    if (prueba == 3)
                    {
                        break;
                    }
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
            int tallerI = 0;
            List<Periodo> periodos;

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
                                    if (tallerI == 0)
                                    {
                                        tallerI = (int)nota.Asignatura;
                                    }

                                    #region Selección de taller 1 o 2
                                    if (tallerI == nota.Asignatura)
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
                                }
                                else
                                {
                                    calificacion.Notas.RemoveAll(
                                        n => n.Matricula == nota.Matricula &&
                                        n.Asignatura == nota.Asignatura &&
                                        n.Nivel == nota.Nivel);

                                    nota.Periodo = 1;
                                    calificacion.Notas.Add(nota);
                                    nota.Periodo = 2;
                                    calificacion.Notas.Add(nota);
                                    nota.Periodo = 3;
                                    calificacion.Notas.Add(nota);
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
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //TODO: Selecciona la nota de trendimiento
                using (MySqlCommand cmd = new MySqlCommand("SELECT nota, periodo, tipo FROM notas_trendimiento " +
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
                            nota.Tipo = dr.GetInt32(2);
                        }
                        dr.Close();
                    }
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
                    }/*else if(nota.Calificacion == 0 && nota.Tipo == 2)
                    {
                        nota.Matricula = idMatricula;
                        nota.Asignatura = asignatura;
                        nota.Nivel = nivel;
                        nota.Periodo = periodo;
                        nota.Calificacion = null;
                        return nota;
                    } */
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
