using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BussinesLayer
{
    public class NotaBussines
    {
        public List<Nota> listarNotasOrienta()
        {
            try
            {
                return new NotaData().ListNotasOrienta();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Nota> listarNotas()
        {
            try
            {
                return new NotaData().ListNotas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<NotasBasicas> listarNotasBasicas8()
        {
            try
            {
                return new NotaData().listarNotasBasicas8();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarNotasFaltantes8(string path, string name)
        {
            try
            {
                return new NotaData().listarNotasFaltantes8(path, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal SeleccNotaDesdeAnual(string cedula, int nivel, int asignatura)
        {
            try
            {
                return new NotaData().seleccNotaDesdeAnual(cedula, nivel, asignatura);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarNotas8(string path, string name)
        {
            try
            {
                return new NotaData().listarNotas8(path, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<NotasBasicas> listarNotasBasicas9()
        {
            try
            {
                return new NotaData().listarNotasBasicas9();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarNotasFaltantes9(string path, string name)
        {
            try
            {
                return new NotaData().listarNotasFaltantes9(path, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable listarNotas9(string path, string name)
        {
            try
            {
                return new NotaData().listarNotas9(path, name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Nota NotaOrientaXId(int id)
        {
            try
            {
                return new NotaData().notaOrientaXId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public NotasBasicas notasBasicasXMatYNivel(int mat, int nivel)
        {
            try
            {
                return new NotaData().notasBasicasXMatricula(mat, nivel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void editNotaOrienta(int id, decimal vocacional)
        {
            try
            {
                new NotaData().ActualizaNotaOrienta(new Nota
                {
                    IdNota = id,
                    Vocacional = vocacional
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void editNotaEleccEspe(int id, decimal nota)
        {
            try
            {
                new NotaData().ActualizaNotaEleccEsp(new Nota
                {
                    IdNota = id,
                    Calificacion = nota
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void EditNotaEleccEspXMatYEsp(Nota nota)
        {
            try
            {
                new NotaData().ActualizaNotaEleccEspXMatYEsp(nota);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void delNota(int id)
        {
            try
            {
                new NotaData().BorraNota(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delNotaOrienta(int id)
        {
            try
            {
                new NotaData().BorraNotaOrienta(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delNotaOrientaXMatricula(int mat)
        {
            try
            {
                new NotaData().BorraNotaOrientaXMAt(mat);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delNotasXMatYNivel(int mat, int nivel)
        {
            try
            {
                new NotaData().BorraNotasXMatYNivel(mat, nivel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delNotasXMatNivelAsig(int mat, int nivel, int asig)
        {
            try
            {
                new NotaData().BorraNotasXMatNivelAsig(mat, nivel, asig);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void guardarNota(Nota nota)
        {
            try
            {
                new NotaData().GuardaNota(nota);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void guardarNotaOrienta(int matricula, decimal vocacional)
        {
            try
            {
                new NotaData().GuardaNotaOrienta(new Nota
                {
                    Matricula = matricula,
                    Vocacional = vocacional
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void editNota(Nota nota)
        {
            try
            {
                new NotaData().ActualizaNota(nota);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
