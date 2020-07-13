using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Lesson8_Part1
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method chnages the text property of the WelcomeLabel depending on its initial vlaue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickmeButton_Click(object sender, EventArgs e)
        {
            WelcomeLabel.Text = (WelcomeLabel.Text == "Hello, World!") ? "Clicked!" : "Hello, World!";
        }
    }
}
