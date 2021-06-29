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
    public partial class ShowItem : Form
    {
        public ShowItem()
        {
            InitializeComponent();

            SetCard();
        }

        private void buttonCancelShowItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetCard()
        {
            string[] card = File.ReadAllLines(HoldAndWrite.charPath);
            labelName.Text = card[0];
            textBoxItem.Lines = CardText(card, 1);
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
