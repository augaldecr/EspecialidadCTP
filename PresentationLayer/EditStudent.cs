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
            cargaCombosEspe();
            llenaCampos(id);
        }

        private void llenaCampos(int id)
        {
            EstudiantesBussines bs = new EstudiantesBussines();
            Estudiante est = bs.estudianteXID(id);
            MatriculaBussines mbs = new MatriculaBussines();
            Matricula mat = mbs.matriculaXEstudiante(id);

            txtBoxID.Text = est.IdEstudiante.ToString();
            txtBoxCedula.Text = est.Cedula.ToString();
            txtBoxNombre.Text = est.Nombre.ToString();
            txtBoxApellido1.Text = est.Apellido1.ToString();
            txtBoxApellido2.Text = est.Apellido2.ToString();
            txtBoxDir.Text = est.Direccion.ToString();
            txtBoxTel.Text = est.Telefono.ToString();
            txtBoxCel.Text = est.Celular.ToString();
            txtBoxEmail.Text = est.Email.ToString();
            //chkBoxLocal.Enabled = bool.Parse(est.Ctpp);
            cmbBoxEspe1.SelectedValue = mat.Especialidad1;
            cmbBoxEspe2.SelectedValue = mat.Especialidad2;
            cmbBoxEspe3.SelectedValue = mat.Especialidad3;
        }

        private void cargaCombosEspe()
        {
            List<Especialidad> especialidades = new EspecialidadBussines().listar();
            cmbBoxEspe1.DataSource = new BindingSource(especialidades, null);
            cmbBoxEspe1.DisplayMember = "Nombre";
            cmbBoxEspe1.ValueMember = "idEspecialidad";
            cmbBoxEspe2.DataSource = new BindingSource(especialidades, null);
            cmbBoxEspe2.DisplayMember = "Nombre";
            cmbBoxEspe2.ValueMember = "idEspecialidad";
            cmbBoxEspe3.DataSource = new BindingSource(especialidades, null);
            cmbBoxEspe3.DisplayMember = "Nombre";
            cmbBoxEspe3.ValueMember = "idEspecialidad";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                EstudiantesBussines est = new EstudiantesBussines();
                Estudiante estudiante = new Estudiante
                {
                    Cedula = txtBoxCedula.Text,
                    Nombre = txtBoxNombre.Text,
                    Apellido1 = txtBoxApellido1.Text,
                    Apellido2 = txtBoxApellido2.Text,
                    Celular = txtBoxCel.Text,
                    Direccion = txtBoxDir.Text,
                    Email = txtBoxEmail.Text,
                    Telefono = txtBoxTel.Text,
                    Ctpp = int.Parse(chkBoxLocal.Enabled.ToString()),
                };

                MatriculaBussines mbs = new MatriculaBussines();
                Matricula mat = new Matricula
                {
                    Estudiante = est.iDEstudianteXCedula(txtBoxCedula.Text),
                    CursoLectivo = 19,
                    Especialidad1 = int.Parse(cmbBoxEspe1.SelectedValue.ToString()),
                    Especialidad2 = int.Parse(cmbBoxEspe2.SelectedValue.ToString()),
                    Especialidad3 = int.Parse(cmbBoxEspe3.SelectedValue.ToString()),
                };
                try
                {
                    est.guardarEstudiante(estudiante);
                    mbs.guardarMatricula(mat);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                EstudiantesBussines est = new EstudiantesBussines();
                Estudiante estudiante = new Estudiante
                {
                    IdEstudiante = int.Parse(txtBoxID.Text),
                    Cedula = txtBoxCedula.Text,
                    Nombre = txtBoxNombre.Text,
                    Apellido1 = txtBoxApellido1.Text,
                    Apellido2 = txtBoxApellido2.Text,
                    Celular = txtBoxCel.Text,
                    Direccion = txtBoxDir.Text,
                    Email = txtBoxEmail.Text,
                    Telefono = txtBoxTel.Text,
                    Ctpp = 1,
                    //Ctpp = int.Parse(chkBoxLocal.Enabled.ToString()),
                };

                MatriculaBussines mbs = new MatriculaBussines();
                Matricula mat = new Matricula
                {
                    Estudiante = est.iDEstudianteXCedula(txtBoxCedula.Text),
                    IdMatricula = mbs.idMatriculaXEstudiante(est.iDEstudianteXCedula(txtBoxCedula.Text)),
                    CursoLectivo = 2,
                    Especialidad1 = int.Parse(cmbBoxEspe1.SelectedValue.ToString()),
                    Especialidad2 = int.Parse(cmbBoxEspe2.SelectedValue.ToString()),
                    Especialidad3 = int.Parse(cmbBoxEspe3.SelectedValue.ToString()),
                };

                try
                {
                    est.modificaEstudiante(estudiante);
                    mbs.modificaMatricula(mat);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            //cargaCombosEspe();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
