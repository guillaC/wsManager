using System;
using System.Windows.Forms;

namespace webshellManager
{
    public partial class shellForm : Form
    {
        private Webshell selectedWebShell;

        public shellForm(Webshell selected)
        {
            this.selectedWebShell = selected;
            InitializeComponent();
            this.Text = "Shell - " + selected.getUrl();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            tbOutput.Text = this.selectedWebShell.shellexec(tbShell.Text);
        }
    }
}