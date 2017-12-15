using BussinesLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        private async void btnImpCalif_Click(object sender, EventArgs e)
        {
            await ImportaNotas();
        }

        private async Task ImportaNotas()
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

        private void btnGenResults_Click(object sender, EventArgs e)
        {
            string pass;

            pass = Microsoft.VisualBasic.Interaction.InputBox("Para generar el cálculo de calificaciones obtenidas, ingrese la contraseña", "Ingrese contraseña ", "Contraseña", 100, 0);

            if (pass == "selvanegra$2015")
            {
                try
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        for (int i = 1; i <= 12; i++)
                        {
                            int limitInicial;

                            if (i == 3 || i == 4 || i == 9 || i == 11)
                            {
                                limitInicial = 18;
                            }
                            else
                            {
                                limitInicial = 32;
                            }

                            int limit = limitInicial;
                            int qty = 0;

                            qty = new MatriculaBussines().qtyMatsEspeX(i);

                            if (limitInicial > qty)
                            {
                                if (limit > qty)
                                {
                                    limit = limit - qty;
                                }
                                else
                                {
                                    limit = qty - limit;
                                }
                            }
                            else
                            {
                                limit = 0;
                            }

                            if (limit != 0)
                            {
                                List<Matricula> notasElecciones = new NotaBussines().ListaNotasEleccion(i, j, limit);
                                foreach (var nota in notasElecciones)
                                {
                                    nota.Especialidadx = i;
                                    new MatriculaBussines().modificaEspecialidadX(nota);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
