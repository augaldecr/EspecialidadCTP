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

        public void delNotaOrienta(int id)
        {
            NotaData nota = new NotaData();
            nota.BorraNota(id);
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

        public void editNota(int id)
        {
            NotaData dt = new NotaData();
            try
            {
                dt.ActualizaNotaOrienta(new Nota
                {
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
