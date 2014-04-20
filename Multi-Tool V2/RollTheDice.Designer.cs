namespace Multi_Tool_V2
{
    partial class RollTheDice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollTheDice));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rolledNumberLabel = new System.Windows.Forms.Label();
            this.numberOfSidesOnDice = new System.Windows.Forms.NumericUpDown();
            this.numberOfSidesOnDiceLabel = new System.Windows.Forms.Label();
            this.getRandomSide = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSidesOnDice)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.rolledNumberLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberOfSidesOnDice, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberOfSidesOnDiceLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.getRandomSide, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rolledNumberLabel
            // 
            this.rolledNumberLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rolledNumberLabel, 2);
            this.rolledNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolledNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolledNumberLabel.Location = new System.Drawing.Point(176, 119);
            this.rolledNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rolledNumberLabel.Name = "rolledNumberLabel";
            this.tableLayoutPanel1.SetRowSpan(this.rolledNumberLabel, 2);
            this.rolledNumberLabel.Size = new System.Drawing.Size(112, 95);
            this.rolledNumberLabel.TabIndex = 1;
            this.rolledNumberLabel.Text = "1";
            this.rolledNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfSidesOnDice
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numberOfSidesOnDice, 4);
            this.numberOfSidesOnDice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfSidesOnDice.Location = new System.Drawing.Point(118, 49);
            this.numberOfSidesOnDice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberOfSidesOnDice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberOfSidesOnDice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfSidesOnDice.Name = "numberOfSidesOnDice";
            this.numberOfSidesOnDice.Size = new System.Drawing.Size(228, 20);
            this.numberOfSidesOnDice.TabIndex = 1;
            this.numberOfSidesOnDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfSidesOnDice.ValueChanged += new System.EventHandler(this.numberOfSidesOnDice_ValueChanged);
            // 
            // numberOfSidesOnDiceLabel
            // 
            this.numberOfSidesOnDiceLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.numberOfSidesOnDiceLabel, 8);
            this.numberOfSidesOnDiceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfSidesOnDiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfSidesOnDiceLabel.Location = new System.Drawing.Point(2, 0);
            this.numberOfSidesOnDiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfSidesOnDiceLabel.Name = "numberOfSidesOnDiceLabel";
            this.numberOfSidesOnDiceLabel.Size = new System.Drawing.Size(463, 47);
            this.numberOfSidesOnDiceLabel.TabIndex = 2;
            this.numberOfSidesOnDiceLabel.Text = "Enter how many sides you want on the dice";
            this.numberOfSidesOnDiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getRandomSide
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.getRandomSide, 4);
            this.getRandomSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getRandomSide.Location = new System.Drawing.Point(118, 74);
            this.getRandomSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getRandomSide.Name = "getRandomSide";
            this.getRandomSide.Size = new System.Drawing.Size(228, 43);
            this.getRandomSide.TabIndex = 3;
            this.getRandomSide.Text = "Roll The Dice";
            this.getRandomSide.UseVisualStyleBackColor = true;
            this.getRandomSide.Click += new System.EventHandler(this.getRandomSide_Click);
            // 
            // RollTheDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 214);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RollTheDice";
            this.Text = "Roll The Dice";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSidesOnDice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label rolledNumberLabel;
        private System.Windows.Forms.NumericUpDown numberOfSidesOnDice;
        private System.Windows.Forms.Label numberOfSidesOnDiceLabel;
        private System.Windows.Forms.Button getRandomSide;
    }
}