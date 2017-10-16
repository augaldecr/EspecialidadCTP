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
                cursoInicial = cursoActivo - 1;

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
        #endregion

        private Calificaciones calificacion(Matricula mat, int cursoInicial,
            int cursoActivo, List<Asignatura> asignaturas)
        {
            Calificaciones calificacion = new Calificaciones();
            calificacion.matricula = mat;
            calificacion.estudiante = new EstudianteData().estudianteXId(mat.Estudiante);
            bool tallerI = false;
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
                                    #region Selección de taller 1 o 2
                                    if (tallerI == false)
                                    {
                                        nota.Asignatura = 12;
                                        tallerI = true;
                                    }
                                    else
                                    {
                                        nota.Asignatura = 13;
                                        tallerI = false;
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
            string connStringPIAD = ConfigurationManager.ConnectionStrings["connStringPIAD"].ConnectionString;
            using (MySqlConnection connPIAD = new MySqlConnection(connStringPIAD))
            {
                //TODO: Selecciona la nota de trendimiento
                using (MySqlCommand cmd = new MySqlCommand("SELECT nota, periodo FROM trendimiento r " +
                    "INNER JOIN ctp_noveno.asignaturas a ON r.codAsignatura=a.idasignatura " +
                    "INNER JOIN bdpiiad2.tperiodos p ON r.codPeriodo=p.idperiodo " +
                    "INNER JOIN bdpiiad2.tmatricula m ON r.cedula=m.cedEstudiante AND p.curso_lectivo=codCursoLectivo " +
                    "WHERE r.cedula='" + cedula + "' AND r.codPeriodo=" + periodo +
                    " AND r.codAsignatura=" + asignatura + " AND m.numNivel=" + nivel + ";", connPIAD))
                {
                    Nota nota = new Nota();
                    cmd.CommandType = CommandType.Text;
                    connPIAD.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.FieldCount > 0)
                    {
                        while (dr.Read())
                        {
                            nota.Calificacion = dr.GetDecimal(0);
                            nota.PeriodoNombre = dr.GetString(1);
                        }
                        dr.Close();
                    }
                    connPIAD.Close();
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
    }
}
