using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace webshellManager
{
    public partial class sqlForm : Form
    {
        private Webshell selectedWebShell;

        public sqlForm(Webshell selected)
        {
            this.selectedWebShell = selected;
            InitializeComponent();
            this.Text = "SQL - " + selected.getUrl();
        }

        private void btnExecSql_Click(object sender, EventArgs e)
        {
            List<String> columns = new List<string>();
            List<List<String>> content = new List<List<String>>();
            Tuple<List<String>, List<List<String>>> data = selectedWebShell.SQLrequest(tbHost.Text, tbuname.Text, tbpass.Text, tbBdd.Text, tbSql.Text);

            columns = data.Item1;
            content = data.Item2;
            lvSql.Columns.Clear();
            lvSql.Items.Clear();

            foreach (string column in columns)
            {
                lvSql.Columns.Add(column);
            }

            foreach (List<String> entry in content)
            {
                ListViewItem lvi = new ListViewItem(entry.ToArray());
                lvSql.Items.Add(lvi);
            }
        }

        private void btnGetDbsTbls_Click(object sender, EventArgs e)
        {
            treeDB.Nodes.Clear();
            Tuple<List<String>, List<List<String>>> data = selectedWebShell.SQLrequest(tbHost.Text, tbuname.Text, tbpass.Text, tbBdd.Text, "SHOW DATABASES;");
            List<List<String>> shdatabases = data.Item2;
            List<List<String>> shtables = new List<List<String>>();

            foreach (List<String> entryDb in shdatabases)
            {
                string dbName = entryDb.First();
                TreeNode treeN = new TreeNode(dbName);
                data = selectedWebShell.SQLrequest(tbHost.Text, tbuname.Text, tbpass.Text, dbName, "SHOW TABLES;");
                shtables = data.Item2;
                foreach (List<String> entryTable in shtables)
                {
                    treeN.Nodes.Add(entryTable.First());
                }
                treeDB.Nodes.Add(treeN);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSql.Items.Count > 0 && sfdSql.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<table border=\"1\"><thead><tr>");
                foreach (ColumnHeader col in lvSql.Columns)
                {
                    sb.Append("<th>" + col.Text + "</th>");
                }
                sb.Append("</tr></thead><tbody><tr><tbody>");
                foreach (ListViewItem lvi in lvSql.Items)
                {
                    sb.Append("<tr>");
                    foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                    {
                        sb.Append("<td>" + listViewSubItem.Text + "</td>");
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</tbody></table>");
                System.IO.File.WriteAllText(sfdSql.FileName, sb.ToString());
            }
        }

        private void treeDB_DoubleClick(object sender, EventArgs e)
        {
            if (treeDB.SelectedNode.IsSelected)
            {
                if (treeDB.SelectedNode.Level == 1)
                {
                    tbBdd.Text = treeDB.SelectedNode.Parent.Text;
                    tbSql.Text = "SELECT * FROM " + treeDB.SelectedNode.Text;
                }
                else tbBdd.Text = treeDB.SelectedNode.Text;
            }
        }

        private void cmsSQL_Opening(object sender, CancelEventArgs e)
        {
            if (lvSql.Items.Count > 0) cmsSQL.Items[0].Enabled = true;
            else cmsSQL.Items[0].Enabled = false;
        }
    }
}