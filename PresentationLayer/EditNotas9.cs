using BussinesLayer;
using Entities;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EditNotas9 : Form
    {
        public delegate void refreshDTNotas9();
        public event refreshDTNotas9 RfDTNotas9;

        NotasBasicas notas;

        public EditNotas9(int matricula)
        {
            InitializeComponent();
            llenaCampos(matricula);
        }

        private void llenaCampos(int matricula)
        {
            notas = new NotaBussines().notasBasicasXMatYNivel(matricula, 9);
            txtBoxStudent.Text = notas.nombreCompleto;
            txtBoxEsp1.Text = notas.esp1.ToString();
            txtBoxEsp2.Text = notas.esp2.ToString();
            txtBoxCie1.Text = notas.cie1.ToString();
            txtBoxCie2.Text = notas.cie2.ToString();
            txtBoxEstSoc1.Text = notas.estsoc1.ToString();
            txtBoxEstSoc2.Text = notas.estsoc2.ToString();
            txtBoxMate1.Text = notas.mat1.ToString();
            txtBoxMate2.Text = notas.mat2.ToString();
            txtBoxIng1.Text = notas.ing1.ToString();
            txtBoxIng2.Text = notas.ing2.ToString();
            txtBoxCiv1.Text = notas.civ1.ToString();
            txtBoxCiv2.Text = notas.civ2.ToString();
            txtBoxTali1.Text = notas.talI1.ToString();
            txtBoxTali2.Text = notas.talI2.ToString();
            txtBoxTalii1.Text = notas.talII1.ToString();
            txtBoxTalii2.Text = notas.talII2.ToString();
        }

        private void btnEditNotas_Click(object sender, EventArgs e)
        {
            if (txtBoxEsp1.Text != notas.esp1.ToString())
            {
                if (notas.id_esp1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_esp1, Calificacion = decimal.Parse(txtBoxEsp1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 1,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxEsp1.Text)
                    });
                }
            }
            if (txtBoxEsp2.Text != notas.esp2.ToString())
            {
                if (notas.id_esp2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_esp2, Calificacion = decimal.Parse(txtBoxEsp2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 1,
                        Nivel = 9,
                        Periodo = 2,
                        Calificacion = decimal.Parse(txtBoxEsp2.Text)
                    });
                }
            }
            if (txtBoxCie1.Text != notas.cie1.ToString())
            {
                if (notas.id_cie1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_cie1, Calificacion = decimal.Parse(txtBoxCie1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 2,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxCie1.Text)
                    });
                }
            }
            if (txtBoxCie2.Text != notas.cie2.ToString())
            {
                if (notas.id_cie2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_cie2, Calificacion = decimal.Parse(txtBoxCie2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 2,
                        Nivel = 9,
                        Periodo = 2,
                        Calificacion = decimal.Parse(txtBoxCie2.Text)
                    });
                }
            }
            if (txtBoxEstSoc1.Text != notas.estsoc1.ToString())
            {
                if (notas.id_estsoc1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_estsoc1, Calificacion = decimal.Parse(txtBoxEstSoc1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 3,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxEstSoc1.Text)
                    });
                }
            }
            if (txtBoxEstSoc2.Text != notas.estsoc2.ToString())
            {
                if (notas.id_estsoc2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_estsoc2, Calificacion = decimal.Parse(txtBoxEstSoc2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 3,
                        Nivel = 9,
                        Periodo =2,
                        Calificacion = decimal.Parse(txtBoxEstSoc2.Text)
                    });
                }
            }
            if (txtBoxMate1.Text != notas.mat1.ToString())
            {
                if (notas.id_mat1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_mat1, Calificacion = decimal.Parse(txtBoxMate1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 4,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxMate1.Text)
                    });
                }
            }
            if (txtBoxMate2.Text != notas.mat2.ToString())
            {
                if (notas.id_mat2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_mat2, Calificacion = decimal.Parse(txtBoxMate2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 4,
                        Nivel = 9,
                        Periodo = 2,
                        Calificacion = decimal.Parse(txtBoxMate2.Text)
                    });
                }
            }
            if (txtBoxIng1.Text != notas.ing1.ToString())
            {
                if (notas.id_ing1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_ing1, Calificacion = decimal.Parse(txtBoxIng1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 6,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxIng1.Text)
                    });
                }
            }
            if (txtBoxIng2.Text != notas.ing2.ToString())
            {
                if (notas.id_ing2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_ing2, Calificacion = decimal.Parse(txtBoxIng2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 6,
                        Nivel = 9,
                        Periodo = 2,
                        Calificacion = decimal.Parse(txtBoxIng2.Text)
                    });
                }
            }
            if (txtBoxCiv1.Text != notas.civ1.ToString())
            {
                if (notas.id_civ1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_civ1, Calificacion = decimal.Parse(txtBoxCiv1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 11,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxCiv1.Text)
                    });
                }
            }
            if (txtBoxCiv2.Text != notas.civ2.ToString())
            {
                if (notas.id_civ2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_civ2, Calificacion = decimal.Parse(txtBoxCiv2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 11,
                        Nivel = 9,
                        Periodo = 2,
                        Calificacion = decimal.Parse(txtBoxCiv2.Text)
                    });
                }
            }
            if (txtBoxTali1.Text != notas.talI1.ToString())
            {
                if (notas.id_talI1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_talI1, Calificacion = decimal.Parse(txtBoxTali1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 12,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxTali1.Text)
                    });
                }
            }
            if (txtBoxTali2.Text != notas.talI2.ToString())
            {
                if (notas.id_talI2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_talI2, Calificacion = decimal.Parse(txtBoxTali2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 12,
                        Nivel = 9,
                        Periodo = 2,
                        Calificacion = decimal.Parse(txtBoxTali2.Text)
                    });
                }
            }
            if (txtBoxTalii1.Text != notas.talII1.ToString())
            {
                if (notas.id_talII1 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_talII1, Calificacion = decimal.Parse(txtBoxTalii1.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 13,
                        Nivel = 9,
                        Periodo = 1,
                        Calificacion = decimal.Parse(txtBoxTalii1.Text)
                    });
                }
            }
            if (txtBoxTalii2.Text != notas.talII2.ToString())
            {
                if (notas.id_talII2 != null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_talII2, Calificacion = decimal.Parse(txtBoxTalii2.Text) });
                }
                else
                {
                    new NotaBussines().guardarNota(new Nota()
                    {
                        Matricula = notas.idMatricula,
                        Asignatura = 13,
                        Nivel = 9,
                        Periodo = 2,
                        Calificacion = decimal.Parse(txtBoxTalii2.Text)
                    });
                }
            }
            RfDTNotas9();
            MessageBox.Show("Cambios aplicados de manera adecuada");
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            RfDTNotas9();
            this.Dispose();
        }
    }
}
