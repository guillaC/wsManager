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
    public partial class informationsForm : Form
    {
        private Webshell selectedWebShell;

        public void refreshListViewInfos(Webshell ws)
        {
            IDictionary<string, string> inf = ws.queryInformation(ws.getUrl(), ws.getParam());
            foreach (KeyValuePair<string,string> oneInformation in inf)
            { 
                lvInformations.Items.Add(new ListViewItem(new string[] { oneInformation.Key, oneInformation.Value}));
            }
        }

        public informationsForm(Webshell selectedWs)
        {
            this.selectedWebShell = selectedWs;
            InitializeComponent();
            this.Text = "Server Information - " + selectedWs.getUrl();
            refreshListViewInfos(selectedWebShell);
        }
    }
}
