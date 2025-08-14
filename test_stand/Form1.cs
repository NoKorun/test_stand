using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_stand
{
    public partial class Form1 : Form
    {
        string[] pids = { "1", "2", "3", "4"};

        public Form1()
        {
            InitializeComponent();

            //testControl1.Visible = false; // Initially hide the control
        }

        private void testControl1_Load(object sender, EventArgs e)
        {

        }

        private void pid_input_button_Click(object sender, EventArgs e)
        {
            if (pids.Contains(pidBox.Text))
            {
                //testControl1.Visible = true; // Show the control if PID is valid
                testControl1.InputText = pidBox.Text;
                testControl1.ProgramStatus = "AwaitingTest";
                //pid_input_button.Visible = false; // Disable the button after valid input
                //pidBox.Visible = false; // Hide the PID input box after valid input
            }
            else
            {
                MessageBox.Show("Invalid PID. Please enter a valid PID.");
                //testControl1.Visible = false; // Hide the control if PID is invalid
            }
        }

        private void pidBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
