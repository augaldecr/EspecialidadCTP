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
            Espannol =1, 
            Ciencias = 2, 
            Estudios = 3, 
            Mate = 4,
            Ingles= 6,
            Civica = 11
        }

        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        string connStringPIAD = ConfigurationManager.ConnectionStrings["connStringPIAD"].ConnectionString;

        #region ListarCalificaciones
        public List<Calificaciones> ListCalificaciones()
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

                for (int curso = cursoInicial; curso <= cursoActivo; curso++)
                {
                    foreach (Matricula mat in matriculas)
                    {
                        periodos = new PeriodoData().periodosXCurso(curso);

                        Calificaciones calificacion = new Calificaciones();
                        calificacion.matricula = mat;
                        calificacion.estudiante = new EstudianteData().estudianteXId(mat.Estudiante);
                        bool tallerI8 = false;
                        bool tallerI9 = false;

                        foreach (Periodo periodo in periodos)
                        {
                            for (int nivel = 8; nivel <= 9; nivel++)
                            {
                                foreach (Asignatura asignatura in asignaturas)
                                {
                                    Nota nota = notaXParam(mat.Cedula, periodo.IdPeriodo, asignatura.IdAsignatura, nivel, mat.IdMatricula);
                                    if (nota != null)
                                    {
                                        #region Octavo
                                        if (nivel == 8)
                                        {
                                            #region Español
                                            if (nota.Asignatura == 1)
                                            {
                                                if (periodo.Nombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califEspa1Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califEspa2Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Tercer periodo"))
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
                                                if (periodo.Nombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califCiencias1Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califCiencias2Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Tercer periodo"))
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
                                                if (periodo.Nombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califEstSoc1Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califEstSoc2Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Tercer periodo"))
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
                                                if (periodo.Nombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califMate1Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califMate2Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Tercer periodo"))
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
                                                if (periodo.Nombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califIng1Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califIng2Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Tercer periodo"))
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
                                                if (periodo.Nombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califCiv1Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califCiv2Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Tercer periodo"))
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
                                                //TODO: Poner a funcionar la seleccion de taller
                                                /*
                                                if (periodo.Nombre.Contains("Primer periodo"))
                                                {
                                                    calificacion.califCiv1Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Segundo periodo"))
                                                {
                                                    calificacion.califCiv2Oct = nota;
                                                }
                                                else if (periodo.Nombre.Contains("Tercer periodo"))
                                                {
                                                    calificacion.califCiv3Oct = nota;
                                                }
                                                else
                                                {
                                                    calificacion.califCiv1Oct = nota;
                                                    calificacion.califCiv2Oct = nota;
                                                    calificacion.califCiv3Oct = nota;
                                                }*/
                                            }
                                            #endregion

                                        }
                                        #endregion
                                        #region Noveno
                                        else if (nivel == 9)
                                        {
                                            //TODO: Poner a funcionar la parte de novenos
                                        }
                                        #endregion
                                    }
                                }
                            }
                        }
                    }
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
                using (MySqlCommand cmd = new MySqlCommand("SELECT nota FROM trendimiento r INNER JOIN tmatricula m " +
                    "ON r.cedula=m.cedEstudiante WHERE r.cedula='" + cedula + "' AND r.codPeriodo=" + periodo +
                    " AND r.codAsignatura=" + asignatura + " AND m.numNivel=" + nivel + ";", connPIAD))
                {
                    Nota nota = new Nota();
                    cmd.CommandType = CommandType.Text;
                    connPIAD.Open();
                    nota.Calificacion = Convert.ToInt32(cmd.ExecuteScalar());
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
