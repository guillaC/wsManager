using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webshellManager
{
    public partial class screenshotForm : Form
    {
        private Webshell selectedWebShell;
        
        public screenshotForm(Webshell selected)
        {
            this.selectedWebShell = selected;
            InitializeComponent();
            this.Text = "Screenviewer - " + selected.getUrl();
        }

        private void btnScrnShot_Click(object sender, EventArgs e)
        {
            screen.Image = selectedWebShell.takeScreenshot();
        }
    }
}
