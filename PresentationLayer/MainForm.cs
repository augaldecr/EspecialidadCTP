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

        private void tbPgEstudiantes_Enter(object sender, EventArgs e)
        {
            llenarEstudianteDatosDtGrdVw();
        }

        private void llenarEstudianteDatosDtGrdVw()
        {
            EstudiantesBussines est = new EstudiantesBussines();
            dtGrdVwEstudiantes.DataSource = est.listar();
        }

        private void dtGrdVwEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStudent editStudent = new EditStudent(2, int.Parse(dtGrdVwEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString()));
            editStudent.Show();
        }

        private void btnAddEstud_Click(object sender, EventArgs e)
        {
            EditStudent nuevoEst = new EditStudent(1);
            nuevoEst.Show();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent(2, int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwEstudiantes.CurrentRow.Index].Cells[0].Value.ToString()));
            editStudent.Show();
        }
    }
}
