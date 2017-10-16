using BussinesLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            prgBarConfig.Maximum = new MatriculaBussines().qtyMatsCursoActivo() * 2;
            prgBarConfig.Minimum = 0;
            prgBarConfig.Step = 1;
        }

        private void btnImpCalif_Click(object sender, EventArgs e)
        {
            try
            {
                CalificacionesBussines cal = new CalificacionesBussines();
                cal.addAvance += Cal_addAvance;
                List<Calificaciones> calis = cal.ListarCalificacionesTRendimiento();

                /*new Nota
                {
                    Matricula = matricula,
                    Asignatura = asignatura,
                    Nivel = nivel,
                    Periodo = periodo,
                    Calificacion = nota
                }

                foreach (Calificaciones cali in calis)
                {
                    //cali.califCiencias1Oct

                }*/
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void guardarNota(Nota nota)
        {
            NotaBussines nt = new NotaBussines();
            nt.guardarNota(nota);
        }

        private void Cal_addAvance()
        {
            avanzaBarra("matriculas", new MatriculaBussines().qtyMatsCursoActivo());
            statusStripConfig.Update();
        }
        private void avanzaBarra(string tipo, int max)
        {
            prgBarConfig.Value++;
            toolStripStatusLblConfig.Text = string.Format("Importando {0}: {1} de {2}.",
                tipo, prgBarConfig.Value, max);
        }
    }
}
