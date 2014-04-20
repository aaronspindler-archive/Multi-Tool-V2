namespace Multi_Tool_V2
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.convertButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueTitle = new System.Windows.Forms.Label();
            this.convertedValueTitle = new System.Windows.Forms.Label();
            this.convertedValueDisplay = new System.Windows.Forms.Label();
            this.conversionType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.convertButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.valueTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.convertedValueTitle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.convertedValueDisplay, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.conversionType, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // convertButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.convertButton, 4);
            this.convertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertButton.Location = new System.Drawing.Point(135, 100);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(516, 40);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // valueTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.valueTextBox, 3);
            this.valueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTextBox.Location = new System.Drawing.Point(397, 52);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(389, 31);
            this.valueTextBox.TabIndex = 6;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // valueTitle
            // 
            this.valueTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.valueTitle, 3);
            this.valueTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTitle.Location = new System.Drawing.Point(4, 48);
            this.valueTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueTitle.Name = "valueTitle";
            this.valueTitle.Size = new System.Drawing.Size(385, 48);
            this.valueTitle.TabIndex = 7;
            this.valueTitle.Text = "Enter the amount to convert";
            this.valueTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // convertedValueTitle
            // 
            this.convertedValueTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.convertedValueTitle, 4);
            this.convertedValueTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertedValueTitle.Location = new System.Drawing.Point(135, 144);
            this.convertedValueTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.convertedValueTitle.Name = "convertedValueTitle";
            this.convertedValueTitle.Size = new System.Drawing.Size(516, 48);
            this.convertedValueTitle.TabIndex = 8;
            this.convertedValueTitle.Text = "Converted Value";
            this.convertedValueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertedValueDisplay
            // 
            this.convertedValueDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.convertedValueDisplay, 4);
            this.convertedValueDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertedValueDisplay.Location = new System.Drawing.Point(135, 192);
            this.convertedValueDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.convertedValueDisplay.Name = "convertedValueDisplay";
            this.convertedValueDisplay.Size = new System.Drawing.Size(516, 48);
            this.convertedValueDisplay.TabIndex = 9;
            this.convertedValueDisplay.Text = "0";
            this.convertedValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conversionType
            // 
            this.conversionType.AutoCompleteCustomSource.AddRange(new string[] {
            "Km/h to Mp/h",
            "Mp/h to Km/h",
            "Centimeters to Inches",
            "Inches to Centimeters",
            "Kilometers to Miles",
            "Miles to Kilometers",
            "Litres to Gallons",
            "Gallons to Litres",
            "Days to Seconds",
            "Hours to Seconds"});
            this.conversionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.conversionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.conversionType, 4);
            this.conversionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conversionType.FormattingEnabled = true;
            this.conversionType.Items.AddRange(new object[] {
            "Km/h to Mp/h",
            "Mp/h to Km/h",
            "Centimeters to Inches",
            "Inches to Centimeters",
            "Kilometers to Miles",
            "Miles to Kilometers",
            "Litres to Gallons",
            "Gallons to Litres",
            "Days to Seconds",
            "Hours to Seconds"});
            this.conversionType.Location = new System.Drawing.Point(135, 4);
            this.conversionType.Margin = new System.Windows.Forms.Padding(4);
            this.conversionType.Name = "conversionType";
            this.conversionType.Size = new System.Drawing.Size(516, 33);
            this.conversionType.TabIndex = 10;
            this.conversionType.Text = "Please select a conversion type";
            this.conversionType.SelectedIndexChanged += new System.EventHandler(this.conversionType_SelectedIndexChanged);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 235);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Converter";
            this.Text = "Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label valueTitle;
        private System.Windows.Forms.Label convertedValueTitle;
        private System.Windows.Forms.Label convertedValueDisplay;
        private System.Windows.Forms.ComboBox conversionType;
    }
}