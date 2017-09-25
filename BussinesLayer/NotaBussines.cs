using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Nota NotaOrientaXId(int id)
        {
            NotaData nt = new NotaData();
            return nt.notaOrientaXId(id);
        }
    }
}
