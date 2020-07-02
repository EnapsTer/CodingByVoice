using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodingByVoice.Views
{
    public partial class LogsForm : Form, ILogsView
    {
        /*Настройки для передвижения формы*/

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public LogsForm()
        {
            InitializeComponent();
        }

        public Presenters.LogsPresenter Presenter { get; set; }

        public string TotalWords
        {
            get { return wordsCountLable.Text; }
            set { wordsCountLable.Text = value; }
        }

        public string AverageConfidence
        {
            get { return confidenceCountLabel.Text; }
            set { confidenceCountLabel.Text = value; }
        }

        public string LogsText
        {
            get { return logsTextBox.Text; }
            set { logsTextBox.Text = value; }
        }

        /*Обработчики кликов мышки*/

        private void closeButton_Click(object sender, EventArgs e)
        {
            Presenter.ShowMainForm();
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Presenter.ResetLogsFile();
        }

        private void openTxtButton_Click(object sender, EventArgs e)
        {
            Presenter.OpenFile();
        }

        /*Обработчики для дизайна формы*/

        private void mainPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, mainPanel.ClientRectangle,
                       Color.Black, 5, ButtonBorderStyle.Solid, // left
                       Color.Black, 5, ButtonBorderStyle.Solid, // top
                       Color.Black, 5, ButtonBorderStyle.Solid, // right
                       Color.Black, 5, ButtonBorderStyle.Solid);// bottom
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
            closeButton.Font = new Font(closeButton.Font.Name, 11, FontStyle.Bold);
            closeButton.Location = new Point(closeButton.Location.X - 1, closeButton.Location.Y - 1);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
            closeButton.Font = new Font(closeButton.Font.Name, 9, FontStyle.Bold);
            closeButton.Location = new Point(closeButton.Location.X + 1, closeButton.Location.Y + 1);
        }

        private void resetButton_MouseEnter(object sender, EventArgs e)
        {
            resetButton.BackColor = Color.IndianRed;
        }

        private void resetButton_MouseLeave(object sender, EventArgs e)
        {
            resetButton.BackColor = Color.Transparent;
        }

        private void openTxtButton_MouseEnter(object sender, EventArgs e)
        {
            openTxtButton.BackColor = Color.LightGreen;
        }

        private void openTxtButton_MouseLeave(object sender, EventArgs e)
        {
            openTxtButton.BackColor = Color.Transparent;
        }
    }
}
