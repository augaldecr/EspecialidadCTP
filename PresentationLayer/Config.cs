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

                foreach (Calificaciones cali in calis)
                {
                    foreach (Nota nota in cali.Notas)
                    {
                        new NotaBussines().guardarNota(nota);
                    }
                    avanzaBarra("Guardando", "calificaciones", calis.Count);
                }
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
            avanzaBarra("Recuperando", "calificaciones", new MatriculaBussines().qtyMatsCursoActivo());
        }
        private void avanzaBarra(string accion, string tipo, int max)
        {
            prgBarConfig.Value++;
            toolStripStatusLblConfig.Text = string.Format("{0} {1} desde PIAD: {2} de {3}.",
                accion, tipo, prgBarConfig.Value, max);
            statusStripConfig.Update();
        }
    }
}
