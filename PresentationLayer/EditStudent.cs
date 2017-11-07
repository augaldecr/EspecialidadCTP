using BussinesLayer;
using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EditStudent : Form
    {
        int Id;
        int type;
        int grupo;

        public delegate void refreshDT();
        public event refreshDT rfDT;

        public EditStudent(int tipo)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
            cargaCombosEspe();
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
            chkBoxLocal.Checked = Convert.ToBoolean(est.Ctpp);
            cmbBoxEspe1.SelectedValue = new EspecialidadBussines().especialidadXMatYPrioridad(mat.IdMatricula, 1).idEspecialidad;
            cmbBoxEspe2.SelectedValue = new EspecialidadBussines().especialidadXMatYPrioridad(mat.IdMatricula, 2).idEspecialidad;
            cmbBoxEspe3.SelectedValue = new EspecialidadBussines().especialidadXMatYPrioridad(mat.IdMatricula, 3).idEspecialidad;
            cmbBoxGrupo.SelectedValue = mat.Grupo;
            grupo = mat.Grupo;
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
            //Combobox de grupo
            List<Grupo> grupos = new GrupoBussines().listar();
            cmbBoxGrupo.DataSource = new BindingSource(grupos, null);
            cmbBoxGrupo.DisplayMember = "Numero";
            cmbBoxGrupo.ValueMember = "IdGrupo";
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
                    Ctpp = chkBoxLocal.Checked ? 1 : 0,
                };
                try
                {
                    est.guardarEstudiante(estudiante);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("cedula"))
                    {
                        MessageBox.Show("Número de cédula duplicado. Favor corregir.");
                        txtBoxCedula.Focus();
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                MatriculaBussines mbs = new MatriculaBussines();
                Matricula mat = new Matricula
                {
                    Estudiante = est.iDEstudianteXCedula(txtBoxCedula.Text),
                    CursoLectivo = new CursoLectivoData().CursoActivo(),
                    Grupo = int.Parse(cmbBoxGrupo.SelectedValue.ToString()),
                    Especialidad1 = int.Parse(cmbBoxEspe1.SelectedValue.ToString()),
                    Especialidad2 = int.Parse(cmbBoxEspe2.SelectedValue.ToString()),
                    Especialidad3 = int.Parse(cmbBoxEspe3.SelectedValue.ToString()),
                };

                try
                {
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
                    Ctpp = chkBoxLocal.Checked ? 1 : 0,
                };

                MatriculaBussines mbs = new MatriculaBussines();
                Matricula mat = new Matricula
                {
                    Estudiante = est.iDEstudianteXCedula(txtBoxCedula.Text),
                    IdMatricula = mbs.idMatriculaXEstudiante(est.iDEstudianteXCedula(txtBoxCedula.Text)),
                    CursoLectivo = new CursoLectivoData().CursoActivo(),
                    //TODO: Poner a leer el ComboBos de Grupo
                    Grupo = int.Parse(cmbBoxGrupo.SelectedValue.ToString()),
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
            MessageBox.Show("Información guardada de manera adecuada");
            rfDT();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar al estudiantes",
                "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (rs == DialogResult.Yes)
            {
                EstudiantesBussines bs = new EstudiantesBussines();
                MatriculaBussines mbs = new MatriculaBussines();
                NotaBussines ns = new NotaBussines();
                try
                {
                    ns.delNotasXMatYNivel(mbs.idMatriculaXEstudiante(int.Parse(txtBoxID.Text)), 8);
                    ns.delNotasXMatYNivel(mbs.idMatriculaXEstudiante(int.Parse(txtBoxID.Text)), 9);
                    ns.delNotaOrientaXMatricula(mbs.idMatriculaXEstudiante(int.Parse(txtBoxID.Text)));  
                    mbs.borrarMatricula(mbs.idMatriculaXEstudiante(int.Parse(txtBoxID.Text)));
                    bs.borrarEstudiante(int.Parse(txtBoxID.Text));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                MessageBox.Show("Estudiante eliminado de manera exitosa");
                rfDT();
                this.Dispose();
            }
        }

        private void chkBoxLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxLocal.Checked)
            {
                cmbBoxGrupo.Enabled = true;
            } else if (!chkBoxLocal.Checked)
            {
                cmbBoxGrupo.Enabled = false;
                cmbBoxGrupo.SelectedValue = 13;
            }
        }

        private void chkBoxLocal_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxLocal.Checked)
            {
                cmbBoxGrupo.Enabled = true;
                cmbBoxGrupo.SelectedValue = grupo;
            }
            else if (!chkBoxLocal.Checked)
            {
                cmbBoxGrupo.Enabled = false;
                cmbBoxGrupo.SelectedValue = 13;
            }
        }
    }
}
