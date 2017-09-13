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
    public partial class EditStudent : Form
    {
        int Id;
        int type;

        public EditStudent(int tipo)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
        }

        public EditStudent(int tipo, int id)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
            Id = id;
            llenaCampos(id);
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {

        }

        private void llenaCampos(int id)
        {
            EstudiantesBussines bs = new EstudiantesBussines();
            Estudiante est = bs.estudianteXID(id);

            txtBoxID.Text = est.IdEstudiante.ToString();
            txtBoxCedula.Text = est.Cedula.ToString();
            txtBoxNombre.Text = est.Nombre.ToString();
            txtBoxApellido1.Text = est.Apellido1.ToString();
            txtBoxApellido2.Text = est.Apellido2.ToString();
            txtBoxDir.Text = est.Cedula.ToString();
            txtBoxTel.Text = est.Nombre.ToString();
            txtBoxCel.Text = est.Apellido1.ToString();
            txtBoxEmail.Text = est.Apellido2.ToString();
            txtBoxLocal.Text = est.Ctpp.ToString();
        }

        private void asignaTitle(int tipo)
        {
            if (tipo == 1)
            {
                lblTitle.Text = "Nuevo estudiante";
            }
            else
            {
                lblTitle.Text = "Editar estudiante";
            }
        }
    }
}
