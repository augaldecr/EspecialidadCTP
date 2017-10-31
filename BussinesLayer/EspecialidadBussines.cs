using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace BussinesLayer
{
    public class EspecialidadBussines
    {
        public List<Especialidad> listar()
        {
            try
            {
                EspecialidadData espe = new EspecialidadData();
                return espe.ListEspecialidad();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarEspecXEstud(string path)
        {
            try
            {
                return new EspecialidadData().listEspecXEstud(path);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarEstudXEspec(string path)
        {
            DataTable dt = new DataTable();
            string directorio = "\\Estudiantes_por_especialidad";
            string path0 = path;

            try
            {
                if (!Directory.Exists(string.Format("{0}{1}", path, directorio)))
                {
                    Directory.CreateDirectory(string.Format("{0}{1}", path, directorio));
                }
                path = string.Format("{0}{1}", path, directorio);

                foreach (Especialidad espe in new EspecialidadData().ListEspecialidad())
                {
                    path = string.Format("{0}\\{1}",path,(string.Format("{0}{1}",espe.Nombre,".xlsx")));
                    dt.Merge(new EspecialidadData().listEstudXEspecialidad(espe.idEspecialidad, path));
                    path = string.Format("{0}{1}", path0, directorio);
                }
                return dt;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarIncosistencias(string path)
        {
            try
            {
                return new EspecialidadData().listErroneas(path);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
