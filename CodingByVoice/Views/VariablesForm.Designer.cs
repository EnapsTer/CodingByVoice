namespace CodingByVoice.Views
{
    partial class VariablesForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newVariableLabel = new System.Windows.Forms.Label();
            this.variableTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.CurrentVarLabel = new System.Windows.Forms.Label();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.variableListBox = new System.Windows.Forms.ListBox();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Black;
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 25);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(472, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 15);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.groupBox);
            this.mainPanel.Controls.Add(this.variableListBox);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 300);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newVariableLabel);
            this.groupBox1.Controls.Add(this.variableTextBox);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Location = new System.Drawing.Point(269, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // newVariableLabel
            // 
            this.newVariableLabel.AutoSize = true;
            this.newVariableLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newVariableLabel.Location = new System.Drawing.Point(61, 22);
            this.newVariableLabel.Name = "newVariableLabel";
            this.newVariableLabel.Size = new System.Drawing.Size(102, 14);
            this.newVariableLabel.TabIndex = 4;
            this.newVariableLabel.Text = "Add new variable";
            // 
            // variableTextBox
            // 
            this.variableTextBox.Location = new System.Drawing.Point(46, 39);
            this.variableTextBox.Name = "variableTextBox";
            this.variableTextBox.Size = new System.Drawing.Size(130, 20);
            this.variableTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(77, 65);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(70, 25);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            this.submitButton.MouseEnter += new System.EventHandler(this.submitButton_MouseEnter);
            this.submitButton.MouseLeave += new System.EventHandler(this.submitButton_MouseLeave);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.deleteButton);
            this.groupBox.Controls.Add(this.CurrentVarLabel);
            this.groupBox.Controls.Add(this.editTextBox);
            this.groupBox.Controls.Add(this.editButton);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox.Location = new System.Drawing.Point(269, 30);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(220, 125);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteButton.Location = new System.Drawing.Point(125, 81);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 25);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.deleteButton_MouseEnter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.deleteButton_MouseLeave);
            // 
            // CurrentVarLabel
            // 
            this.CurrentVarLabel.AutoSize = true;
            this.CurrentVarLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentVarLabel.Location = new System.Drawing.Point(75, 23);
            this.CurrentVarLabel.Name = "CurrentVarLabel";
            this.CurrentVarLabel.Size = new System.Drawing.Size(73, 14);
            this.CurrentVarLabel.TabIndex = 7;
            this.CurrentVarLabel.Text = "Edit variable";
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(45, 40);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.ReadOnly = true;
            this.editTextBox.Size = new System.Drawing.Size(130, 20);
            this.editTextBox.TabIndex = 5;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(25, 81);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(70, 25);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.MouseEnter += new System.EventHandler(this.editButton_MouseEnter);
            this.editButton.MouseLeave += new System.EventHandler(this.editButton_MouseLeave);
            // 
            // variableListBox
            // 
            this.variableListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variableListBox.FormattingEnabled = true;
            this.variableListBox.ItemHeight = 19;
            this.variableListBox.Location = new System.Drawing.Point(12, 36);
            this.variableListBox.Name = "variableListBox";
            this.variableListBox.Size = new System.Drawing.Size(251, 251);
            this.variableListBox.TabIndex = 1;
            this.variableListBox.SelectedIndexChanged += new System.EventHandler(this.variableListBox_SelectedIndexChanged);
            // 
            // VariablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VariablesForm";
            this.Text = "AddVariableForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox variableTextBox;
        private System.Windows.Forms.ListBox variableListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label newVariableLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label CurrentVarLabel;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.Button editButton;
    }
}