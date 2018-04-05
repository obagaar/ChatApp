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
using System.Net.Mail;
using System.Net;

namespace ChatApplication
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //When clicked the registration form is hidden and the main login is shown.
        private void Exit_Click(object sender, EventArgs e)
        {
            frmLogin objFrmLogin = new frmLogin();
            this.Close();
            objFrmLogin.Show();

        }//End of exit button click event.

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Sets the password text box so it masks what is typed in as an asterik.
            //Also limits length to 64 characters.
            txtRegPass.PasswordChar = '*';
            txtRegPass.MaxLength = 64;

            //the textboxes the user enters their email and password set to strings.
            string email = txtRegEmail.Text.Trim(),
                   password = txtRegPass.Text.Trim(),
                   username = txtRegUsername.Text.Trim();

            
            //A list for a parameter for an email to be used in a stored procedure.
            List<SqlParameter> sqlEmailParam = new List<SqlParameter>();
            sqlEmailParam.Add(new SqlParameter("@email", email));

            //Data table that is generated from the DAL class using a stored procedure 
            //to search for an email in the database.
            DataTable dtRegister = DAL.ExecStoredProcedure("SearchEmail", sqlEmailParam);

            //An if else chain to check if there is any blank input in the strings being used.
            if (CheckInput(email) == true && CheckInput(password) == true)
            {
                //An if else chain to check if the email entered has already been registered.
                if (dtRegister != null && dtRegister.Rows.Count == 1 || dtRegister.Rows.Count > 1)
                {
                    MessageBox.Show("Email address is in use. Please sign in or use a new email.");
                    txtRegEmail.Focus();
                }
                else
                {
                    //A list of paramters stored to be used to send the new email and 
                    //password being registered.
                    List<SqlParameter> sqlRegParam = new List<SqlParameter>();
                    sqlRegParam.Add(new SqlParameter("@Email", email));
                    sqlRegParam.Add(new SqlParameter("@Password", password));
                    sqlRegParam.Add(new SqlParameter("@Username", username));

                    //The stored procedure to send the email and password to the database and 
                    //add it as a new row using the DAL class.
                    DAL.ExecStoredProcedure("Registration", sqlRegParam);

                    //An if else chain to confirm the registration was completed.
                    if (dtRegister != null)
                    {
                        SendRegEmail();

                    }
                    else
                    {
                        MessageBox.Show("Please try registering again.");
                    }//End of if else chain to check that registration was completed.
                }//End of if else chain to check if the email entered has already been entered.
            }
            else
            {
                MessageBox.Show("Please enter your email and/or password");
                txtRegEmail.Focus();
            }//End of if else chain to check in any input was blank.
        }

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

        //Method to send an email once registration is complete
        private void SendRegEmail()
        {
            //variables to store the email registered and also the email used to send the email
            string email = txtRegEmail.Text.Trim(),
                   myemail = "chatdb2018@outlook.com";

            MailMessage registration = new MailMessage();
            registration.From = new MailAddress(myemail);
            registration.To.Add(new MailAddress(email));
            //Below code is for the email subject and body
            registration.Subject = "Registration Confirmation";
            registration.Body = "Dear New User,<br><br> Welcome to chat! <br>Thanks for Registering!<br><br> Ashley";
            //The client and port used to send the email based on the email server
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            registration.IsBodyHtml = true;

            //Credentials for sending the email on the account used.
            NetworkCredential Credentials = new NetworkCredential(myemail, "Turkeytime7");
            smtp.Credentials = Credentials;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            smtp.Send(registration);

            //Confirmation message displayed top user to confirm registration is complete.
            MessageBox.Show("Registration Complete! An email is on it's way to confirm.");

        }
    }
}
