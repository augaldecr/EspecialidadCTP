using DataLayer;
using Entities;
using System;
using System.Collections.Generic;

namespace BussinesLayer
{
    public class NotaBussines
    {
        public List<Nota> listarNotasOrienta()
        {
            NotaData ndt = new NotaData();
            return ndt.ListNotasOrienta();
        }

        public List<Nota> listarNotas()
        {
            NotaData ndt = new NotaData();
            return ndt.ListNotas();
        }

        public List<NotasBasicas> listarNotasBasicas8()
        {
            NotaData ndt = new NotaData();
            return ndt.listarNotasBasicas8();
        }

        public Nota NotaOrientaXId(int id)
        {
            NotaData nt = new NotaData();
            return nt.notaOrientaXId(id);
        }
        
        public NotasBasicas notasBasicasXMatYNivel(int mat, int nivel)
        {
            return new NotaData().notasBasicasXMatricula(mat, nivel);
        }

        public void editNotaOrienta(int id, decimal entrevista, decimal vocacional)
        {
            NotaData dt = new NotaData();
            try
            {
                dt.ActualizaNotaOrienta(new Nota
                {
                    IdNota = id,
                    Entrevista = entrevista,
                    Vocacional = vocacional
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void delNota(int id)
        {
            NotaData nota = new NotaData();
            nota.BorraNota(id);
        }

        public void delNotaOrienta(int id)
        {
            NotaData nota = new NotaData();
            nota.BorraNotaOrienta(id);
        }

        public void delNotasXMatYNivel(int mat, int nivel)
        {
            NotaData nota = new NotaData();
            nota.BorraNotasXMatYNivel(mat, nivel);
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

        public void guardarNotaOrienta(int matricula, int curso, decimal entrevista, decimal vocacional)
        {
            NotaData dt = new NotaData();
            try
            {
                dt.GuardaNotaOrienta(new Nota
                {
                    Matricula = matricula,
                    Curso_lectivo = curso,
                    Entrevista = entrevista,
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
