using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            prgBar.Maximum = 642;
            prgBar.Step = 1;
            prgBar.Minimum = 0;
        }
    }
}
