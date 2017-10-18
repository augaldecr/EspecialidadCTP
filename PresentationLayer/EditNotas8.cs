using BussinesLayer;
using Entities;
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
    public partial class EditNotas8 : Form
    {
        NotasBasicas notas;

        public EditNotas8(int matricula)
        {
            InitializeComponent();
            llenaCampos(matricula);
        }

        private void llenaCampos(int matricula)
        {
            NotaBussines nota = new NotaBussines();
            //notas = new NotaBussines()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
