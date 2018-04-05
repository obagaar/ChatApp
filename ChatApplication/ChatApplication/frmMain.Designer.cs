namespace ChatApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.azureChatDB2018DataSet = new ChatApplication.AzureChatDB2018DataSet();
            this.messagesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.chatDBDataSet = new ChatApplication.ChatDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.messagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chatDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesTableAdapter = new ChatApplication.ChatDBDataSetTableAdapters.MessagesTableAdapter();
            this.messagesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.chatDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.messagesTableAdapter1 = new ChatApplication.AzureChatDB2018DataSetTableAdapters.MessagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureChatDB2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(671, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(28, 492);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(624, 20);
            this.txtSendMsg.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(671, 490);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMessages.AutoGenerateColumns = false;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.Created,
            this.msgContentDataGridViewTextBoxColumn});
            this.dgvMessages.DataSource = this.messagesBindingSource4;
            this.dgvMessages.Location = new System.Drawing.Point(28, 25);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.Size = new System.Drawing.Size(718, 447);
            this.dgvMessages.TabIndex = 4;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Created
            // 
            this.Created.DataPropertyName = "Created";
            this.Created.HeaderText = "Created";
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            // 
            // msgContentDataGridViewTextBoxColumn
            // 
            this.msgContentDataGridViewTextBoxColumn.DataPropertyName = "MsgContent";
            this.msgContentDataGridViewTextBoxColumn.HeaderText = "MsgContent";
            this.msgContentDataGridViewTextBoxColumn.Name = "msgContentDataGridViewTextBoxColumn";
            this.msgContentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messagesBindingSource4
            // 
            this.messagesBindingSource4.DataMember = "Messages";
            this.messagesBindingSource4.DataSource = this.azureChatDB2018DataSet;
            // 
            // azureChatDB2018DataSet
            // 
            this.azureChatDB2018DataSet.DataSetName = "AzureChatDB2018DataSet";
            this.azureChatDB2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messagesBindingSource3
            // 
            this.messagesBindingSource3.DataMember = "Messages";
            this.messagesBindingSource3.DataSource = this.chatDBDataSet;
            // 
            // chatDBDataSet
            // 
            this.chatDBDataSet.DataSetName = "ChatDBDataSet";
            this.chatDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(773, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome";
            // 
            // messagesBindingSource1
            // 
            this.messagesBindingSource1.DataMember = "Messages";
            this.messagesBindingSource1.DataSource = this.chatDBDataSet;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "Messages";
            this.messagesBindingSource.DataSource = this.chatDBDataSet;
            // 
            // chatDBDataSetBindingSource
            // 
            this.chatDBDataSetBindingSource.DataSource = this.chatDBDataSet;
            this.chatDBDataSetBindingSource.Position = 0;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // messagesBindingSource2
            // 
            this.messagesBindingSource2.DataMember = "Messages";
            this.messagesBindingSource2.DataSource = this.chatDBDataSet;
            // 
            // chatDBDataSetBindingSource1
            // 
            this.chatDBDataSetBindingSource1.DataSource = this.chatDBDataSet;
            this.chatDBDataSetBindingSource1.Position = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(777, 59);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(780, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 8;
            // 
            // messagesTableAdapter1
            // 
            this.messagesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(991, 594);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureChatDB2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.BindingSource chatDBDataSetBindingSource;
        private ChatDBDataSet chatDBDataSet;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private ChatDBDataSetTableAdapters.MessagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.BindingSource messagesBindingSource1;
        private System.Windows.Forms.BindingSource messagesBindingSource2;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.BindingSource messagesBindingSource3;
        private System.Windows.Forms.BindingSource chatDBDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private AzureChatDB2018DataSet azureChatDB2018DataSet;
        private System.Windows.Forms.BindingSource messagesBindingSource4;
        private AzureChatDB2018DataSetTableAdapters.MessagesTableAdapter messagesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgContentDataGridViewTextBoxColumn;
    }
}