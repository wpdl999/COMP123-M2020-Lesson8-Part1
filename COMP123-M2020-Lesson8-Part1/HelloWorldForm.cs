using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            WelcomeLabel.Text = (WelcomeLabel.Text == $"Hello, {NameTextBox.Text}!") ? "Clicked!" : $"Hello, {NameTextBox.Text}!"; //Modal
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            /*Debug.WriteLine(message: "NameTextBox.Text.Length is: " + NameTextBox.Text.Length);
            var result = MessageBox.Show(text:"NameTextBox Lenth is: " + NameTextBox.Text.Length, caption:"NameTextBox Value", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Debug.WriteLine(result == DialogResult.OK ? "True" : "False");*/

            ClickmeButton.Enabled = NameTextBox.Text.Length > 1;
        }

        /// <summary>
        /// The Form Load event is triggered once, when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloWorldForm_Load(object sender, EventArgs e)
        {
            ClickmeButton.Enabled = false;
        }
    }
}
