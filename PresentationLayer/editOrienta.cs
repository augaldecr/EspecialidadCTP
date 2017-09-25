using BussinesLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class editOrienta : Form
    {
        int Id;
        int type;

        public delegate void refreshDT();
        public event refreshDT rfDT;

        public editOrienta(int tipo)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
        }

        public editOrienta(int tipo, int id)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
            Id = id;
            llenaCampos(id);
        }

        private void llenaCampos(int id)
        {
            NotaBussines bs = new NotaBussines();
            Nota nota = bs.NotaOrientaXId(id);

            txtBoxStudent.Text = "";
            txtBoxEntrevista.Text = "";
            txtBoxVoca.Text = "";
        }

        private void asignaTitle(int tipo)
        {
            if (tipo == 1)
            {
                lblTitle.Text = "Nuevo estudiante";
                btnGuardar.Text = "Guardar";
            }
            else
            {
                lblTitle.Text = "Editar estudiante";
                btnGuardar.Text = "Modificar";
            }
        }
    }
}
