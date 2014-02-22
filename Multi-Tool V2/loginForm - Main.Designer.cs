namespace Multi_Tool_V2
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTitleLabel = new System.Windows.Forms.Label();
            this.passwordTitleLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.createUserTitleLabel = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loginTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTableLayout
            // 
            this.loginTableLayout.ColumnCount = 4;
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.Controls.Add(this.usernameTextBox, 2, 0);
            this.loginTableLayout.Controls.Add(this.usernameTitleLabel, 0, 0);
            this.loginTableLayout.Controls.Add(this.passwordTitleLabel, 0, 1);
            this.loginTableLayout.Controls.Add(this.passwordTextBox, 2, 1);
            this.loginTableLayout.Controls.Add(this.loginButton, 0, 2);
            this.loginTableLayout.Controls.Add(this.createUserTitleLabel, 0, 3);
            this.loginTableLayout.Controls.Add(this.createUserButton, 2, 3);
            this.loginTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginTableLayout.Location = new System.Drawing.Point(0, 0);
            this.loginTableLayout.Name = "loginTableLayout";
            this.loginTableLayout.RowCount = 4;
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.loginTableLayout.Size = new System.Drawing.Size(290, 118);
            this.loginTableLayout.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.loginTableLayout.SetColumnSpan(this.usernameTextBox, 2);
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Location = new System.Drawing.Point(147, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(140, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // usernameTitleLabel
            // 
            this.usernameTitleLabel.AutoSize = true;
            this.loginTableLayout.SetColumnSpan(this.usernameTitleLabel, 2);
            this.usernameTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameTitleLabel.Name = "usernameTitleLabel";
            this.usernameTitleLabel.Size = new System.Drawing.Size(138, 29);
            this.usernameTitleLabel.TabIndex = 0;
            this.usernameTitleLabel.Text = "Enter a username";
            this.usernameTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTitleLabel
            // 
            this.passwordTitleLabel.AutoSize = true;
            this.loginTableLayout.SetColumnSpan(this.passwordTitleLabel, 2);
            this.passwordTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTitleLabel.Location = new System.Drawing.Point(3, 29);
            this.passwordTitleLabel.Name = "passwordTitleLabel";
            this.passwordTitleLabel.Size = new System.Drawing.Size(138, 29);
            this.passwordTitleLabel.TabIndex = 1;
            this.passwordTitleLabel.Text = "Enter a password";
            this.passwordTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.loginTableLayout.SetColumnSpan(this.passwordTextBox, 2);
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.Location = new System.Drawing.Point(147, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(140, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginTableLayout.SetColumnSpan(this.loginButton, 4);
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Location = new System.Drawing.Point(3, 61);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(284, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createUserTitleLabel
            // 
            this.createUserTitleLabel.AutoSize = true;
            this.loginTableLayout.SetColumnSpan(this.createUserTitleLabel, 2);
            this.createUserTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createUserTitleLabel.Location = new System.Drawing.Point(3, 87);
            this.createUserTitleLabel.Name = "createUserTitleLabel";
            this.createUserTitleLabel.Size = new System.Drawing.Size(138, 31);
            this.createUserTitleLabel.TabIndex = 4;
            this.createUserTitleLabel.Text = "Need to create a user?";
            this.createUserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createUserButton
            // 
            this.loginTableLayout.SetColumnSpan(this.createUserButton, 2);
            this.createUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createUserButton.Location = new System.Drawing.Point(147, 90);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(140, 25);
            this.createUserButton.TabIndex = 5;
            this.createUserButton.Text = "Create a User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 118);
            this.Controls.Add(this.loginTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.loginTableLayout.ResumeLayout(false);
            this.loginTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loginTableLayout;
        private System.Windows.Forms.Label usernameTitleLabel;
        private System.Windows.Forms.Label passwordTitleLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label createUserTitleLabel;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

