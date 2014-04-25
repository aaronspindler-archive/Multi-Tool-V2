namespace Multi_Tool_V2
{
    partial class RandomPassword_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomPassword_Home));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.numberOfPasswordsTitle = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.numberOfPasswordsUD = new System.Windows.Forms.NumericUpDown();
            this.lengthOfPasswordsTitle = new System.Windows.Forms.Label();
            this.lengthOfPasswordsUD = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswordsUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfPasswordsUD)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameDisplay, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberOfPasswordsTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.createButton, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.outputLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numberOfPasswordsUD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lengthOfPasswordsTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lengthOfPasswordsUD, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip, 6);
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(354, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.usernameDisplay, 2);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usernameDisplay.Location = new System.Drawing.Point(357, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(115, 25);
            this.usernameDisplay.TabIndex = 1;
            this.usernameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfPasswordsTitle
            // 
            this.numberOfPasswordsTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.numberOfPasswordsTitle, 8);
            this.numberOfPasswordsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfPasswordsTitle.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPasswordsTitle.Location = new System.Drawing.Point(2, 25);
            this.numberOfPasswordsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfPasswordsTitle.Name = "numberOfPasswordsTitle";
            this.numberOfPasswordsTitle.Size = new System.Drawing.Size(471, 45);
            this.numberOfPasswordsTitle.TabIndex = 1;
            this.numberOfPasswordsTitle.Text = "Enter the number of passwords you want to output to a file";
            this.numberOfPasswordsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.createButton, 2);
            this.createButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createButton.Location = new System.Drawing.Point(179, 167);
            this.createButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(114, 41);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.outputLabel, 8);
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(2, 210);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(471, 47);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfPasswordsUD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numberOfPasswordsUD, 4);
            this.numberOfPasswordsUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfPasswordsUD.Location = new System.Drawing.Point(120, 72);
            this.numberOfPasswordsUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberOfPasswordsUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberOfPasswordsUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPasswordsUD.Name = "numberOfPasswordsUD";
            this.numberOfPasswordsUD.Size = new System.Drawing.Size(232, 20);
            this.numberOfPasswordsUD.TabIndex = 5;
            this.numberOfPasswordsUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberOfPasswordsUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPasswordsUD.ValueChanged += new System.EventHandler(this.numberOfPasswordsUD_ValueChanged);
            // 
            // lengthOfPasswordsTitle
            // 
            this.lengthOfPasswordsTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lengthOfPasswordsTitle, 8);
            this.lengthOfPasswordsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengthOfPasswordsTitle.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthOfPasswordsTitle.Location = new System.Drawing.Point(2, 95);
            this.lengthOfPasswordsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lengthOfPasswordsTitle.Name = "lengthOfPasswordsTitle";
            this.lengthOfPasswordsTitle.Size = new System.Drawing.Size(471, 45);
            this.lengthOfPasswordsTitle.TabIndex = 6;
            this.lengthOfPasswordsTitle.Text = "Enter the length of the passwords you want";
            this.lengthOfPasswordsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthOfPasswordsUD
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lengthOfPasswordsUD, 4);
            this.lengthOfPasswordsUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lengthOfPasswordsUD.Location = new System.Drawing.Point(120, 142);
            this.lengthOfPasswordsUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lengthOfPasswordsUD.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.lengthOfPasswordsUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthOfPasswordsUD.Name = "lengthOfPasswordsUD";
            this.lengthOfPasswordsUD.Size = new System.Drawing.Size(232, 20);
            this.lengthOfPasswordsUD.TabIndex = 7;
            this.lengthOfPasswordsUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthOfPasswordsUD.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.lengthOfPasswordsUD.ValueChanged += new System.EventHandler(this.lengthOfPasswordsUD_ValueChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // RandomPassword_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "RandomPassword_Home";
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.randomPassword_Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswordsUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfPasswordsUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.Label numberOfPasswordsTitle;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown numberOfPasswordsUD;
        private System.Windows.Forms.Label lengthOfPasswordsTitle;
        private System.Windows.Forms.NumericUpDown lengthOfPasswordsUD;
    }
}