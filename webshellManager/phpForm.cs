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
    public partial class phpForm : Form
    {

        private Webshell selectedWebShell;
        
        public phpForm(Webshell selected)
        {
            this.selectedWebShell = selected;
            InitializeComponent();
            this.Text = "Php Exec - " + selected.getUrl();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            webBrowser.DocumentText = this.selectedWebShell.phpexec(tbPhp.Text);
        }
    }
}
