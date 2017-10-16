using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class MatriculaBussines
    {
        public void guardarMatricula(Matricula mat)
        {
            MatriculaData dt = new MatriculaData();
            try
            {
                dt.GuardaMatricula(mat);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificaMatricula(Matricula mat)
        {
            MatriculaData dt = new MatriculaData();
            try
            {
                dt.ActualizaMatricula(mat);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int idMatriculaXEstudiante(int est)
        {
            MatriculaData matriculaData = new MatriculaData();
            return matriculaData.IdMatriculaXEstudiante(est);
        }

        public Matricula matriculaXEstudiante(int est)
        {
            MatriculaData matriculaData = new MatriculaData();
            return matriculaData.matriculaXEstudiante(est);
        }

        public void borrarMatricula(int id)
        {
            MatriculaData dt = new MatriculaData();
            try
            {
                dt.BorraMatricula(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int qtyMatsCursoActivo()
        {
            return new MatriculaData().qtyMatsXCursoActivo();
        }

    }
}
