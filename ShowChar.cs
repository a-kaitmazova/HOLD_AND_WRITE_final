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
    public partial class ShowChar : Form
    {
        public ShowChar()
        {
            InitializeComponent();

            SetCard();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetCard()
        {
            string[] card = File.ReadAllLines(HoldAndWrite.charPath);

            nameLabel.Text = card[0];
            switch (card[1])
            {
                case "female": genLabel.Text = "женский"; break;
                case "male": genLabel.Text = "мужской"; break;
                case "other": genLabel.Text = "другое"; break;
            }
            AgeLabel.Text = card[2];
            switch (card[3])
            {
                case "main": roleLabel.Text = "Главный"; break;
                case "sec": roleLabel.Text = "Второстепенный"; break;
                case "cameo": roleLabel.Text = "Эпизодический"; break;
                case "ment": roleLabel.Text = "Упоминается"; break;
            }
            textBoxAbout.Lines = CardText(card, 4);

        }

        public string[] CardText(string[] source, int n)
        {
            List<string> temp = new List<string>();
            int i = 0;
            foreach (var e in source)
            {
                if (i >= n)
                {
                    temp.Add(e);
                }
                i++;
            }
            return temp.ToArray();
        }
    }
}
