using BussinesLayer;
using DataLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class editOrienta : Form
    {
        int Id;
        int type;
        int matricula;
        int id1;
        int id2;
        int id3;

        public delegate void refreshDTOri();
        public event refreshDTOri rfDTOri;

        public editOrienta(int tipo, int matri, int id, string nombre,
            int esp1, string esp1_nombre, decimal nota1, int esp2, string esp2_nombre, decimal nota2, 
            int esp3, string esp3_nombre, decimal nota3, decimal vocacional)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
            Id = id;
            matricula = matri;
            id1 = esp1;
            id2 = esp2;
            id3 = esp3;
            llenaCampos(id, nombre, vocacional, esp1_nombre, nota1, esp2_nombre, nota2, esp3_nombre, nota3);
        }

        private void llenaCampos(int id, string nombre, decimal vocacional, string esp1_nombre, decimal nota1,
            string esp2_nombre, decimal nota2, string esp3_nombre, decimal nota3)
        {
            txtBoxStudent.Text = nombre;
            txtBoxVoca.Text = vocacional.ToString();
            lblEspe1.Text = esp1_nombre;
            lblEspe2.Text = esp2_nombre;
            lblEspe3.Text = esp3_nombre;
            txtBoxEspe1.Text = nota1.ToString();
            txtBoxEspe2.Text = nota2.ToString();
            txtBoxEspe3.Text = nota3.ToString();
        }

        private void asignaTitle(int tipo)
        {
            if (tipo == 1)
            {
                lblTitle.Text = "Ingresar notas orientación";
                btnGuardar.Text = "Guardar";
            }
            else
            {
                lblTitle.Text = "Editar notas orientación";
                btnGuardar.Text = "Modificar";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NotaBussines bs = new NotaBussines();
                if (type == 1)
                {
                    bs.guardarNotaOrienta(matricula, decimal.Parse(txtBoxVoca.Text));
                    if (id1 > 0)
                        bs.editNotaEleccEspe(id1, decimal.Parse(txtBoxEspe1.Text));
                    if (id2 > 0)
                        bs.editNotaEleccEspe(id2, decimal.Parse(txtBoxEspe2.Text));
                    if (id3 > 0)
                        bs.editNotaEleccEspe(id3, decimal.Parse(txtBoxEspe3.Text));
                }
                else
                {
                    bs.editNotaOrienta(Id, decimal.Parse(txtBoxVoca.Text));
                    if (id1 > 0)
                        bs.editNotaEleccEspe(id1, decimal.Parse(txtBoxEspe1.Text));
                    if (id2 > 0)
                        bs.editNotaEleccEspe(id2, decimal.Parse(txtBoxEspe2.Text));
                    if (id3 > 0)
                        bs.editNotaEleccEspe(id3, decimal.Parse(txtBoxEspe3.Text));
                }
                MessageBox.Show("Información guardada de manera adecuada");
                rfDTOri();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
