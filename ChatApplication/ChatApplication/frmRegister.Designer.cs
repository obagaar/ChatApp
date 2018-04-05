namespace ChatApplication
{
    partial class frmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(73, 79);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(177, 20);
            this.txtRegEmail.TabIndex = 0;
            // 
            // txtRegPass
            // 
            this.txtRegPass.Location = new System.Drawing.Point(73, 111);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.PasswordChar = '*';
            this.txtRegPass.Size = new System.Drawing.Size(177, 20);
            this.txtRegPass.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(45, 182);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(168, 181);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username:";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(73, 141);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(177, 20);
            this.txtRegUsername.TabIndex = 2;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 223);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegPass);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegUsername;
    }
}