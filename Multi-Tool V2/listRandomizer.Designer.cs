namespace Multi_Tool_V2
{
    partial class ListRandomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRandomizer));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.enterListItemLabel = new System.Windows.Forms.Label();
            this.itemInput = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameDisplay = new System.Windows.Forms.Label();
            this.numberOfItemsLabel = new System.Windows.Forms.Label();
            this.numberOfItemsDisplay = new System.Windows.Forms.Label();
            this.randomizeAndPrintButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 8;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Controls.Add(this.enterListItemLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.itemInput, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.addItemButton, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.usernameDisplay, 6, 0);
            this.tableLayoutPanel.Controls.Add(this.numberOfItemsLabel, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.numberOfItemsDisplay, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.randomizeAndPrintButton, 2, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(446, 260);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // enterListItemLabel
            // 
            this.enterListItemLabel.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.enterListItemLabel, 3);
            this.enterListItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterListItemLabel.Location = new System.Drawing.Point(57, 32);
            this.enterListItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterListItemLabel.Name = "enterListItemLabel";
            this.enterListItemLabel.Size = new System.Drawing.Size(161, 32);
            this.enterListItemLabel.TabIndex = 0;
            this.enterListItemLabel.Text = "Enter your list items here";
            // 
            // itemInput
            // 
            this.tableLayoutPanel.SetColumnSpan(this.itemInput, 3);
            this.itemInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemInput.Location = new System.Drawing.Point(222, 34);
            this.itemInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemInput.Name = "itemInput";
            this.itemInput.Size = new System.Drawing.Size(161, 20);
            this.itemInput.TabIndex = 1;
            this.itemInput.TextChanged += new System.EventHandler(this.itemInput_TextChanged);
            // 
            // addItemButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.addItemButton, 4);
            this.addItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemButton.Location = new System.Drawing.Point(112, 66);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(216, 28);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // menuStrip
            // 
            this.tableLayoutPanel.SetColumnSpan(this.menuStrip, 6);
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(330, 32);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usernameDisplay
            // 
            this.usernameDisplay.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.usernameDisplay, 2);
            this.usernameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameDisplay.Location = new System.Drawing.Point(332, 0);
            this.usernameDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameDisplay.Name = "usernameDisplay";
            this.usernameDisplay.Size = new System.Drawing.Size(112, 32);
            this.usernameDisplay.TabIndex = 4;
            // 
            // numberOfItemsLabel
            // 
            this.numberOfItemsLabel.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.numberOfItemsLabel, 4);
            this.numberOfItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfItemsLabel.Location = new System.Drawing.Point(112, 96);
            this.numberOfItemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfItemsLabel.Name = "numberOfItemsLabel";
            this.numberOfItemsLabel.Size = new System.Drawing.Size(216, 32);
            this.numberOfItemsLabel.TabIndex = 5;
            this.numberOfItemsLabel.Text = "Number of Items in list:";
            this.numberOfItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfItemsDisplay
            // 
            this.numberOfItemsDisplay.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.numberOfItemsDisplay, 2);
            this.numberOfItemsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfItemsDisplay.Location = new System.Drawing.Point(167, 128);
            this.numberOfItemsDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfItemsDisplay.Name = "numberOfItemsDisplay";
            this.numberOfItemsDisplay.Size = new System.Drawing.Size(106, 32);
            this.numberOfItemsDisplay.TabIndex = 6;
            this.numberOfItemsDisplay.Text = "0";
            this.numberOfItemsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomizeAndPrintButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.randomizeAndPrintButton, 4);
            this.randomizeAndPrintButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randomizeAndPrintButton.Location = new System.Drawing.Point(112, 194);
            this.randomizeAndPrintButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomizeAndPrintButton.Name = "randomizeAndPrintButton";
            this.randomizeAndPrintButton.Size = new System.Drawing.Size(216, 28);
            this.randomizeAndPrintButton.TabIndex = 7;
            this.randomizeAndPrintButton.Text = "Randomize and Print Out";
            this.randomizeAndPrintButton.UseVisualStyleBackColor = true;
            this.randomizeAndPrintButton.Click += new System.EventHandler(this.randomizeAndPrintButton_Click);
            // 
            // ListRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 260);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListRandomizer";
            this.Text = "List Randomizer";
            this.Load += new System.EventHandler(this.listRandomizer_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label enterListItemLabel;
        private System.Windows.Forms.TextBox itemInput;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label usernameDisplay;
        private System.Windows.Forms.Label numberOfItemsLabel;
        private System.Windows.Forms.Label numberOfItemsDisplay;
        private System.Windows.Forms.Button randomizeAndPrintButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}