using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{
    /// <summary>
    /// LoginForm class used to validate the username and password and grants acces to the tech support application
    /// Author: Alyssa Harris
    /// Version: 1/23/23
    /// </summary>
    public partial class LoginForm : Form
    {
        public static string usernameEntered = "";
        private MainForm mainForm;

        /// <summary>
        /// Initializes a new instance of the LoginForm class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Jane" && passwordLabel.Text == "test1234")
            {
                usernameEntered= "Jane";
                HideErrorMessage();

                if (mainForm == null)
                {
                    mainForm = new MainForm();
                    FormClosed += MainForm_FormClosed;
                }

                mainForm.Show(this);
                Hide();
            }
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text= "";
        }

        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "Invalid Username/Password";
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }
    }
}
