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
    public partial class CreateChar : Form
    {
        public static string curGender = "non";
        public static string curRole = "non";
        public static string[] temp;
        public static string[] card;
        public CreateChar()
        {
            InitializeComponent();
        }

        private void SaveChar_Click(object sender, EventArgs e)
        {
            temp = new[] { textBoxName.Text, curGender, textBoxAge.Text, curRole };
            card = AllCard(textBoxAbout.Lines);

            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text) && ! (textBoxName.Text == "Персонажи"))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text + ".txt", card);
                MessageBox.Show("Карточка персонажа добавлена!", "Создание", MessageBoxButtons.OK);
            }
            else
            {
                if (File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Characters] + @"\" + textBoxName.Text)) MessageBox.Show("Персонаж с именем " + textBoxName.Text + " уже существует! Придумайте что-нибудь другоею.", "Уже существует!", MessageBoxButtons.OK);
                if (textBoxName.Text == "Персонажи") MessageBox.Show("Недопустимое название! Придумайте что-нибудь другоею.", "Имя директории", MessageBoxButtons.OK);
            }
            CleanCard();
        }

        public string[] AllCard(string[] textBox)
        {
            List<string> s = new List<string>();
            foreach(var e in temp)
            {
                s.Add(e);
            }
            foreach(var i in textBox)
            {
                s.Add(i);
            }
            return s.ToArray();
        }

        public void UncheckRadio()
        {
            UncheckRole();
            UncheckGen();
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

        private void CancelSaveChar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            UncheckGen();
            checkOther.Checked = true;
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
            checkSecond.Checked = true;
        }

        private void Cameo_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "cameo";
            UncheckRole();
            checkCameo.Checked = true;
        }

        private void Ment_CheckedChanged(object sender, EventArgs e)
        {
            curRole = "ment";
            UncheckRole();
            checkMent.Checked = true;
        }
    }
}
