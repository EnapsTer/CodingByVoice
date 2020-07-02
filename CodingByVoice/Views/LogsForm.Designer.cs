namespace CodingByVoice.Views
{
    partial class LogsForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logsTextBox = new System.Windows.Forms.RichTextBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.openTxtButton = new System.Windows.Forms.Button();
            this.confidenceCountLabel = new System.Windows.Forms.Label();
            this.wordsCountLable = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.totalWordsLabel = new System.Windows.Forms.Label();
            this.confidenceLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.logsTextBox);
            this.mainPanel.Controls.Add(this.infoGroupBox);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(300, 500);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // logsTextBox
            // 
            this.logsTextBox.Location = new System.Drawing.Point(13, 157);
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ReadOnly = true;
            this.logsTextBox.Size = new System.Drawing.Size(275, 331);
            this.logsTextBox.TabIndex = 3;
            this.logsTextBox.Text = "";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.openTxtButton);
            this.infoGroupBox.Controls.Add(this.confidenceCountLabel);
            this.infoGroupBox.Controls.Add(this.wordsCountLable);
            this.infoGroupBox.Controls.Add(this.resetButton);
            this.infoGroupBox.Controls.Add(this.totalWordsLabel);
            this.infoGroupBox.Controls.Add(this.confidenceLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 41);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(276, 105);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            // 
            // openTxtButton
            // 
            this.openTxtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTxtButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openTxtButton.Location = new System.Drawing.Point(162, 67);
            this.openTxtButton.Name = "openTxtButton";
            this.openTxtButton.Size = new System.Drawing.Size(70, 25);
            this.openTxtButton.TabIndex = 5;
            this.openTxtButton.Text = "Open Txt";
            this.openTxtButton.UseVisualStyleBackColor = true;
            this.openTxtButton.Click += new System.EventHandler(this.openTxtButton_Click);
            this.openTxtButton.MouseEnter += new System.EventHandler(this.openTxtButton_MouseEnter);
            this.openTxtButton.MouseLeave += new System.EventHandler(this.openTxtButton_MouseLeave);
            // 
            // confidenceCountLabel
            // 
            this.confidenceCountLabel.AutoSize = true;
            this.confidenceCountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CodingByVoice.Properties.Settings.Default, "AverageConfidence", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.confidenceCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confidenceCountLabel.Location = new System.Drawing.Point(139, 43);
            this.confidenceCountLabel.Name = "confidenceCountLabel";
            this.confidenceCountLabel.Size = new System.Drawing.Size(15, 16);
            this.confidenceCountLabel.TabIndex = 4;
            this.confidenceCountLabel.Text = "0";
            // 
            // wordsCountLable
            // 
            this.wordsCountLable.AutoSize = true;
            this.wordsCountLable.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CodingByVoice.Properties.Settings.Default, "WordsCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.wordsCountLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsCountLable.Location = new System.Drawing.Point(97, 21);
            this.wordsCountLable.Name = "wordsCountLable";
            this.wordsCountLable.Size = new System.Drawing.Size(15, 16);
            this.wordsCountLable.TabIndex = 3;
            this.wordsCountLable.Text = "0";
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(45, 67);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(70, 25);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.resetButton_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.resetButton_MouseLeave);
            // 
            // totalWordsLabel
            // 
            this.totalWordsLabel.AutoSize = true;
            this.totalWordsLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalWordsLabel.Location = new System.Drawing.Point(21, 21);
            this.totalWordsLabel.Name = "totalWordsLabel";
            this.totalWordsLabel.Size = new System.Drawing.Size(77, 15);
            this.totalWordsLabel.TabIndex = 1;
            this.totalWordsLabel.Text = "Total Words:";
            // 
            // confidenceLabel
            // 
            this.confidenceLabel.AutoSize = true;
            this.confidenceLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confidenceLabel.Location = new System.Drawing.Point(21, 43);
            this.confidenceLabel.Name = "confidenceLabel";
            this.confidenceLabel.Size = new System.Drawing.Size(119, 15);
            this.confidenceLabel.TabIndex = 0;
            this.confidenceLabel.Text = "Average Confidence:";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Black;
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(300, 25);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(272, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 15);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogsForm";
            this.Text = "LogsForm";
            this.mainPanel.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.RichTextBox logsTextBox;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label confidenceLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label totalWordsLabel;
        private System.Windows.Forms.Label confidenceCountLabel;
        private System.Windows.Forms.Label wordsCountLable;
        private System.Windows.Forms.Button openTxtButton;
    }
}