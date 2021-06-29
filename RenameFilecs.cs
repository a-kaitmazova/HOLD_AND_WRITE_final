using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HOLD_AND_WRITE
{
    public partial class RenameFilecs : Form
    {
        public RenameFilecs()
        {
            InitializeComponent();

            treeViewFiles.ImageList = HoldAndWrite.images;

            SetTreeView();

            treeViewFiles.ExpandAll();
        }

        private void RenameFile_Click(object sender, EventArgs e)
        {
            string newBookDirectory = treeViewFiles.SelectedNode.Name.Replace(treeViewFiles.SelectedNode.Text, textBoxRenameFile.Text + ".txt");
            string oldBookDirectory = treeViewFiles.SelectedNode.Name;

            string oldSynDirectory = treeViewFiles.SelectedNode.Name.Replace(treeViewFiles.SelectedNode.Text, "@_" + treeViewFiles.SelectedNode.Text);
            string newSynDirectory = treeViewFiles.SelectedNode.Name.Replace(treeViewFiles.SelectedNode.Text, "@_" + textBoxRenameFile.Text + ".txt");

            if (treeViewFiles.SelectedNode.ImageIndex == 2 || treeViewFiles.SelectedNode.SelectedImageIndex == 2)
            {
                if (!(textBoxRenameFile.Text.Contains(@"\") ||
                    textBoxRenameFile.Text.Contains(@"/") ||
                    textBoxRenameFile.Text.Contains(@":") ||
                    textBoxRenameFile.Text.Contains(@"*") ||
                    textBoxRenameFile.Text.Contains(@"?") ||
                    textBoxRenameFile.Text.Contains(@"<") ||
                    textBoxRenameFile.Text.Contains(@">") ||
                    textBoxRenameFile.Text.Contains(@"|")))
                {
                    if (!Directory.Exists(newBookDirectory))
                    {
                        File.WriteAllLines(newBookDirectory, File.ReadAllLines(oldBookDirectory));
                        File.WriteAllLines(newSynDirectory, File.ReadAllLines(oldSynDirectory));

                        File.Delete(oldBookDirectory);
                        File.Delete(oldSynDirectory);

                        textBoxRenameFile.Text = "";

                        treeViewFiles.Nodes.Clear();
                        SetTreeView();
                        treeViewFiles.ExpandAll();
                    }
                    else
                        MessageBox.Show("Файл с таким именем уже существует! Придумайте что-нибудь другое.", "Уже есть!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("В именах файлов нельзя использовать символы: \n / \\ : * ? < > |", "Недопустимые символы!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл, для переименования.", "Выберете файл!", MessageBoxButtons.OK);
            }
        }

        private void CancelRenameFile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetTreeView()
        {
            treeViewFiles.BeginUpdate();

            treeViewFiles.Nodes.Add(GetBookNodeName(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]));

            treeViewFiles.EndUpdate();
        }

        public TreeNode GetBookNodeName(string directory)
        {
            TreeNode motherNode = new TreeNode();
            if (Directory.GetDirectories(directory).Length > 0)
            {
                foreach (var e in Directory.GetDirectories(directory))
                {
                    if (Directory.GetFiles(e).Length > 0)
                    {
                        motherNode.Nodes.Add(GetFileNames(e, e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books].Length + 1)));
                    }
                    else
                    { 
                        TreeNode node = new TreeNode();
                        node.Text = e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Books].Length + 1);
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1; 
                        motherNode.Nodes.Add(node);
                    }
                } 
            }

            motherNode.ImageIndex = 0;
            motherNode.SelectedImageIndex = 0;
            motherNode.Text = "Книги";

            return motherNode;
        }

        public TreeNode GetFileNames(string path, string folderName)
        {
            TreeNode node = new TreeNode();
            foreach(var e in Directory.GetFiles(path))
            {
                if (e.IndexOf("@_") < 0)
                {
                    TreeNode temp = new TreeNode();
                    temp.Text = e.Substring(e.IndexOf(folderName) + folderName.Length + 1);
                    temp.Name = e;
                    temp.ImageIndex = 2;
                    temp.SelectedImageIndex = 2;
                    temp.Name = e;
                    node.Nodes.Add(temp);
                }
            }

            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            node.Text = folderName;

            return node;
        }

        private void SelectFile(object sender, TreeViewEventArgs e)
        {
            if (treeViewFiles.SelectedNode.ImageIndex == 2 || treeViewFiles.SelectedNode.SelectedImageIndex == 2)
                textBoxRenameFile.Text = treeViewFiles.SelectedNode.Text.Replace(".txt", "");
        }

        /*
                    using (StreamWriter fl2 = new StreamWriter(newSynDirectory, false))
                    {
                        foreach (var g in File.ReadAllLines(oldSynDirectory))
                        {
                            fl2.WriteLine(g);
                        }
                    }
                    
                     using (StreamWriter fl1 = new StreamWriter(newBookDirectory, false))
                    {
                        foreach (var y in File.ReadAllLines(oldBookDirectory))
                        {
                            fl1.WriteLine(y);
                        }
                    }
                    //--------------------------------------------------------------------
                    using (StreamWriter sw = File.CreateText(newBookDirectory))
                    {
                        foreach (var s in File.ReadAllLines(oldBookDirectory))
                        {
                            sw.WriteLine(s);
                        }
                    }

                    using (StreamWriter sw = File.CreateText(newSynDirectory))
                    {
                        foreach (var s in File.ReadAllLines(oldSynDirectory))
                        {
                            sw.WriteLine(s);
                        }
                    } 
                    */
    }
}
