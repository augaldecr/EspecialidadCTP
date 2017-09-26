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

        public delegate void refreshDTOri();
        public event refreshDTOri rfDTOri;

        public editOrienta(int tipo)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
        }

        public editOrienta(int tipo, int id, string nombre, decimal entrevista, decimal vocacional)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
            Id = id;
            llenaCampos(id, nombre, entrevista, vocacional);
        }

        private void llenaCampos(int id, string nombre, decimal entrevista, decimal vocacional)
        {
            txtBoxStudent.Text = nombre;
            txtBoxEntrevista.Text = entrevista.ToString();
            txtBoxVoca.Text = vocacional.ToString();
        }

        private void asignaTitle(int tipo)
        {
            if (tipo == 1)
            {
                lblTitle.Text = "Ingresar notas orientación";
                btnGuardar.Text = "Guardar";
            }
            else
            {
                lblTitle.Text = "Editar notas orientación";
                btnGuardar.Text = "Modificar";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NotaBussines bs = new NotaBussines();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
