﻿using System;
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
    public partial class CreateItem : Form
    {
        public string[] itemCard;
        public CreateItem()
        {
            InitializeComponent();
        }

        private void buttonCreateItem_Click(object sender, EventArgs e)
        {
            itemCard = AllCard();

            if (!File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items] + @"\" + textBoxItemName.Text + ".txt") && !(textBoxItemName.Text == "Предметы"))
            {
                File.WriteAllLines(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items] + @"\" + textBoxItemName.Text + ".txt", itemCard);
                MessageBox.Show("Карточка предмета добавлена!", "Создание", MessageBoxButtons.OK);
            }
            else
            {
                if (File.Exists(HoldAndWrite.directory + @"\" + HoldAndWrite.foldersNames[(int)HoldAndWrite.MainFolders.Items] + @"\" + textBoxItemName.Text + ".txt")) MessageBox.Show("Предмет с названием " + textBoxItemName.Text + " уже существует! Придумйте что-нибудь другое.", "Уже было!", MessageBoxButtons.OK);
                if (textBoxItemName.Text == "Предметы") MessageBox.Show("Недопустимое название! Придумйте что-нибудь другое.", "Имя директории", MessageBoxButtons.OK);
            }
            textBoxItemName.Text = ""; textBoxItem.Text = "";
        }

        public string[] AllCard()
        {
            List<string> s = new List<string>();
            s.Add(textBoxItemName.Text);
            foreach (var e in textBoxItem.Lines)
            {
                s.Add(e);
            }
            return s.ToArray();
        }

        private void buttonCancelCreateItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
