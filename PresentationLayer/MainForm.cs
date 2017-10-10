using BussinesLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        //TODO: Agregado campo "especialidad_x" para llenar con especialidad ganada
        //TODO: Jalar notas de base de datos de piad
        //TODO: Filtrar estudiantes y notas por sección en el MainForm
        //TODO: Agregada vista "curso_activo", "periodos_curso_activo"
        //TODO: Agregado Stored Procedure "SeleccionarPeriodosXCursoLectivo"
        //TODO: Agregado Stored Procedure "SeleccionarMatriculasXCursoLect"
        public MainForm()
        {
            InitializeComponent();
        }

        #region TabEstudiantes
        private void tbPgEstudiantes_Enter(object sender, EventArgs e)
        {
            llenarEstudianteDatosDtGrdVw();
        }

        private void llenarEstudianteDatosDtGrdVw()
        {
            EstudiantesBussines est = new EstudiantesBussines();
            dtGrdVwEstudiantes.DataSource = est.listar();
            dtGrdVwEstudiantes.Refresh();
            dtGrdVwEstudiantes.Update();
        }

        private void vaciarEstudianteDatosDtGrdVw()
        {
            dtGrdVwEstudiantes.DataSource = null;
            dtGrdVwEstudiantes.Refresh();
            dtGrdVwEstudiantes.Update();
        }

        private void dtGrdVwEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStudent editStudent = new EditStudent(2, int.Parse(dtGrdVwEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString()));
            editStudent.Show();
            editStudent.rfDT += EditStudent_rfDT;
        }

        private void btnAddEstud_Click(object sender, EventArgs e)
        {
            EditStudent nuevoEst = new EditStudent(1);
            nuevoEst.Show();
            nuevoEst.rfDT += EditStudent_rfDT;
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent(2, int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwEstudiantes.CurrentRow.Index].Cells[0].Value.ToString()));
            editStudent.Show();
            editStudent.rfDT += EditStudent_rfDT;
        }

        private void EditStudent_rfDT()
        {
            refrescaDTEstud();
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar al estudiantes",
                "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (rs == DialogResult.Yes)
            {
                EstudiantesBussines bs = new EstudiantesBussines();
                MatriculaBussines mbs = new MatriculaBussines();
                try
                {
                    mbs.borrarMatricula(mbs.idMatriculaXEstudiante(int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwEstudiantes.CurrentRow.Index].Cells[0].Value.ToString())));
                    bs.borrarEstudiante(int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwEstudiantes.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                MessageBox.Show("Estudiante eliminado de manera exitosa");
                refrescaDTEstud();
            }
        }

        private void refrescaDTEstud()
        {
            vaciarEstudianteDatosDtGrdVw();
            llenarEstudianteDatosDtGrdVw();
        }
        #endregion

        #region TabOrienta
        private void tbPgOrienta_Enter(object sender, EventArgs e)
        {
            llenarOrientaDatosDtGrdVw();
        }

        private void llenarOrientaDatosDtGrdVw()
        {
            NotaBussines ori = new NotaBussines();
            dtGrdVwOrienta.DataSource = ori.listarNotasOrienta();
            dtGrdVwOrienta.Refresh();
            dtGrdVwOrienta.Update();
        }

        private void vaciarOrientaDatosDtGrdVw()
        {
            dtGrdVwOrienta.DataSource = null;
            dtGrdVwOrienta.Refresh();
            dtGrdVwOrienta.Update();
        }

        private void dtGrdVwOrienta_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            editOrienta editOrienta1 = new editOrienta(
                //Indica si es nota nueva o existente
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["IdNota"].Value != null ? 2 : 1,

                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Matricula"].Value.ToString()), 

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["IdNota"].Value != null ? 
                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["IdNota"].Value.ToString()) : 0,

                string.Format("{0} {1} {2}", dtGrdVwOrienta.Rows[e.RowIndex].Cells["Nombre1"].Value.ToString(), 
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["ApellidoOne"].Value.ToString(), 
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["ApellidoTwo"].Value.ToString()),

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Entrevista"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Entrevista"].Value.ToString()) : 0,
                
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Vocacional"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Vocacional"].Value.ToString()) : 0);

            editOrienta1.Show();
            editOrienta1.rfDTOri += EditNotasOrienta_rfDT;
        }

        private void btnEditOrienta_Click(object sender, EventArgs e)
        {
            editOrienta editOrienta1 = new editOrienta(
                //Indica si es nota nueva o existente
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value != null ? 2 : 1,

                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Matricula"].Value.ToString()),

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value.ToString()) : 0,
                
                string.Format("{0} {1} {2}", dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Nombre1"].Value.ToString(),
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["ApellidoOne"].Value.ToString(), 
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["ApellidoTwo"].Value.ToString()),

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Entrevista"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Entrevista"].Value.ToString()) : 0,

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Vocacional"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Vocacional"].Value.ToString()) : 0);

            editOrienta1.Show();
            editOrienta1.rfDTOri += EditNotasOrienta_rfDT;
        }

        private void btnEliminarOrienta_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar las notas",
                "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (rs == DialogResult.Yes)
            {
                NotaBussines bs = new NotaBussines();
                try
                {
                    if (dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value == null)
                    {
                        MessageBox.Show("El estudiante no tiene notas asignadas");
                    }
                    else
                    {
                        bs.editNotaOrienta(int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value.ToString()), 0, 0);
                        MessageBox.Show("Notas eliminadas de manera exitosa");
                        refrescaDTNotasOrienta();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void EditNotasOrienta_rfDT()
        {
            refrescaDTNotasOrienta();
        }

        private void refrescaDTNotasOrienta()
        {
            vaciarOrientaDatosDtGrdVw();
            llenarOrientaDatosDtGrdVw();
            dtGrdVwOrienta.Columns["IdNota"].Visible = false;
            dtGrdVwOrienta.Columns["Matricula"].Visible = false;
            dtGrdVwOrienta.Columns["Asignatura"].Visible = false;
            dtGrdVwOrienta.Columns["Curso_lectivo"].Visible = false;
            dtGrdVwOrienta.Columns["Nivel"].Visible = false;
            dtGrdVwOrienta.Columns["Periodo"].Visible = false;
            dtGrdVwOrienta.Columns["Calificacion"].Visible = false;
            dtGrdVwOrienta.Columns["Apellido1"].HeaderText = "Primer apellido";
            dtGrdVwOrienta.Columns["Apellido2"].HeaderText = "Segundo apellido";
            dtGrdVwOrienta.Columns["nombre"].Name = "Nombre1";
            dtGrdVwOrienta.Columns["Apellido1"].Name = "ApellidoOne";
            dtGrdVwOrienta.Columns["Apellido2"].Name = "ApellidoTwo";
        }
        #endregion

        #region TabNotas8
        /*private void tbPgOrienta_Enter(object sender, EventArgs e)
        {
            llenarOrientaDatosDtGrdVw();
        }

        private void llenarOrientaDatosDtGrdVw()
        {
            NotaBussines ori = new NotaBussines();
            dtGrdVwOrienta.DataSource = ori.listarNotasOrienta();
            dtGrdVwOrienta.Refresh();
            dtGrdVwOrienta.Update();
        }

        private void vaciarOrientaDatosDtGrdVw()
        {
            dtGrdVwOrienta.DataSource = null;
            dtGrdVwOrienta.Refresh();
            dtGrdVwOrienta.Update();
        }

        private void dtGrdVwOrienta_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            editOrienta editOrienta1 = new editOrienta(
                //Indica si es nota nueva o existente
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["IdNota"].Value != null ? 2 : 1,

                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Matricula"].Value.ToString()),

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["IdNota"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["IdNota"].Value.ToString()) : 0,

                string.Format("{0} {1} {2}", dtGrdVwOrienta.Rows[e.RowIndex].Cells["Nombre1"].Value.ToString(),
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["ApellidoOne"].Value.ToString(),
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["ApellidoTwo"].Value.ToString()),

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Entrevista"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Entrevista"].Value.ToString()) : 0,

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Vocacional"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Vocacional"].Value.ToString()) : 0);

            editOrienta1.Show();
            editOrienta1.rfDTOri += EditNotasOrienta_rfDT;
        }

        private void btnEditOrienta_Click(object sender, EventArgs e)
        {
            editOrienta editOrienta1 = new editOrienta(
                //Indica si es nota nueva o existente
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value != null ? 2 : 1,

                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Matricula"].Value.ToString()),

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value.ToString()) : 0,

                string.Format("{0} {1} {2}", dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Nombre1"].Value.ToString(),
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["ApellidoOne"].Value.ToString(),
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["ApellidoTwo"].Value.ToString()),

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Entrevista"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Entrevista"].Value.ToString()) : 0,

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Vocacional"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Vocacional"].Value.ToString()) : 0);

            editOrienta1.Show();
            editOrienta1.rfDTOri += EditNotasOrienta_rfDT;
        }

        private void btnEliminarOrienta_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar las notas",
                "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (rs == DialogResult.Yes)
            {
                NotaBussines bs = new NotaBussines();
                try
                {
                    if (dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value == null)
                    {
                        MessageBox.Show("El estudiante no tiene notas asignadas");
                    }
                    else
                    {
                        bs.editNotaOrienta(int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value.ToString()), 0, 0);
                        MessageBox.Show("Notas eliminadas de manera exitosa");
                        refrescaDTNotasOrienta();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void EditNotasOrienta_rfDT()
        {
            refrescaDTNotasOrienta();
        }

        private void refrescaDTNotasOrienta()
        {
            vaciarOrientaDatosDtGrdVw();
            llenarOrientaDatosDtGrdVw();
            dtGrdVwOrienta.Columns["IdNota"].Visible = false;
            dtGrdVwOrienta.Columns["Matricula"].Visible = false;
            dtGrdVwOrienta.Columns["Asignatura"].Visible = false;
            dtGrdVwOrienta.Columns["Curso_lectivo"].Visible = false;
            dtGrdVwOrienta.Columns["Nivel"].Visible = false;
            dtGrdVwOrienta.Columns["Periodo"].Visible = false;
            dtGrdVwOrienta.Columns["Calificacion"].Visible = false;
            dtGrdVwOrienta.Columns["Apellido1"].HeaderText = "Primer apellido";
            dtGrdVwOrienta.Columns["Apellido2"].HeaderText = "Segundo apellido";
        }*/
        #endregion

        #region Configuracion
        private void btnConfig_Click(object sender, EventArgs e)
        {
            string pass;

            pass = Microsoft.VisualBasic.Interaction.InputBox("Ingrese contraseña ", "Ingreso de contraseña", "selvanegra$2015", 100, 0);

            if (pass == "selvanegra$2015")
            {
                Config config = new Config();
                config.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
