using System;
using System.Drawing;
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
        //public static string usernameEntered = "";

        public string Username { get; set; }
        string password;

        /// <summary>
        /// Initializes a new instance of the LoginForm class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        private Boolean CheckCredentials()
        {
            Username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            return (String.Equals(Username, "jane") && String.Equals(password, "test1234"));

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (CheckCredentials())
            {

                MainDashboard newMainDashboard = new MainDashboard(this);
                newMainDashboard.Show();
                this.Hide();

            }
            else
                {
                    this.ShowInvalidErrorMessage();
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

        private void UserInputEntered(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void LogOut()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            this.Show();
        }
    }
}
