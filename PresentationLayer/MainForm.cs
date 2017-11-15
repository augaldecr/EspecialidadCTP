using BussinesLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        //QUERY:
        //INSERT INTO elecciones_especialidad(identrevista, matricula, especialidad, prioridad, nota)
        //SELECT null, idmatricula_admision, especialidad1, 1, null FROM matriculas_admision
        //TODO: Comenzando el query de especialidad_x
        //SELECT (((AVG(n.calificacion)/100)*40) + 10) FROM ctp_noveno.notas n INNER JOIN notas_orienta o ON n.matricula=o.matricula WHERE n.matricula=2

        public MainForm() => InitializeComponent();

        #region TabEstudiantes
        List<Estudiante> listaEstudiantes = new EstudiantesBussines().listar();

        private void tbPgEstudiantes_Enter(object sender, EventArgs e)
        {
            llenaComboSecciones();
            llenarEstudianteDatosDtGrdVw();
        }

        private void llenarEstudianteDatosDtGrdVw()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = listaEstudiantes;
            dtGrdVwEstudiantes.DataSource = bs;
            formateaDTEstudiantes();
        }

        private void llenaComboSecciones()
        {
            List<Grupo> grupos = new GrupoBussines().listar();
            grupos.Insert(0, new Grupo() { IdGrupo = 0, Numero = "Todos", });
            BindingSource bs = new BindingSource(grupos, null);           
            cmbBoxSeccionesEstud.DataSource = bs;
            cmbBoxSeccionesEstud.DisplayMember = "Numero";
            cmbBoxSeccionesEstud.ValueMember = "IdGrupo";
        }

        private void formateaDTEstudiantes()
        {
            dtGrdVwEstudiantes.Columns["IdEstudiante"].HeaderText = "Id";
            dtGrdVwEstudiantes.Columns["Cedula"].HeaderText = "Cédula";
            dtGrdVwEstudiantes.Columns["Nombre"].HeaderText = "Nombre";
            dtGrdVwEstudiantes.Columns["Apellido1"].HeaderText = "Primer apellido";
            dtGrdVwEstudiantes.Columns["Apellido2"].HeaderText = "Segundo apellido";
            dtGrdVwEstudiantes.Columns["IdGrupo"].Visible = false;
            dtGrdVwEstudiantes.Columns["Direccion"].HeaderText = "Dirección";
            dtGrdVwEstudiantes.Columns["Telefono"].HeaderText = "Teléfono";
            dtGrdVwEstudiantes.Columns["Celular"].HeaderText = "Celular";
            dtGrdVwEstudiantes.Columns["Email"].HeaderText = "Correo electrónico";
            dtGrdVwEstudiantes.Columns["Ctpp"].Visible = false;

            if (!dtGrdVwEstudiantes.Columns.Contains("Ctpp"))
            {
                DataGridViewCheckBoxColumn DtGVCl = new DataGridViewCheckBoxColumn();
                DtGVCl.DataPropertyName = "Ctpp";
                DtGVCl.TrueValue = "1";
                DtGVCl.FalseValue = "0";
                DtGVCl.HeaderText = "Local";
                DtGVCl.Name = "Local";
                DtGVCl.ReadOnly = true;
                dtGrdVwEstudiantes.Columns.AddRange(new DataGridViewColumn[] { DtGVCl });
            }

            foreach (DataGridViewColumn column in dtGrdVwEstudiantes.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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
            EditStudent editStudent = new EditStudent(2, int.Parse(dtGrdVwEstudiantes.Rows[e.RowIndex].Cells["IdEstudiante"].Value.ToString()));
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
                NotaBussines ns = new NotaBussines();
                try
                {
                    ns.delNotasXMatYNivel(int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwEstudiantes.CurrentRow.Index].Cells[0].Value.ToString()), 8);
                    ns.delNotasXMatYNivel(int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwEstudiantes.CurrentRow.Index].Cells[0].Value.ToString()), 9);
                    ns.delNotaOrientaXMatricula(int.Parse(dtGrdVwEstudiantes.Rows[dtGrdVwEstudiantes.CurrentRow.Index].Cells[0].Value.ToString()));
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

        private void cmbBoxSeccionesEstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            vaciarEstudianteDatosDtGrdVw();
            BindingSource bs = new BindingSource();
            if (cmbBoxSeccionesEstud.SelectedValue.ToString()=="0")
            {
                bs.DataSource = listaEstudiantes;
            }
            else
            {
                bs.DataSource = listaEstudiantes.Where(x => x.IdGrupo == cmbBoxSeccionesEstud.SelectedValue.ToString());
            }
            dtGrdVwEstudiantes.DataSource = bs;
        }

        private void txtBoxBusqEst_TextChanged(object sender, EventArgs e)
        {
            vaciarEstudianteDatosDtGrdVw();
            BindingSource bs = new BindingSource();
            bs.DataSource = listaEstudiantes.Where(x => x.Cedula.Contains(txtBoxBusqEst.Text));
            dtGrdVwEstudiantes.DataSource = bs;
            formateaDTEstudiantes();
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
            formateaDTNotasOrienta();
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

                string.Format("{0} {1} {2}", dtGrdVwOrienta.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["apellido1"].Value.ToString(),
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["apellido2"].Value.ToString()),

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp1_id"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp1_id"].Value.ToString()) : 0,
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp1_nombre"].Value != null ?
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp1_nombre"].Value.ToString() : null,
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp1_nota"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp1_nota"].Value.ToString()) : 0,

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp2_id"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp2_id"].Value.ToString()) : 0,
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp2_nombre"].Value != null ?
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp2_nombre"].Value.ToString() : null,
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp2_nota"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp2_nota"].Value.ToString()) : 0,

                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp3_id"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp3_id"].Value.ToString()) : 0,
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp3_nombre"].Value != null ?
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp3_nombre"].Value.ToString() : null,
                dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp3_nota"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[e.RowIndex].Cells["Esp3_nota"].Value.ToString()) : 0,

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

                string.Format("{0} {1} {2}", dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Nombre"].Value.ToString(),
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["apellido1"].Value.ToString(),
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["apellido2"].Value.ToString()),

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp1_id"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp1_id"].Value.ToString()) : 0,
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp1_nombre"].Value != null ?
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp1_nombre"].Value.ToString() : null,
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp1_nota"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp1_nota"].Value.ToString()) : 0,

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp2_id"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp2_id"].Value.ToString()) : 0,
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp2_nombre"].Value != null ?
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp2_nombre"].Value.ToString() : null,
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp2_nota"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp2_nota"].Value.ToString()) : 0,

                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp3_id"].Value != null ?
                int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp3_id"].Value.ToString()) : 0,
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp3_nombre"].Value != null ?
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp3_nombre"].Value.ToString() : null,
                dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp3_nota"].Value != null ?
                decimal.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["Esp3_nota"].Value.ToString()) : 0,

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
                        bs.editNotaOrienta(int.Parse(dtGrdVwOrienta.Rows[dtGrdVwOrienta.CurrentRow.Index].Cells["IdNota"].Value.ToString()), 0);
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
            formateaDTNotasOrienta();
        }

        private void formateaDTNotasOrienta()
        {
            #region Oculta columnas nulas
                dtGrdVwOrienta.Columns["IdNota"].Visible = false;
                dtGrdVwOrienta.Columns["Asignatura"].Visible = false;
                dtGrdVwOrienta.Columns["Curso_lectivo"].Visible = false;
                dtGrdVwOrienta.Columns["Nivel"].Visible = false;
                dtGrdVwOrienta.Columns["Periodo"].Visible = false;
                dtGrdVwOrienta.Columns["PeriodoNombre"].Visible = false;
                dtGrdVwOrienta.Columns["Calificacion"].Visible = false;
                dtGrdVwOrienta.Columns["Tipo"].Visible = false;
                dtGrdVwOrienta.Columns["Esp1_id"].Visible = false;
                dtGrdVwOrienta.Columns["Esp2_id"].Visible = false;
                dtGrdVwOrienta.Columns["Esp3_id"].Visible = false;
            #endregion

            #region Nombre de columnas
            dtGrdVwOrienta.Columns["Matricula"].HeaderText = "ID";
            dtGrdVwOrienta.Columns["Apellido1"].HeaderText = "Primer apellido";
            dtGrdVwOrienta.Columns["Apellido2"].HeaderText = "Segundo apellido";
            dtGrdVwOrienta.Columns["Nombre"].HeaderText = "Nombre";
            dtGrdVwOrienta.Columns["Vocacional"].HeaderText = "Vocacional";
            dtGrdVwOrienta.Columns["Esp1_nombre"].HeaderText = "Espec. 1";
            dtGrdVwOrienta.Columns["Esp2_nombre"].HeaderText = "Espec. 2";
            dtGrdVwOrienta.Columns["Esp3_nombre"].HeaderText = "Espec. 3";
            dtGrdVwOrienta.Columns["Esp1_nota"].HeaderText = "Nota 1";
            dtGrdVwOrienta.Columns["Esp2_nota"].HeaderText = "Nota 2";
            dtGrdVwOrienta.Columns["Esp3_nota"].HeaderText = "Nota 3";
            #endregion

            dtGrdVwOrienta.Refresh();
            dtGrdVwOrienta.Update();
        }
        #endregion

        #region TabNotas8
        private void tbPgNotas8_Enter(object sender, EventArgs e)
        {
            llenarNotas8DtGrdVw();
        }

        private void llenarNotas8DtGrdVw()
        {
            NotaBussines nt = new NotaBussines();
            dtGrdVwNotas.DataSource = nt.listarNotasBasicas8();
            formateaDTNotas8();
        }

        private void vaciarDtGrdVwNotas8()
        {
            dtGrdVwNotas.DataSource = null;
            dtGrdVwNotas.Refresh();
            dtGrdVwNotas.Update();
        }

        private void btnEditNota_Click(object sender, EventArgs e)
        {
            EditNotas8 notas8 = new EditNotas8(
                int.Parse(dtGrdVwNotas.Rows[dtGrdVwNotas.CurrentRow.Index].Cells[0].Value.ToString()));
            notas8.Show();
            notas8.RfDTNotas8 += Notas8_RfDTNotas8;
        }

        private void dtGrdVwNotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditNotas8 notas8 = new EditNotas8(
                int.Parse(dtGrdVwNotas.Rows[e.RowIndex].Cells["IdMatricula"].Value.ToString()));

            notas8.Show();
            notas8.RfDTNotas8 += Notas8_RfDTNotas8;
        }

        private void Notas8_RfDTNotas8()
        {
            refrescaDTNotas8();
        }

        private void btnDelNota_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar las notas",
                "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (rs == DialogResult.Yes)
            {
                NotaBussines bs = new NotaBussines();
                try
                {
                    bs.delNotasXMatYNivel(int.Parse(dtGrdVwNotas.Rows[dtGrdVwNotas.CurrentRow.Index].Cells["IdMatricula"].Value.ToString()), 8);
                    MessageBox.Show("Notas eliminadas de manera exitosa");
                    refrescaDTNotas8();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void refrescaDTNotas8()
        {
            vaciarDtGrdVwNotas8();
            llenarNotas8DtGrdVw();
            formateaDTNotas8();
        }

        private void formateaDTNotas8()
        {
            dtGrdVwNotas.Columns["id_esp1"].Visible = false;
            dtGrdVwNotas.Columns["id_esp2"].Visible = false;
            dtGrdVwNotas.Columns["id_esp3"].Visible = false;
            dtGrdVwNotas.Columns["id_cie1"].Visible = false;
            dtGrdVwNotas.Columns["id_cie2"].Visible = false;
            dtGrdVwNotas.Columns["id_cie3"].Visible = false;
            dtGrdVwNotas.Columns["id_estsoc1"].Visible = false;
            dtGrdVwNotas.Columns["id_estsoc2"].Visible = false;
            dtGrdVwNotas.Columns["id_estsoc3"].Visible = false;
            dtGrdVwNotas.Columns["id_mat1"].Visible = false;
            dtGrdVwNotas.Columns["id_mat2"].Visible = false;
            dtGrdVwNotas.Columns["id_mat3"].Visible = false;
            dtGrdVwNotas.Columns["id_ing1"].Visible = false;
            dtGrdVwNotas.Columns["id_ing2"].Visible = false;
            dtGrdVwNotas.Columns["id_ing3"].Visible = false;
            dtGrdVwNotas.Columns["id_civ1"].Visible = false;
            dtGrdVwNotas.Columns["id_civ2"].Visible = false;
            dtGrdVwNotas.Columns["id_civ3"].Visible = false;
            dtGrdVwNotas.Columns["id_talI1"].Visible = false;
            dtGrdVwNotas.Columns["id_talI2"].Visible = false;
            dtGrdVwNotas.Columns["id_talI3"].Visible = false;
            dtGrdVwNotas.Columns["id_talII1"].Visible = false;
            dtGrdVwNotas.Columns["id_talII2"].Visible = false;
            dtGrdVwNotas.Columns["id_talII3"].Visible = false;
            foreach (DataGridViewColumn column in dtGrdVwNotas.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dtGrdVwNotas.Refresh();
            dtGrdVwNotas.Update();
        }
        #endregion

        #region TabNotas9
        private void tbPgNotas9_Enter(object sender, EventArgs e)
        {
            llenarNotas9DtGrdVw();
        }

        private void llenarNotas9DtGrdVw()
        {
            NotaBussines nt = new NotaBussines();
            dtGrdVwNotas9.DataSource = nt.listarNotasBasicas9();
            formateaDTNotas9();
        }

        private void vaciarDtGrdVwNotas9()
        {
            dtGrdVwNotas9.DataSource = null;
            dtGrdVwNotas9.Refresh();
            dtGrdVwNotas9.Update();
        }

        private void btnEditNota9_Click(object sender, EventArgs e)
        {
            EditNotas9 notas9 = new EditNotas9(
                int.Parse(dtGrdVwNotas9.Rows[dtGrdVwNotas9.CurrentRow.Index].Cells[0].Value.ToString()));
            notas9.Show();
            notas9.RfDTNotas9 += Notas9_RfDTNotas9;
        }

        private void dtGrdVwNotas9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditNotas9 notas9 = new EditNotas9(
                int.Parse(dtGrdVwNotas9.Rows[e.RowIndex].Cells["IdMatricula"].Value.ToString()));

            notas9.Show();
            notas9.RfDTNotas9 += Notas9_RfDTNotas9;
        }

        private void Notas9_RfDTNotas9()
        {
            refrescaDTNotas9();
        }

        private void btnDelNota9_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar las notas",
                "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (rs == DialogResult.Yes)
            {
                NotaBussines bs = new NotaBussines();
                try
                {
                    bs.delNotasXMatYNivel(int.Parse(dtGrdVwNotas9.Rows[dtGrdVwNotas9.CurrentRow.Index].Cells["IdMatricula"].Value.ToString()), 9);
                    MessageBox.Show("Notas eliminadas de manera exitosa");
                    refrescaDTNotas9();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void refrescaDTNotas9()
        {
            vaciarDtGrdVwNotas9();
            llenarNotas9DtGrdVw();
            formateaDTNotas9();
        }

        private void formateaDTNotas9()
        {
            dtGrdVwNotas9.Columns["id_esp1"].Visible = false;
            dtGrdVwNotas9.Columns["id_esp2"].Visible = false;
            dtGrdVwNotas9.Columns["id_esp3"].Visible = false;
            dtGrdVwNotas9.Columns["esp3"].Visible = false;
            dtGrdVwNotas9.Columns["id_cie1"].Visible = false;
            dtGrdVwNotas9.Columns["id_cie2"].Visible = false;
            dtGrdVwNotas9.Columns["id_cie3"].Visible = false;
            dtGrdVwNotas9.Columns["cie3"].Visible = false;
            dtGrdVwNotas9.Columns["id_estsoc1"].Visible = false;
            dtGrdVwNotas9.Columns["id_estsoc2"].Visible = false;
            dtGrdVwNotas9.Columns["id_estsoc3"].Visible = false;
            dtGrdVwNotas9.Columns["estsoc3"].Visible = false;
            dtGrdVwNotas9.Columns["id_mat1"].Visible = false;
            dtGrdVwNotas9.Columns["id_mat2"].Visible = false;
            dtGrdVwNotas9.Columns["id_mat3"].Visible = false;
            dtGrdVwNotas9.Columns["mat3"].Visible = false;
            dtGrdVwNotas9.Columns["id_ing1"].Visible = false;
            dtGrdVwNotas9.Columns["id_ing2"].Visible = false;
            dtGrdVwNotas9.Columns["id_ing3"].Visible = false;
            dtGrdVwNotas9.Columns["ing3"].Visible = false;
            dtGrdVwNotas9.Columns["id_civ1"].Visible = false;
            dtGrdVwNotas9.Columns["id_civ2"].Visible = false;
            dtGrdVwNotas9.Columns["id_civ3"].Visible = false;
            dtGrdVwNotas9.Columns["civ3"].Visible = false;
            dtGrdVwNotas9.Columns["id_talI1"].Visible = false;
            dtGrdVwNotas9.Columns["id_talI2"].Visible = false;
            dtGrdVwNotas9.Columns["id_talI3"].Visible = false;
            dtGrdVwNotas9.Columns["talI3"].Visible = false;
            dtGrdVwNotas9.Columns["id_talII1"].Visible = false;
            dtGrdVwNotas9.Columns["id_talII2"].Visible = false;
            dtGrdVwNotas9.Columns["id_talII3"].Visible = false;
            dtGrdVwNotas9.Columns["talII3"].Visible = false;
            foreach (DataGridViewColumn column in dtGrdVwNotas9.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dtGrdVwNotas9.Refresh();
            dtGrdVwNotas9.Update();
        }
        #endregion

        #region Configuracion
        private void btnConfig_Click(object sender, EventArgs e)
        {
            string pass;

            pass = Microsoft.VisualBasic.Interaction.InputBox("Ingrese contraseña ", "Ingreso de contraseña", "Contraseña", 100, 0);

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

        private void btnEscogenciaEspec_Click(object sender, EventArgs e)
        {
            svFileDg.FileName = "Especialidades por estudiante.xlsx";
            svFileDg.DefaultExt = "xlsx";
            svFileDg.Filter = "Archivo de MS Excel|.xlsx";
            svFileDg.Title = "Seleccione el destino del reporte";
            svFileDg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            svFileDg.FileOk += SvFileDg_FileOk;

            svFileDg.ShowDialog();
        }

        private void btnEstXEspec_Click(object sender, EventArgs e)
        {
            dirBrwsDlg.Description = "Seleccione el destino del reporte";
            dirBrwsDlg.RootFolder = Environment.SpecialFolder.Desktop;

            DialogResult rs = dirBrwsDlg.ShowDialog();
            if (rs == DialogResult.OK)
            {
                new EspecialidadBussines().listarEstudXEspec(dirBrwsDlg.SelectedPath, "Estudiantes por especialidad");
                MessageBox.Show("Reporte generado");
            }
        }

        private void btnListarInconsistencias_Click(object sender, EventArgs e)
        {
            svFileDg.FileName = "Inconsistencias.xlsx";
            svFileDg.DefaultExt = "xlsx";
            svFileDg.Filter = "Archivo de MS Excel|.xlsx";
            svFileDg.Title = "Seleccione el destino del reporte";
            svFileDg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            svFileDg.FileOk += SvFileDg_FileOk;

            svFileDg.ShowDialog();
        }

        private void btnNotas8_Click(object sender, EventArgs e)
        {
            svFileDg.FileName = "Notas_8.xlsx";
            svFileDg.DefaultExt = "xlsx";
            svFileDg.Filter = "Archivo de MS Excel|.xlsx";
            svFileDg.Title = "Seleccione el destino del reporte";
            svFileDg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            svFileDg.FileOk += SvFileDg_FileOk;

            svFileDg.ShowDialog();
        }

        private void btnNotas9_Click(object sender, EventArgs e)
        {
            svFileDg.FileName = "Notas_9.xlsx";
            svFileDg.DefaultExt = "xlsx";
            svFileDg.Filter = "Archivo de MS Excel|.xlsx";
            svFileDg.Title = "Seleccione el destino del reporte";
            svFileDg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            svFileDg.FileOk += SvFileDg_FileOk;

            svFileDg.ShowDialog();
        }

        private void btnNotasFaltantes8_Click(object sender, EventArgs e)
        {
            svFileDg.FileName = "Notas_faltantes_8.xlsx";
            svFileDg.DefaultExt = "xlsx";
            svFileDg.Filter = "Archivo de MS Excel|.xlsx";
            svFileDg.Title = "Seleccione el destino del reporte";
            svFileDg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            svFileDg.FileOk += SvFileDg_FileOk;

            svFileDg.ShowDialog();
        }

        private void btnNotasFaltantes9_Click_1(object sender, EventArgs e)
        {
            svFileDg.FileName = "Notas_faltantes_9.xlsx";
            svFileDg.DefaultExt = "xlsx";
            svFileDg.Filter = "Archivo de MS Excel|.xlsx";
            svFileDg.Title = "Seleccione el destino del reporte";
            svFileDg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            svFileDg.FileOk += SvFileDg_FileOk;

            svFileDg.ShowDialog();
        }

        private void SvFileDg_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveFileDialog sv = (SaveFileDialog)sender;
            try
            {
                if (sv.FileName.Contains("Especialidades por estudiante"))
                {
                    new EspecialidadBussines().listarEspecXEstud(svFileDg.FileName, "Especialidades por estudiante");
                }
                else if (sv.FileName.Contains("Inconsistencias"))
                {
                    new EspecialidadBussines().listarIncosistencias(svFileDg.FileName, "Inconsistencias");
                }
                else if (sv.FileName.Contains("Notas_8"))
                {
                    new NotaBussines().listarNotas8(svFileDg.FileName, "Notas_8");
                }
                else if (sv.FileName.Contains("Notas_9"))
                {
                    new NotaBussines().listarNotas9(svFileDg.FileName, "Notas_9");
                }
                else if (sv.FileName.Contains("Notas_faltantes_8"))
                {
                    new NotaBussines().listarNotasFaltantes8(svFileDg.FileName, "Notas_faltantes_8");
                }
                else if (sv.FileName.Contains("Notas_faltantes_9"))
                {
                    new NotaBussines().listarNotasFaltantes9(svFileDg.FileName, "Notas_faltantes_9");
                }
                MessageBox.Show("Reporte generado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Importa notas desde anual
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (NotasBasicas notas in new NotaBussines().listarNotasBasicas8())
            {
                if (notas.esp1 == null || notas.esp2 == null || notas.esp3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 1);
                }
                if (notas.cie1 == null || notas.cie2 == null || notas.cie3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 2);
                }
                if (notas.estsoc1 == null || notas.estsoc2 == null || notas.estsoc3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 3);
                }
                if (notas.mat1 == null || notas.mat2 == null || notas.mat3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 4);
                }
                if (notas.ing1 == null || notas.ing2 == null || notas.ing3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 6);
                }
                if (notas.civ1 == null || notas.civ2 == null || notas.civ3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 11);
                }
                if (notas.talI1 == null || notas.talI2 == null || notas.talI3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 312);
                }
                if (notas.talII1 == null || notas.talII2 == null || notas.talII3 == null)
                {
                    CambiaNota((int)notas.idMatricula, 8, 313);
                }
            }
            MessageBox.Show("Importación terminada");
        }

        private void CambiaNota(int mat, int nivel, int asig)
        {
            int[] talleres = new AsignaturaBussiness().TalleresDesdeAnual(
                new MatriculaBussines().CedulaXMatricul(mat), 8);

            NotaBussines nb = new NotaBussines();
            decimal nota;

            nb.delNotasXMatNivelAsig(mat, nivel, asig);

            if (asig == 312)
            {
                nota = new NotaBussines().SeleccNotaDesdeAnual(
                    new MatriculaBussines().CedulaXMatricul(mat), nivel, talleres[0]);
            }
            else if (asig == 313)
            {
                nota = new NotaBussines().SeleccNotaDesdeAnual(
                    new MatriculaBussines().CedulaXMatricul(mat), nivel, talleres[1]);
            }
            else
            {
                nota = new NotaBussines().SeleccNotaDesdeAnual(
                    new MatriculaBussines().CedulaXMatricul(mat), nivel, asig);
            }

            for (int i = 1; i <= 3; i++)
            {
                nb.guardarNota(new Nota()
                {
                    Matricula = mat,
                    Asignatura = asig,
                    Nivel = nivel,
                    Periodo = i,
                    Calificacion = nota,
                });
            }
        }
        #endregion
    }
    #endregion
}
