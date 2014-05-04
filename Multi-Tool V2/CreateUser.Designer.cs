namespace Multi_Tool_V2
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.passwordVerifyEntry = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.verifyPasswordLabel = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.instructionsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameEntry, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordEntry, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordVerifyEntry, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.verifyPasswordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.createUserButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 215);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.instructionsLabel, 4);
            this.instructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionsLabel.Location = new System.Drawing.Point(4, 0);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(570, 43);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Use this window to create new users.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameLabel, 2);
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Location = new System.Drawing.Point(4, 43);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(280, 43);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Enter a Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameEntry
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.usernameEntry, 2);
            this.usernameEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameEntry.Location = new System.Drawing.Point(292, 47);
            this.usernameEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(282, 31);
            this.usernameEntry.TabIndex = 2;
            this.usernameEntry.TextChanged += new System.EventHandler(this.usernameEntry_TextChanged);
            // 
            // passwordEntry
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.passwordEntry, 2);
            this.passwordEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordEntry.Location = new System.Drawing.Point(292, 90);
            this.passwordEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.Size = new System.Drawing.Size(282, 31);
            this.passwordEntry.TabIndex = 3;
            this.passwordEntry.TextChanged += new System.EventHandler(this.passwordEntry_TextChanged);
            // 
            // passwordVerifyEntry
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.passwordVerifyEntry, 2);
            this.passwordVerifyEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordVerifyEntry.Location = new System.Drawing.Point(292, 133);
            this.passwordVerifyEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordVerifyEntry.Name = "passwordVerifyEntry";
            this.passwordVerifyEntry.Size = new System.Drawing.Size(282, 31);
            this.passwordVerifyEntry.TabIndex = 4;
            this.passwordVerifyEntry.TextChanged += new System.EventHandler(this.passwordVerifyEntry_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.passwordLabel, 2);
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Location = new System.Drawing.Point(4, 86);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(280, 43);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Enter your password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verifyPasswordLabel
            // 
            this.verifyPasswordLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.verifyPasswordLabel, 2);
            this.verifyPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verifyPasswordLabel.Location = new System.Drawing.Point(4, 129);
            this.verifyPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verifyPasswordLabel.Name = "verifyPasswordLabel";
            this.verifyPasswordLabel.Size = new System.Drawing.Size(280, 43);
            this.verifyPasswordLabel.TabIndex = 6;
            this.verifyPasswordLabel.Text = "Verify your password";
            this.verifyPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createUserButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.createUserButton, 2);
            this.createUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createUserButton.Location = new System.Drawing.Point(148, 176);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(280, 35);
            this.createUserButton.TabIndex = 7;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 215);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateUser";
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.TextBox passwordVerifyEntry;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label verifyPasswordLabel;
        private System.Windows.Forms.Button createUserButton;
    }
}