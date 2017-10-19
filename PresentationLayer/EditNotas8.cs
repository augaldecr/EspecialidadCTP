using BussinesLayer;
using Entities;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EditNotas8 : Form
    {
        enum asign
        {
            Spa = 1,
            Cie = 2,
            Stud = 3,
            Mate = 4,
            Ing = 6,
            Civ = 11,
            Tal1 = 12,
            Tal2 = 13
        };

        public delegate void refreshDTNotas8();
        public event refreshDTNotas8 RfDTNotas8;

        NotasBasicas notas;

        public EditNotas8(int matricula)
        {
            InitializeComponent();
            llenaCampos(matricula);
        }

        private void llenaCampos(int matricula)
        {
            notas = new NotaBussines().notasBasicasXMatYNivel(matricula, 8);
            txtBoxStudent.Text = notas.nombreCompleto;
            txtBoxEsp1.Text = notas.esp1.ToString();
            txtBoxEsp2.Text = notas.esp2.ToString();
            txtBoxEsp3.Text = notas.esp3.ToString();
            txtBoxCie1.Text = notas.cie1.ToString();
            txtBoxCie2.Text = notas.cie2.ToString();
            txtBoxCie3.Text = notas.cie3.ToString();
            txtBoxEstSoc1.Text = notas.estsoc1.ToString();
            txtBoxEstSoc2.Text = notas.estsoc2.ToString();
            txtBoxEstSoc3.Text = notas.estsoc3.ToString();
            txtBoxMate1.Text = notas.mat1.ToString();
            txtBoxMate2.Text = notas.mat2.ToString();
            txtBoxMate3.Text = notas.mat3.ToString();
            txtBoxIng1.Text = notas.ing1.ToString();
            txtBoxIng2.Text = notas.ing2.ToString();
            txtBoxIng3.Text = notas.ing3.ToString();
            txtBoxCiv1.Text = notas.civ1.ToString();
            txtBoxCiv2.Text = notas.civ2.ToString();
            txtBoxCiv3.Text = notas.civ3.ToString();
            txtBoxTali1.Text = notas.talI1.ToString();
            txtBoxTali2.Text = notas.talI2.ToString();
            txtBoxTali3.Text = notas.talI3.ToString();
            txtBoxTalii1.Text = notas.talII1.ToString();
            txtBoxTalii2.Text = notas.talII2.ToString();
            txtBoxTalii3.Text = notas.talII3.ToString();
        }

        private void btnEditNotas_Click(object sender, EventArgs e)
        {
            if (txtBoxEsp1.Text != notas.esp1.ToString())
            {
                if (notas.id_esp1!=null)
                {
                    new NotaBussines().editNota(new Nota() { IdNota = notas.id_esp1, Calificacion = notas.esp1 });
                } else
                {
                    new NotaBussines().guardarNota(new Nota() { Matricula = notas.idMatricula, Asignatura = 1,
                        Nivel = 8, Periodo = 1, Calificacion = decimal.Parse(txtBoxEsp1.Text)});
                }
            }
            if (txtBoxEsp2.Text != notas.esp2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_esp2, Calificacion = notas.esp2 });
            }
            if (txtBoxEsp3.Text != notas.esp3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_esp3, Calificacion = notas.esp2 });
            }
            if (txtBoxCie1.Text != notas.cie1.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_cie1, Calificacion = notas.cie1 });
            }
            if (txtBoxCie2.Text != notas.cie2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_cie2, Calificacion = notas.cie2 });
            }
            if (txtBoxCie3.Text != notas.cie3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_cie3, Calificacion = notas.cie3 });
            }
            if (txtBoxEstSoc1.Text != notas.estsoc1.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_estsoc1, Calificacion = notas.estsoc1 });
            }
            if (txtBoxEstSoc2.Text != notas.estsoc2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_estsoc2, Calificacion = notas.estsoc2 });
            }
            if (txtBoxEstSoc3.Text != notas.estsoc3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_estsoc3, Calificacion = notas.estsoc3 });
            }
            if (txtBoxMate1.Text != notas.mat1.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_mat1, Calificacion = notas.mat1 });
            }
            if (txtBoxMate2.Text != notas.mat2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_mat2, Calificacion = notas.mat2 });
            }
            if (txtBoxMate3.Text != notas.mat3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_mat3, Calificacion = notas.mat3 });
            }
            if (txtBoxIng1.Text != notas.ing1.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_ing1, Calificacion = notas.ing1 });
            }
            if (txtBoxIng2.Text != notas.ing2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_ing2, Calificacion = notas.ing2 });
            }
            if (txtBoxIng3.Text != notas.ing3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_ing3, Calificacion = notas.ing3 });
            }
            if (txtBoxCiv1.Text != notas.civ1.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_civ1, Calificacion = notas.civ1 });
            }
            if (txtBoxCiv2.Text != notas.civ2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_civ2, Calificacion = notas.civ2 });
            }
            if (txtBoxCiv3.Text != notas.civ3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_civ3, Calificacion = notas.civ3 });
            }
            if (txtBoxTali1.Text != notas.talI1.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_talI1, Calificacion = notas.talI1 });
            }
            if (txtBoxTali2.Text != notas.talI2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_talI2, Calificacion = notas.talI2 });
            }
            if (txtBoxTali3.Text != notas.talI3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_talI3, Calificacion = notas.talI3 });
            }
            if (txtBoxTalii1.Text != notas.talII1.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_esp1, Calificacion = notas.esp1 });
            }
            if (txtBoxTalii2.Text != notas.talII2.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_talII1, Calificacion = notas.talII1 });
            }
            if (txtBoxTalii3.Text != notas.talII3.ToString())
            {
                new NotaBussines().editNota(new Nota() { IdNota = notas.id_talII3, Calificacion = notas.talII3 });
            }
            RfDTNotas8();
            MessageBox.Show("Cambios aplicados de manera adecuada");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            RfDTNotas8();
            this.Dispose();
        }
    }
}
