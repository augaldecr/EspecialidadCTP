using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(15625);

            InitializeComponent();

            t.Abort();
        }

        public void splash()
        {
            Application.Run(new SplashScreen());
        }

    }
}
