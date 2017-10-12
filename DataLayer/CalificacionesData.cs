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
        enum Asig
        {
            Espannol = 1,
            Ciencias = 2,
            Estudios = 3,
            Mate = 4,
            Ingles = 6,
            Civica = 11
        }

        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        string connStringPIAD = ConfigurationManager.ConnectionStrings["connStringPIAD"].ConnectionString;

        #region ListarCalificacionesTRendimiento
        public List<Calificaciones> ListCalificacionesTRendimiento()
        {
            int cursoActivo = 0;
            int cursoInicial = 0;
            List<Periodo> periodos;
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
                    Calificaciones calificacion = new Calificaciones();
                    calificacion.matricula = mat;
                    calificacion.estudiante = new EstudianteData().estudianteXId(mat.Estudiante);
                    bool tallerI = false;
                    for (int curso = cursoInicial; curso <= cursoActivo; curso++)
                    {
                            foreach (Asignatura asignatura in asignaturas)
                            {
                                for (int nivel = 8; nivel <= 9; nivel++)
                                {
                            periodos = new PeriodoData().periodosXCurso(curso);
                            foreach (Periodo periodo in periodos)
                            {
                                Nota nota = notaXParam(calificacion.estudiante.Cedula, periodo.IdPeriodo, asignatura.IdAsignatura, nivel, mat.IdMatricula);
                                    if (nota != null)
                                    {
                                        #region Octavo
                                        if (nivel == 8)
                                        {
                                            #region Español
                                            if (nota.Asignatura == 1)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califEspa1Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califEspa2Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                {
                                                    calificacion.califEspa3Oct = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califEspa1Oct = nota;
                                                    calificacion.califEspa2Oct = nota;
                                                    calificacion.califEspa3Oct = nota;
                                                }
                                            }
                                            #endregion
                                            #region Ciencias
                                            if (nota.Asignatura == 2)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califCiencias1Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califCiencias2Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                {
                                                    calificacion.califCiencias3Oct = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califCiencias1Oct = nota;
                                                    calificacion.califCiencias2Oct = nota;
                                                    calificacion.califCiencias3Oct = nota;
                                                }
                                            }
                                            #endregion
                                            #region Estudios sociales 
                                            if (nota.Asignatura == 3)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califEstSoc1Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califEstSoc2Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                {
                                                    calificacion.califEstSoc3Oct = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califEstSoc1Oct = nota;
                                                    calificacion.califEstSoc2Oct = nota;
                                                    calificacion.califEstSoc3Oct = nota;
                                                }
                                            }
                                            #endregion
                                            #region Matematica 
                                            if (nota.Asignatura == 4)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califMate1Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califMate2Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                {
                                                    calificacion.califMate3Oct = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califMate1Oct = nota;
                                                    calificacion.califMate2Oct = nota;
                                                    calificacion.califMate3Oct = nota;
                                                }
                                            }
                                            #endregion
                                            #region Inglés 
                                            if (nota.Asignatura == 6)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califIng1Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califIng2Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                {
                                                    calificacion.califIng3Oct = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califIng1Oct = nota;
                                                    calificacion.califIng2Oct = nota;
                                                    calificacion.califIng3Oct = nota;
                                                }
                                            }
                                            #endregion
                                            #region Civica 
                                            if (nota.Asignatura == 11)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califCiv1Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califCiv2Oct = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                {
                                                    calificacion.califCiv3Oct = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califCiv1Oct = nota;
                                                    calificacion.califCiv2Oct = nota;
                                                    calificacion.califCiv3Oct = nota;
                                                }
                                            }
                                            #endregion
                                            #region Talleres 
                                            if (nota.Asignatura > 11)
                                            {
                                                if (tallerI == false)
                                                {
                                                    if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                    {
                                                        calificacion.califTallI1Oct = nota;
                                                    }
                                                    else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                    {
                                                        calificacion.califTallI2Oct = nota;
                                                    }
                                                    else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                    {
                                                        calificacion.califTallI3Oct = nota;
                                                    }
                                                    else
                                                    {
                                                        calificacion.califTallI1Oct = nota;
                                                        calificacion.califTallI2Oct = nota;
                                                        calificacion.califTallI3Oct = nota;
                                                    }
                                                    tallerI = true;
                                                }
                                                else
                                                {
                                                    if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                    {
                                                        calificacion.califTallII1Oct = nota;
                                                    }
                                                    else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                    {
                                                        calificacion.califTallII2Oct = nota;
                                                    }
                                                    else if (nota.PeriodoNombre.Contains("Tercer periodo"))
                                                    {
                                                        calificacion.califTallII3Oct = nota;
                                                    }
                                                    else
                                                    {
                                                        calificacion.califTallII1Oct = nota;
                                                        calificacion.califTallII2Oct = nota;
                                                        calificacion.califTallII3Oct = nota;
                                                    }
                                                    tallerI = false;
                                                }
                                            }
                                            #endregion
                                        }
                                        #endregion
                                        #region Noveno
                                        else if (nivel == 9)
                                        {
                                            #region Español
                                            if (nota.Asignatura == 1)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califEspa1Nov = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califEspa2Nov = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califEspa1Nov = nota;
                                                    calificacion.califEspa2Nov = nota;
                                                }
                                            }
                                            #endregion
                                            #region Ciencias
                                            if (nota.Asignatura == 2)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califCiencias1Nov = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califCiencias2Nov = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califCiencias1Nov = nota;
                                                    calificacion.califCiencias2Nov = nota;
                                                }
                                            }
                                            #endregion
                                            #region Estudios sociales 
                                            if (nota.Asignatura == 3)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califEstSoc1Nov = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califEstSoc2Nov = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califEstSoc1Nov = nota;
                                                    calificacion.califEstSoc2Nov = nota;
                                                }
                                            }
                                            #endregion
                                            #region Matematica 
                                            if (nota.Asignatura == 4)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califMate1Nov = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califMate2Nov = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califMate1Nov = nota;
                                                    calificacion.califMate2Nov = nota;
                                                }
                                            }
                                            #endregion
                                            #region Inglés 
                                            if (nota.Asignatura == 6)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califIng1Nov = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califIng2Nov = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califIng1Nov = nota;
                                                    calificacion.califIng2Nov = nota;
                                                }
                                            }
                                            #endregion
                                            #region Civica 
                                            if (nota.Asignatura == 11)
                                            {
                                                if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califCiv1Nov = nota;
                                                }
                                                else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califCiv2Nov = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califCiv1Nov = nota;
                                                    calificacion.califCiv2Nov = nota;
                                                }
                                            }
                                            #endregion
                                            #region Talleres 
                                            if (nota.Asignatura > 11)
                                            {
                                                if (tallerI == false)
                                                {
                                                    if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                    {
                                                        calificacion.califTallI1Nov = nota;
                                                    }
                                                    else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                    {
                                                        calificacion.califTallI2Nov = nota;
                                                    }
                                                    else
                                                    {
                                                        calificacion.califTallI1Nov = nota;
                                                        calificacion.califTallI2Nov = nota;
                                                    }
                                                    tallerI = true;
                                                }
                                                else
                                                {
                                                    if (nota.PeriodoNombre.Contains("Primer periodo"))
                                                    {
                                                        calificacion.califTallII1Nov = nota;
                                                    }
                                                    else if (nota.PeriodoNombre.Contains("Segundo periodo"))
                                                    {
                                                        calificacion.califTallII2Nov = nota;
                                                    }
                                                    else
                                                    {
                                                        calificacion.califTallII1Nov = nota;
                                                        calificacion.califTallII2Nov = nota;
                                                    }
                                                    tallerI = false;
                                                }
                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                }
                            }
                        }
                    }
                    calificaciones.Add(calificacion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return calificaciones;
        }

        private Nota notaXParam(string cedula, int periodo, int asignatura, int nivel, int idMatricula)
        {
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
    #endregion
}
