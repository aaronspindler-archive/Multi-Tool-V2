namespace Multi_Tool_V2
{
    partial class randomPassword_Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randomPassword_Options));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.normalPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.numberPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCharCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.normalPasswordCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numberPasswordCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.specialCharCheckBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1041, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // normalPasswordCheckBox
            // 
            this.normalPasswordCheckBox.AutoSize = true;
            this.normalPasswordCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalPasswordCheckBox.Location = new System.Drawing.Point(3, 3);
            this.normalPasswordCheckBox.Name = "normalPasswordCheckBox";
            this.normalPasswordCheckBox.Size = new System.Drawing.Size(1035, 81);
            this.normalPasswordCheckBox.TabIndex = 1;
            this.normalPasswordCheckBox.Text = "Least Secure - Passwords that include uppercase and lowercase letters";
            this.normalPasswordCheckBox.UseVisualStyleBackColor = true;
            this.normalPasswordCheckBox.CheckedChanged += new System.EventHandler(this.normalPasswordCheckBox_CheckedChanged);
            // 
            // numberPasswordCheckBox
            // 
            this.numberPasswordCheckBox.AutoSize = true;
            this.numberPasswordCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberPasswordCheckBox.Location = new System.Drawing.Point(3, 90);
            this.numberPasswordCheckBox.Name = "numberPasswordCheckBox";
            this.numberPasswordCheckBox.Size = new System.Drawing.Size(1035, 81);
            this.numberPasswordCheckBox.TabIndex = 2;
            this.numberPasswordCheckBox.Text = "Secure - Passwords that include upper case, lower case letters, and numbers";
            this.numberPasswordCheckBox.UseVisualStyleBackColor = true;
            this.numberPasswordCheckBox.CheckedChanged += new System.EventHandler(this.numberPasswordCheckBox_CheckedChanged);
            // 
            // specialCharCheckBox
            // 
            this.specialCharCheckBox.AutoSize = true;
            this.specialCharCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialCharCheckBox.Location = new System.Drawing.Point(3, 177);
            this.specialCharCheckBox.Name = "specialCharCheckBox";
            this.specialCharCheckBox.Size = new System.Drawing.Size(1035, 83);
            this.specialCharCheckBox.TabIndex = 3;
            this.specialCharCheckBox.Text = "Most Secure - Passwords that include uppercase, lowercase letters, numbers, and s" +
    "pecial characters";
            this.specialCharCheckBox.UseVisualStyleBackColor = true;
            this.specialCharCheckBox.CheckedChanged += new System.EventHandler(this.specialCharCheckBox_CheckedChanged);
            // 
            // randomPassword_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 263);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "randomPassword_Options";
            this.Text = "Random Password Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.randomPassword_Options_FormClosing);
            this.Load += new System.EventHandler(this.randomPassword_Options_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox numberPasswordCheckBox;
        private System.Windows.Forms.CheckBox specialCharCheckBox;
        private System.Windows.Forms.CheckBox normalPasswordCheckBox;
    }
}