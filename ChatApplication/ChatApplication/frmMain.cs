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
    public partial class frmMain : Form
    {
        Timer _RefreshFormTimer = new Timer();

        public frmMain()
        {
            InitializeComponent();

            //A timer to refresh the screen so new messages can be shown for the user
            _RefreshFormTimer.Interval = 1000 * 5; //5 seconds.
            _RefreshFormTimer.Tick += new EventHandler(RefreshFormTimer_Tick);
            _RefreshFormTimer.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'azureChatDB2018DataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter1.Fill(this.azureChatDB2018DataSet.Messages);
            LoadMessages();
            lblEmail.Hide();

            string email = lblEmail.Text;

            List<SqlParameter> sqlUserParams = new List<SqlParameter>();

            sqlUserParams.Add(new SqlParameter("@Email", email));

            //email used by the user when logged in is used in a stored procedure to then 
            //display their username in the welcome and in chat.
            DataTable dtUsername = DAL.ExecStoredProcedure("GetUsername", sqlUserParams);

            if (dtUsername != null)
            {
                string username = dtUsername.Rows[0].ItemArray[0].ToString();

                lblUsername.Text = username;
            }
            else
            {
                lblUsername.Text = " ";
            }
            
        }

        //Passes a value to the email label on the form.
        public string _textBox
        {
            set { lblEmail.Text = value; }
        }

        //Specific method to just load messages to the form using the stored procedure to do so.
        private void LoadMessages()
        {
            //Method to return datatable from stored procedure
            DataTable dtMessages = DAL.ExecStoredProcedure("LoadMessages");

            //Checks if datatable has data that can be displayed
            if (dtMessages != null)
            {

                this.dgvMessages.DataSource = dtMessages;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes form and application
            this.Close();
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string messageContent = txtSendMsg.Text,
                   //Below variable pulls the machine name to be sent as a parameter with the stored procedure.
                   deviceID = Environment.MachineName.ToString(),
                   username = lblUsername.Text.Trim(),
                   created = DateTime.UtcNow.ToString();
            
            List<SqlParameter> sqlMsgParams = new List<SqlParameter>();
            //Variables from the form added to the message paramters so they can be used in the stored procedure.
            sqlMsgParams.Add(new SqlParameter("@DeviceID", deviceID));
            sqlMsgParams.Add(new SqlParameter("@Username", username));
            sqlMsgParams.Add(new SqlParameter("@Content", messageContent));
            sqlMsgParams.Add(new SqlParameter("@Created", created));

            //This procedure uses the variables added to the previous list to send to the database to add the user's message
            DataTable dtSend = DAL.ExecStoredProcedure("AddMsg", sqlMsgParams);

            txtSendMsg.Clear();

        }

        //The method used in the timer on form load.
        private void RefreshFormTimer_Tick(object sender, EventArgs e)
        {
            //Method earlier declared just ot load messages in the form.
            LoadMessages();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
