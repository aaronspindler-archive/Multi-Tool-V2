namespace Multi_Tool_V2
{
    partial class singleStringEncrypter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleStringEncrypter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.encryptTextButton = new System.Windows.Forms.Button();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionKeyLabel = new System.Windows.Forms.Label();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.encryptedTextOutput = new System.Windows.Forms.TextBox();
            this.plainTextInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.keyInput, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.encryptTextButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.usernameDisplay, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.encryptionKeyLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.plainTextLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.encryptedTextOutput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.plainTextInput, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // keyInput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.keyInput, 3);
            this.keyInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyInput.Location = new System.Drawing.Point(475, 51);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(348, 31);
            this.keyInput.TabIndex = 1;
            this.keyInput.TextChanged += new System.EventHandler(this.keyInput_TextChanged);
            // 
            // encryptTextButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.encryptTextButton, 4);
            this.encryptTextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptTextButton.Location = new System.Drawing.Point(239, 147);
            this.encryptTextButton.Name = "encryptTextButton";
            this.encryptTextButton.Size = new System.Drawing.Size(466, 90);
            this.encryptTextButton.TabIndex = 1;
            this.encryptTextButton.Text = "Encrypt Text";
            this.encryptTextButton.UseVisualStyleBackColor = true;
            this.encryptTextButton.Click += new System.EventHandler(this.encryptTextBuutton_Click);
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameDisplay, 3);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usernameDisplay.Location = new System.Drawing.Point(593, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(353, 48);
            this.usernameDisplay.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 5);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 44);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // encryptionKeyLabel
            // 
            this.encryptionKeyLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.encryptionKeyLabel, 3);
            this.encryptionKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptionKeyLabel.Location = new System.Drawing.Point(121, 48);
            this.encryptionKeyLabel.Name = "encryptionKeyLabel";
            this.encryptionKeyLabel.Size = new System.Drawing.Size(348, 48);
            this.encryptionKeyLabel.TabIndex = 2;
            this.encryptionKeyLabel.Text = "Enter a password";
            this.encryptionKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.plainTextLabel, 3);
            this.plainTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainTextLabel.Location = new System.Drawing.Point(121, 96);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(348, 48);
            this.plainTextLabel.TabIndex = 3;
            this.plainTextLabel.Text = "Enter String to Encrypt";
            this.plainTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // encryptedTextOutput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.encryptedTextOutput, 6);
            this.encryptedTextOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptedTextOutput.Location = new System.Drawing.Point(121, 243);
            this.encryptedTextOutput.Name = "encryptedTextOutput";
            this.encryptedTextOutput.ReadOnly = true;
            this.encryptedTextOutput.Size = new System.Drawing.Size(702, 31);
            this.encryptedTextOutput.TabIndex = 4;
            this.encryptedTextOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.encryptedTextOutput_MouseClick);
            // 
            // plainTextInput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.plainTextInput, 3);
            this.plainTextInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainTextInput.Location = new System.Drawing.Point(475, 99);
            this.plainTextInput.Name = "plainTextInput";
            this.plainTextInput.Size = new System.Drawing.Size(348, 31);
            this.plainTextInput.TabIndex = 5;
            this.plainTextInput.TextChanged += new System.EventHandler(this.plainTextInput_TextChanged);
            // 
            // singleStringEncrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "singleStringEncrypter";
            this.Text = "Single String Encrypter";
            this.Load += new System.EventHandler(this.singleStringEncrypter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Button encryptTextButton;
        private System.Windows.Forms.Label encryptionKeyLabel;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.TextBox encryptedTextOutput;
        private System.Windows.Forms.TextBox plainTextInput;
    }
}