using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButtonMultiLine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMultiLine.Checked)
            {
                richTextBox.Height = 200;
                richTextBox.ScrollBars = RichTextBoxScrollBars.None;
            }
        }

        private void RadioButtonHScroll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHScroll.Checked)
            {
                richTextBox.Height = 50;
                richTextBox.ScrollBars = RichTextBoxScrollBars.Horizontal;
            }
        }

        private void RadioButtonVScroll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVScroll.Checked)
            {
                richTextBox.Height = 30;
                richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            }
        }
    }
}
