using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class Lab8Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the constructor of lab8
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler of submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + "  " + AgeTextBox.Text;

            NameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;

           
        }
        /// <summary>
        /// This is the event handler for the lab8 form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
    }
}
