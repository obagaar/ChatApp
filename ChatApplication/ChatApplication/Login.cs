using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChatApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //Hides the invalid login message until it is needed.
            lblInvalid.Hide();
        }

        public string _textBox1
        {
            get { return txtUsername.Text; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Sets the password text box so it masks what is typed in as an asterik.
            //Also limits length to 64 characters.
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 64;

            //Set textbox input to specific strings
            string username = txtUsername.Text.ToLower().Trim(),
                   password = txtPassword.Text.Trim();            

            //list for username and password parameters
            List<SqlParameter> sqlUserParams = new List<SqlParameter>();
            sqlUserParams.Add(new SqlParameter("@username", username));
            sqlUserParams.Add(new SqlParameter("@password", password));

            //List for email search parameter
            List<SqlParameter> sqlEmailParam = new List<SqlParameter>();
            sqlEmailParam.Add(new SqlParameter("@email", username));

            //Datatables generated for DAL based on stored procedures to validate a user 
            //login and a search to confirm if an email is already registered.
            DataTable dtLogin = DAL.ExecStoredProcedure("CheckUsers", sqlUserParams),
                      dtRegister = DAL.ExecStoredProcedure("SearchEmail", sqlEmailParam);

            //If statement to check that username and password are entered and fields are not left blank.
            if(CheckInput(username) == true && CheckInput(password) == true)
            {
                //Seperate SQLQuery to check for Email
                //If the email entered is not found the user is prompted to 
                //register.
                if (dtRegister != null && dtRegister.Rows.Count == 1)
                {
                    //If statement to check if right login info is entered.
                    //When correct chat dashboard is loaded.
                    //If not user is prompted to enter correct info.
                    if (dtLogin != null && dtLogin.Rows.Count == 1)
                    {
                        MessageBox.Show("Welcome to chat!");
                        lblInvalid.Hide();

                        //passes email used to login to main form so username can be pulled.
                        frmMain objFrmMain = new frmMain();
                        this.Hide();
                        objFrmMain._textBox = _textBox1;
                        objFrmMain.Show();
                    }
                    else
                    {
                        lblInvalid.Show();
                        txtUsername.Focus();
                    }//End of login validation if else chain.
                    
                }
                else
                {
                    MessageBox.Show("Please register as a user");
                    btnRegister.Focus();

                }//End of email check if else chain.
                
            }
            else
            {
                MessageBox.Show("Please enter your email and/or password");
                txtUsername.Focus();

            }//End of if else chain to check if input is blank.


        }//End of login button click event.

        //Button code to close the form if the user wants to exit.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }//End of exit button click event.

        //A method to validate what is put in by a string.
        //It checks to see if the string is empty or not.
        //If the string is empty false is returned, if the 
        //string has input then true is returned.
        private bool CheckInput(string input)
        {
            bool correctInput;

            if (input == "")
            {
                correctInput = false;
            }
            else
                correctInput = true;

            return correctInput;
        }//End of CheckInput method.

        //Button code to open the registration window/form.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister objFrmRegister = new frmRegister();
            this.Hide();
            objFrmRegister.Show();
        }//End of register button click event.

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }       
}
