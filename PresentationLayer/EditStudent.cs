using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EditStudent : Form
    {
        int Id;

        public EditStudent(int tipo)
        {
            InitializeComponent();
            if (tipo==1)
            {
                lblTitle.Text = "Nuevo estudiante";
            }
            else
            {
                lblTitle.Text = "Editar estudiante";
            }
        }

        public EditStudent(int tipo, int id)
        {
            InitializeComponent();
            if (tipo == 1)
            {
                lblTitle.Text = "Nuevo estudiante";
            }
            else
            {
                lblTitle.Text = "Editar estudiante";
            }

            Id = id;
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
