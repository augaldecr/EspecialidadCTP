using BussinesLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
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
            editOrienta editOrienta1 = new editOrienta(2,
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["idnotas_orienta"].Value != null ? 
                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["idnotas_orienta"].Value.ToString()) : 0,

                string.Format("{0} {1} {2}", dtGrdVwOrienta.Rows[e.RowIndex].Cells["Nombre1"].Value.ToString(), 
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["ApellidoOne"].Value.ToString(), 
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["ApellidoTwo"].Value.ToString()),

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Entrevista"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Entrevista"].Value.ToString()) : 0,
                
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Vocacional"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Vocacional"].Value.ToString()) : 0);

            editOrienta1.Show();
            editOrienta1.rfDTOri += EditStudent_rfDT;
        }

        private void btnEditOrienta_Click(object sender, EventArgs e)
        {
            editOrienta editOrienta1 = new editOrienta(2,
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["idnotas_orienta"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["idnotas_orienta"].Value.ToString()) : 0,
                
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
                EstudiantesBussines bs = new EstudiantesBussines();
                MatriculaBussines mbs = new MatriculaBussines();
                try
                {
                    mbs.borrarMatricula(mbs.idMatriculaXEstudiante(int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells[0].Value.ToString())));
                    bs.borrarEstudiante(int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells[0].Value.ToString()));
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                MessageBox.Show("Estudiante eliminado de manera exitosa");
                refrescaDTNotasOrienta();
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
        }
        #endregion
    }
}
