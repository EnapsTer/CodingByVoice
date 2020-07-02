namespace CodingByVoice
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.RecordingLabel = new System.Windows.Forms.Label();
            this.LogsLabel = new System.Windows.Forms.Label();
            this.AddVarLabel = new System.Windows.Forms.Label();
            this.StopRecordLabel = new System.Windows.Forms.Label();
            this.StartRecordLabel = new System.Windows.Forms.Label();
            this.LogsPanel = new System.Windows.Forms.Panel();
            this.AddVarPanel = new System.Windows.Forms.Panel();
            this.StopRecordPanel = new System.Windows.Forms.Panel();
            this.StartRecordPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.RecordingLabel);
            this.mainPanel.Controls.Add(this.LogsLabel);
            this.mainPanel.Controls.Add(this.AddVarLabel);
            this.mainPanel.Controls.Add(this.StopRecordLabel);
            this.mainPanel.Controls.Add(this.StartRecordLabel);
            this.mainPanel.Controls.Add(this.LogsPanel);
            this.mainPanel.Controls.Add(this.AddVarPanel);
            this.mainPanel.Controls.Add(this.StopRecordPanel);
            this.mainPanel.Controls.Add(this.StartRecordPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 180);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // RecordingLabel
            // 
            this.RecordingLabel.AutoSize = true;
            this.RecordingLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordingLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.RecordingLabel.Location = new System.Drawing.Point(152, 28);
            this.RecordingLabel.Name = "RecordingLabel";
            this.RecordingLabel.Size = new System.Drawing.Size(98, 19);
            this.RecordingLabel.TabIndex = 7;
            this.RecordingLabel.Text = "Recording. . .";
            this.RecordingLabel.Visible = false;
            // 
            // LogsLabel
            // 
            this.LogsLabel.AutoSize = true;
            this.LogsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogsLabel.Location = new System.Drawing.Point(318, 137);
            this.LogsLabel.Name = "LogsLabel";
            this.LogsLabel.Size = new System.Drawing.Size(34, 13);
            this.LogsLabel.TabIndex = 6;
            this.LogsLabel.Text = "Logs";
            this.LogsLabel.Visible = false;
            // 
            // AddVarLabel
            // 
            this.AddVarLabel.AutoSize = true;
            this.AddVarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddVarLabel.Location = new System.Drawing.Point(207, 137);
            this.AddVarLabel.Name = "AddVarLabel";
            this.AddVarLabel.Size = new System.Drawing.Size(79, 13);
            this.AddVarLabel.TabIndex = 5;
            this.AddVarLabel.Text = "Add Variable";
            this.AddVarLabel.Visible = false;
            // 
            // StopRecordLabel
            // 
            this.StopRecordLabel.AutoSize = true;
            this.StopRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopRecordLabel.Location = new System.Drawing.Point(117, 137);
            this.StopRecordLabel.Name = "StopRecordLabel";
            this.StopRecordLabel.Size = new System.Drawing.Size(78, 13);
            this.StopRecordLabel.TabIndex = 4;
            this.StopRecordLabel.Text = "Stop Record";
            this.StopRecordLabel.Visible = false;
            // 
            // StartRecordLabel
            // 
            this.StartRecordLabel.AutoSize = true;
            this.StartRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartRecordLabel.Location = new System.Drawing.Point(27, 137);
            this.StartRecordLabel.Name = "StartRecordLabel";
            this.StartRecordLabel.Size = new System.Drawing.Size(79, 13);
            this.StartRecordLabel.TabIndex = 3;
            this.StartRecordLabel.Text = "Start Record";
            this.StartRecordLabel.Visible = false;
            // 
            // LogsPanel
            // 
            this.LogsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogsPanel.BackgroundImage")));
            this.LogsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogsPanel.Location = new System.Drawing.Point(300, 63);
            this.LogsPanel.Name = "LogsPanel";
            this.LogsPanel.Size = new System.Drawing.Size(70, 70);
            this.LogsPanel.TabIndex = 1;
            this.LogsPanel.Click += new System.EventHandler(this.LogsPanel_Click);
            this.LogsPanel.MouseEnter += new System.EventHandler(this.SettingsPanel_MouseEnter);
            this.LogsPanel.MouseLeave += new System.EventHandler(this.SettingsPanel_MouseLeave);
            // 
            // AddVarPanel
            // 
            this.AddVarPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddVarPanel.BackgroundImage")));
            this.AddVarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddVarPanel.Location = new System.Drawing.Point(210, 63);
            this.AddVarPanel.Name = "AddVarPanel";
            this.AddVarPanel.Size = new System.Drawing.Size(70, 70);
            this.AddVarPanel.TabIndex = 2;
            this.AddVarPanel.Click += new System.EventHandler(this.AddVarPanel_Click);
            this.AddVarPanel.MouseEnter += new System.EventHandler(this.AddVarPanel_MouseEnter);
            this.AddVarPanel.MouseLeave += new System.EventHandler(this.AddVarPanel_MouseLeave);
            // 
            // StopRecordPanel
            // 
            this.StopRecordPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopRecordPanel.BackgroundImage")));
            this.StopRecordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopRecordPanel.Location = new System.Drawing.Point(120, 63);
            this.StopRecordPanel.Name = "StopRecordPanel";
            this.StopRecordPanel.Size = new System.Drawing.Size(70, 70);
            this.StopRecordPanel.TabIndex = 1;
            this.StopRecordPanel.Click += new System.EventHandler(this.StopRecordPanel_Click);
            this.StopRecordPanel.MouseEnter += new System.EventHandler(this.StopRecordPanel_MouseEnter);
            this.StopRecordPanel.MouseLeave += new System.EventHandler(this.StopRecordPanel_MouseLeave);
            // 
            // StartRecordPanel
            // 
            this.StartRecordPanel.BackgroundImage = global::CodingByVoice.Properties.Resources.record;
            this.StartRecordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartRecordPanel.Location = new System.Drawing.Point(30, 63);
            this.StartRecordPanel.Name = "StartRecordPanel";
            this.StartRecordPanel.Size = new System.Drawing.Size(70, 70);
            this.StartRecordPanel.TabIndex = 0;
            this.StartRecordPanel.Click += new System.EventHandler(this.StartRecordPanel_Click);
            this.StartRecordPanel.MouseEnter += new System.EventHandler(this.StartRecordPanel_MouseEnter);
            this.StartRecordPanel.MouseLeave += new System.EventHandler(this.StartRecordPanel_MouseLeave);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Black;
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(400, 25);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(372, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 15);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.TopMost = true;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel StartRecordPanel;
        private System.Windows.Forms.Panel LogsPanel;
        private System.Windows.Forms.Panel AddVarPanel;
        private System.Windows.Forms.Panel StopRecordPanel;
        private System.Windows.Forms.Label LogsLabel;
        private System.Windows.Forms.Label AddVarLabel;
        private System.Windows.Forms.Label StopRecordLabel;
        private System.Windows.Forms.Label StartRecordLabel;
        private System.Windows.Forms.Label RecordingLabel;
    }
}

