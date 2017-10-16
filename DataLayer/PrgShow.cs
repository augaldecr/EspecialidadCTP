using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public partial class PrgShow : Form
    {
        int avanzado = 0;

        public PrgShow()
        {
            InitializeComponent();

            //TODO: Hacer una count de matricula para establecer el máximo acá
            prgBar.Maximum = 321;
            prgBar.Step = 1;
            prgBar.Minimum = 0;
        }
        
        public void addAvance()
        {
            prgBar.Value = avanzado++;
        }
    }
}
