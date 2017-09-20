using DataLayer;
using Entities;
using System;
using System.Collections.Generic;

namespace BussinesLayer
{
    public class EstudiantesBussines
    {
        public List<Estudiante> listar()
        {
            EstudianteData estu = new EstudianteData();
            return estu.ListEstudiante();
        }

        public Estudiante estudianteXID(int id)
        {
            EstudianteData dt = new EstudianteData();
            return dt.estudianteXId(id);
        }

        public int iDEstudianteXCedula(string cedula)
        {
            EstudianteData est = new EstudianteData();
            return est.idEstudianteXCedula(cedula);
        }

        public void guardarEstudiante(Estudiante est)
        {
            EstudianteData dt = new EstudianteData();
            try
            {
                dt.GuardaEstudiante(est);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificaEstudiante(Estudiante est)
        {
            EstudianteData dt = new EstudianteData();
            try
            {
                dt.ActualizaEstudiante(est);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
