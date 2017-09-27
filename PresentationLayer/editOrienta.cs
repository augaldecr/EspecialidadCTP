using BussinesLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class editOrienta : Form
    {
        int Id;
        int type;
        int matricula;

        public delegate void refreshDTOri();
        public event refreshDTOri rfDTOri;

        public editOrienta(int tipo, int matri, int id, string nombre, decimal entrevista, decimal vocacional)
        {
            InitializeComponent();
            type = tipo;
            asignaTitle(tipo);
            Id = id;
            matricula = matri;
            llenaCampos(id, nombre, entrevista, vocacional);
        }

        private void llenaCampos(int id, string nombre, decimal entrevista, decimal vocacional)
        {
            txtBoxStudent.Text = nombre;
            txtBoxEntrevista.Text = entrevista.ToString();
            txtBoxVoca.Text = vocacional.ToString();
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
            NotaBussines bs = new NotaBussines();
            if (type == 1)
            {
                bs.guardarNotaOrienta(matricula, 3, decimal.Parse(txtBoxEntrevista.Text), decimal.Parse(txtBoxVoca.Text));
            } else
            {
                bs.editNotaOrienta(Id, decimal.Parse(txtBoxEntrevista.Text), decimal.Parse(txtBoxVoca.Text));
            }
            MessageBox.Show("Información guardada de manera adecuada");
            rfDTOri();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
