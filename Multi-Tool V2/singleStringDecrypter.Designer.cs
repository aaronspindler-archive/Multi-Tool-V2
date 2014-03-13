namespace Multi_Tool_V2
{
    partial class singleStringDecrypter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleStringDecrypter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.keyTitle = new System.Windows.Forms.Label();
            this.encryptedTextTitle = new System.Windows.Forms.Label();
            this.decryptedTextButton = new System.Windows.Forms.Button();
            this.decryptedTextField = new System.Windows.Forms.TextBox();
            this.decryptedTextTitle = new System.Windows.Forms.Label();
            this.decryptionKeyField = new System.Windows.Forms.TextBox();
            this.encryptedTextField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.keyTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.encryptedTextTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.decryptedTextButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.decryptedTextField, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.decryptedTextTitle, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.decryptionKeyField, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.encryptedTextField, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // keyTitle
            // 
            this.keyTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.keyTitle, 3);
            this.keyTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyTitle.Location = new System.Drawing.Point(118, 60);
            this.keyTitle.Name = "keyTitle";
            this.keyTitle.Size = new System.Drawing.Size(339, 60);
            this.keyTitle.TabIndex = 1;
            this.keyTitle.Text = "Please enter your decryption key";
            // 
            // encryptedTextTitle
            // 
            this.encryptedTextTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.encryptedTextTitle, 3);
            this.encryptedTextTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptedTextTitle.Location = new System.Drawing.Point(118, 120);
            this.encryptedTextTitle.Name = "encryptedTextTitle";
            this.encryptedTextTitle.Size = new System.Drawing.Size(339, 60);
            this.encryptedTextTitle.TabIndex = 2;
            this.encryptedTextTitle.Text = "Please enter your encrypted text";
            // 
            // decryptedTextButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.decryptedTextButton, 4);
            this.decryptedTextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptedTextButton.Location = new System.Drawing.Point(233, 183);
            this.decryptedTextButton.Name = "decryptedTextButton";
            this.decryptedTextButton.Size = new System.Drawing.Size(454, 54);
            this.decryptedTextButton.TabIndex = 3;
            this.decryptedTextButton.Text = "Decrypted Text";
            this.decryptedTextButton.UseVisualStyleBackColor = true;
            this.decryptedTextButton.Click += new System.EventHandler(this.decryptedTextButton_Click);
            // 
            // decryptedTextField
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.decryptedTextField, 4);
            this.decryptedTextField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptedTextField.Location = new System.Drawing.Point(463, 303);
            this.decryptedTextField.Name = "decryptedTextField";
            this.decryptedTextField.ReadOnly = true;
            this.decryptedTextField.Size = new System.Drawing.Size(455, 31);
            this.decryptedTextField.TabIndex = 4;
            // 
            // decryptedTextTitle
            // 
            this.decryptedTextTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.decryptedTextTitle, 4);
            this.decryptedTextTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptedTextTitle.Location = new System.Drawing.Point(3, 300);
            this.decryptedTextTitle.Name = "decryptedTextTitle";
            this.decryptedTextTitle.Size = new System.Drawing.Size(454, 60);
            this.decryptedTextTitle.TabIndex = 5;
            this.decryptedTextTitle.Text = "Click on text to copy to clipboard";
            this.decryptedTextTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // decryptionKeyField
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.decryptionKeyField, 3);
            this.decryptionKeyField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptionKeyField.Location = new System.Drawing.Point(463, 63);
            this.decryptionKeyField.Name = "decryptionKeyField";
            this.decryptionKeyField.Size = new System.Drawing.Size(339, 31);
            this.decryptionKeyField.TabIndex = 6;
            this.decryptionKeyField.TextChanged += new System.EventHandler(this.decryptionKeyField_TextChanged);
            // 
            // encryptedTextField
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.encryptedTextField, 3);
            this.encryptedTextField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptedTextField.Location = new System.Drawing.Point(463, 123);
            this.encryptedTextField.Name = "encryptedTextField";
            this.encryptedTextField.Size = new System.Drawing.Size(339, 31);
            this.encryptedTextField.TabIndex = 7;
            this.encryptedTextField.TextChanged += new System.EventHandler(this.encryptedTextField_TextChanged);
            // 
            // singleStringDecrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "singleStringDecrypter";
            this.Text = "Single String Decrypter";
            this.Load += new System.EventHandler(this.singleStringDecrypter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label keyTitle;
        private System.Windows.Forms.Label encryptedTextTitle;
        private System.Windows.Forms.Button decryptedTextButton;
        private System.Windows.Forms.TextBox decryptedTextField;
        private System.Windows.Forms.Label decryptedTextTitle;
        private System.Windows.Forms.TextBox decryptionKeyField;
        private System.Windows.Forms.TextBox encryptedTextField;
    }
}