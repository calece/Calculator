namespace Calculator
{
    partial class MainMenu
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
            this.arg1Input = new System.Windows.Forms.MaskedTextBox();
            this.arg2Input = new System.Windows.Forms.MaskedTextBox();
            this.operatorLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.divCheckBox = new System.Windows.Forms.CheckBox();
            this.multCheckBox = new System.Windows.Forms.CheckBox();
            this.subCheckBox = new System.Windows.Forms.CheckBox();
            this.addCheckBox = new System.Windows.Forms.CheckBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.operatorLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // arg1Input
            // 
            this.arg1Input.Location = new System.Drawing.Point(12, 12);
            this.arg1Input.Name = "arg1Input";
            this.arg1Input.Size = new System.Drawing.Size(100, 20);
            this.arg1Input.TabIndex = 1;
            this.arg1Input.Enter += new System.EventHandler(this.ArgInputEntered);
            // 
            // arg2Input
            // 
            this.arg2Input.Location = new System.Drawing.Point(12, 47);
            this.arg2Input.Name = "arg2Input";
            this.arg2Input.PromptChar = ' ';
            this.arg2Input.Size = new System.Drawing.Size(100, 20);
            this.arg2Input.TabIndex = 2;
            this.arg2Input.Enter += new System.EventHandler(this.ArgInputEntered);
            // 
            // operatorLayoutPanel
            // 
            this.operatorLayoutPanel.ColumnCount = 1;
            this.operatorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operatorLayoutPanel.Controls.Add(this.divCheckBox, 0, 3);
            this.operatorLayoutPanel.Controls.Add(this.multCheckBox, 0, 2);
            this.operatorLayoutPanel.Controls.Add(this.subCheckBox, 0, 1);
            this.operatorLayoutPanel.Controls.Add(this.addCheckBox, 0, 0);
            this.operatorLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.operatorLayoutPanel.Location = new System.Drawing.Point(165, 0);
            this.operatorLayoutPanel.Name = "operatorLayoutPanel";
            this.operatorLayoutPanel.RowCount = 4;
            this.operatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorLayoutPanel.Size = new System.Drawing.Size(119, 143);
            this.operatorLayoutPanel.TabIndex = 0;
            // 
            // divCheckBox
            // 
            this.divCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divCheckBox.Location = new System.Drawing.Point(3, 108);
            this.divCheckBox.Name = "divCheckBox";
            this.divCheckBox.Size = new System.Drawing.Size(113, 32);
            this.divCheckBox.TabIndex = 3;
            this.divCheckBox.Text = "Divide";
            this.divCheckBox.UseVisualStyleBackColor = true;
            this.divCheckBox.Click += new System.EventHandler(this.OperatorSelectionChanged);
            // 
            // multCheckBox
            // 
            this.multCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multCheckBox.Location = new System.Drawing.Point(3, 73);
            this.multCheckBox.Name = "multCheckBox";
            this.multCheckBox.Size = new System.Drawing.Size(113, 29);
            this.multCheckBox.TabIndex = 2;
            this.multCheckBox.Text = "Multiply";
            this.multCheckBox.UseVisualStyleBackColor = true;
            this.multCheckBox.Click += new System.EventHandler(this.OperatorSelectionChanged);
            // 
            // subCheckBox
            // 
            this.subCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subCheckBox.Location = new System.Drawing.Point(3, 38);
            this.subCheckBox.Name = "subCheckBox";
            this.subCheckBox.Size = new System.Drawing.Size(113, 29);
            this.subCheckBox.TabIndex = 1;
            this.subCheckBox.Text = "Subtract";
            this.subCheckBox.UseVisualStyleBackColor = true;
            this.subCheckBox.Click += new System.EventHandler(this.OperatorSelectionChanged);
            // 
            // addCheckBox
            // 
            this.addCheckBox.Checked = true;
            this.addCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCheckBox.Location = new System.Drawing.Point(3, 3);
            this.addCheckBox.Name = "addCheckBox";
            this.addCheckBox.Size = new System.Drawing.Size(113, 29);
            this.addCheckBox.TabIndex = 0;
            this.addCheckBox.Text = "Add";
            this.addCheckBox.UseVisualStyleBackColor = true;
            this.addCheckBox.Click += new System.EventHandler(this.OperatorSelectionChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 80);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(16, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "= ";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 108);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.operatorLayoutPanel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.arg2Input);
            this.Controls.Add(this.arg1Input);
            this.Name = "MainMenu";
            this.Text = "Calculator";
            this.operatorLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox arg1Input;
        private System.Windows.Forms.MaskedTextBox arg2Input;
        private System.Windows.Forms.TableLayoutPanel operatorLayoutPanel;
        private System.Windows.Forms.CheckBox divCheckBox;
        private System.Windows.Forms.CheckBox multCheckBox;
        private System.Windows.Forms.CheckBox subCheckBox;
        private System.Windows.Forms.CheckBox addCheckBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

