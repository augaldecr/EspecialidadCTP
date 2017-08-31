using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            prgBarSplash.Increment(1);
            if (prgBarSplash.Value == 100)
            {
                timerSplashScreen.Stop();
            }
        }
    }
}
