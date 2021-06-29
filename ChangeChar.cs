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
    public partial class ChangeChar : Form
    {
        public static string curGender;
        public static string curRole;
        public string[] card;
        public string[] temp;
        public ChangeChar()
        {
            InitializeComponent();

            pictureWithoutCard.Image = Properties.Resources._char;
            pictureWithoutCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureWithoutCard.Visible = true;
            listCharacters.Items.AddRange(NameList());

            this.Icon = Properties.Resources.char_ico;
        }

        private void ChangeChar_Click(object sender, EventArgs e)
        {
            temp = new []{ textBoxName.Text, curGender, textBoxAge.Text, curRole };
            card = AllCard();

            File.Delete(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + listCharacters.SelectedItem.ToString());
            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text + ".txt", card);
                MessageBox.Show("Карточка персонажа изменена!", "Изменение", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Персонаж с именем " + textBoxName.Text + " уже существует! Придумайте что-нибудь другое.", "Уже существует!", MessageBoxButtons.OK);
            RefreshList();
            CleanCard();
            pictureWithoutCard.Visible = true;
        }

        public string[] AllCard()
        {
            List<string> s = new List<string>();
            foreach (var e in temp)
            {
                s.Add(e);
            }
            foreach (var i in textBoxAbout.Lines)
            {
                s.Add(i);
            }
            return s.ToArray();
        }

        private void CancelChangeChar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] NameList()
        {
            List<string> namesList = new List<string>();
            foreach (var e in Directory.GetFiles(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters]))
            {
                namesList.Add(e.Substring(e.IndexOf(HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters]) + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters].Length + 1));
            }
            return namesList.ToArray();
        }

        private void listCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureWithoutCard.Visible = false;
            if (listCharacters.SelectedItem != null)
            {
                card = File.ReadAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + listCharacters.SelectedItem.ToString());

                pictureWithoutCard.Visible = false;

                textBoxName.Text = card[0];
                switch (card[1])
                {
                    case "female": checkGenFem.Checked = true; curGender = "female"; break;
                    case "male": checkGenMale.Checked = true; curGender = "male"; break;
                    case "other": checkOther.Checked = true; curGender = "other"; break;
                }
                textBoxAge.Text = card[2];
                switch (card[3])
                {
                    case "main": checkMain.Checked = true; curRole = "main"; break;
                    case "sec": checkSecond.Checked = true; curRole = "sec"; break;
                    case "cameo": checkCameo.Checked = true; curRole = "cameo"; break;
                    case "ment": checkMent.Checked = true; curRole = "ment"; break;
                }
                textBoxAbout.Lines = CardText(card, 4);
            }
        }

        public string[] CardText(string[] source, int n)
        {
            List<string> temp = new List<string>();
            int i = 0;
            foreach(var e in source)
            {
                if (i >= n)
                {
                    temp.Add(e); 
                }
                i++;
            }
            return temp.ToArray();
        }

        public void RefreshList()
        {
            listCharacters.Items.Clear();
            listCharacters.Items.AddRange(NameList());
        }

        private void GenMale_CheckedChanged(object sender, EventArgs e)
        {
            curGender = "male";
            UncheckGen();
            checkGenMale.Checked = true;
        }

        private void GenFem_CheckedChanged(object sender, EventArgs e)
        {
            curGender = "female";
            UncheckGen();
            checkGenFem.Checked = true;
        }

        private void Other_CheckedChanged(object sender, EventArgs e)
        {
            curGender = "other";
            UncheckRole();
            checkOther.Checked = false;
        }

        private void Main_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "main";
            UncheckRole();
            checkMain.Checked = true;
        }

        private void Second_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "sec";
            UncheckRole();
            checkSecond.Checked = false;
        }

        private void Cameo_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "cameo";
            UncheckRole();
            checkCameo.Checked = false;
        }

        private void Ment_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "ment";
            UncheckRole();
            checkMent.Checked = false;
        }

        public void UncheckRadio()
        {
            UncheckGen();
            UncheckRole();
        }

        public void UncheckGen() 
        {
            checkGenMale.Checked = false;
            checkGenFem.Checked = false;
            checkOther.Checked = false;
        }

        public void UncheckRole()
        {
            checkMain.Checked = false;
            checkSecond.Checked = false;
            checkCameo.Checked = false;
            checkMent.Checked = false;
        }

        public void CleanCard()
        {
            textBoxName.Text = "";
            curGender = "non";
            textBoxAge.Text = "";
            textBoxAbout.Text = "";
            curRole = "non";
            UncheckRadio();
        }
    }
}
