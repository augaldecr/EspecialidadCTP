using BussinesLayer;
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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void btnCursoLectivo_Click(object sender, EventArgs e)
        {

        }

        private void btnImpCalif_Click(object sender, EventArgs e)
        {
            CalificacionesBussines cal = new CalificacionesBussines();
            cal.ListarCalificaciones();
        }
    }
}
