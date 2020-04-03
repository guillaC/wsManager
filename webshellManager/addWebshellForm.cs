using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace webshellManager
{
    public partial class addWebshellForm : Form
    {
        private List<Webshell> webshells;
        private wsManagerForm parentfrm;

        public addWebshellForm(ref List<Webshell> wss, wsManagerForm parent)
        {
            InitializeComponent();
            this.Text = "Add - ";
            this.webshells = wss;
            this.parentfrm = parent;
        }

        private bool isNotDuplicate(string pUrl)
        {
            foreach (Webshell ws in webshells)
            {
                if (ws.getUrl().ToLower() == pUrl.ToLower()) return false;
            }
            return true;
        }
        
        private bool isValid(string pUrl, string pParam)
        {
            Random rnd = new Random();
            string result = "";
            int rand = rnd.Next(100000, 999999);
            WebClient client = new WebClient();
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;
            try
            {
                result = client.DownloadString(pUrl + "?" + pParam + "=echo \"" + rand.ToString() + "\";");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (result.Contains(rand.ToString()))
            {
                return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isNotDuplicate(tbURL.Text))
            {
                if (isValid(tbURL.Text, tbParam.Text))
                {
                    Webshell newWS = new Webshell(tbURL.Text, tbParam.Text);
                    webshells.Add(newWS);
                    parentfrm.refreshListViewInfos();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("this webshell is already registered");
            }
        }
    }
}
