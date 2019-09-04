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
    public partial class fileInformationsForm : Form
    {
        private Webshell ws;
        private string path;

        public void refreshListViewInfos(Webshell pWs, string pPath)
        {
            IDictionary<string, string> inf = ws.fileInformation(pPath);
            foreach (KeyValuePair<string, string> oneInformation in inf)
            {
                lvInformations.Items.Add(new ListViewItem(new string[] { oneInformation.Key, oneInformation.Value }));
            }
        }
        
        public fileInformationsForm(Webshell currentWs, string selectedFilePath)
        {
            this.path = selectedFilePath;
            this.ws = currentWs;
            InitializeComponent();
            this.Text = "File Information - " + selectedFilePath;
            refreshListViewInfos(this.ws, this.path);
        }
    }
}
