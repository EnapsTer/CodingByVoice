using System;
using System.Drawing;
using System.Windows.Forms;
using CodingByVoice.Views;

namespace CodingByVoice
{
    public partial class MainForm : Form, IMainView
    {

        /*Настройки для передвижения формы*/

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
        }

        //Свойство хранящая экземпляр класса совего представителя RecognizerInputPresenter
        public Presenters.RecognizerInputPresenter Presenter
        { private get; set; }

        //Выплывающее окно для вывода сообщений
        public MessageBox MessageBox
        { get; set; }

        //Вызов всплывающего сообщения, если распознователь уже выключен
        public void StopRecordError()
        {
            MessageBox.Show("Recognition already off", "Error", MessageBoxButtons.OK);
        }
        
        /*Обработчики кликов на объекты*/

        //Закрытие всего приложение
        private void closeButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        //Включение распознователя речи
        private void StartRecordPanel_Click(object sender, EventArgs e)
        {
            Presenter.StartRec();

            RecordingLabel.Visible = true;
            StartRecordPanel.Enabled = false;
        }

        //Выключение распознователя речи
        private void StopRecordPanel_Click(object sender, EventArgs e)
        {
            if (!Presenter.StopRec())
            {
                StopRecordError();
            }

            RecordingLabel.Visible = false;
            StartRecordPanel.Enabled = true;
        }

        //Открытие другой формы для добавления названий переменных
        private void AddVarPanel_Click(object sender, EventArgs e)
        {
            
            Presenter.ShowVariableForm();
            this.Visible = false;

            RecordingLabel.Visible = false;
            StartRecordPanel.Enabled = true;
        }

        private void LogsPanel_Click(object sender, EventArgs e)
        {
            Presenter.ShowLogsForm();
            this.Visible = false;

            RecordingLabel.Visible = false;
            StartRecordPanel.Enabled = true;
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

        private void StartRecordPanel_MouseEnter(object sender, EventArgs e)
        {
            StartRecordPanel.BackgroundImage = CodingByVoice.Properties.Resources.record_hover;
            StartRecordPanel.Size = new Size(StartRecordPanel.Size.Height + 6, StartRecordPanel.Size.Width + 6);
            StartRecordPanel.Location = new Point(StartRecordPanel.Location.X - 3, StartRecordPanel.Location.Y - 3);
            StartRecordLabel.Visible = true;
        }

        private void StartRecordPanel_MouseLeave(object sender, EventArgs e)
        {
            StartRecordPanel.BackgroundImage = CodingByVoice.Properties.Resources.record;
            StartRecordPanel.Size = new Size(StartRecordPanel.Size.Height - 6, StartRecordPanel.Size.Width - 6);
            StartRecordPanel.Location = new Point(StartRecordPanel.Location.X + 3, StartRecordPanel.Location.Y + 3);
            StartRecordLabel.Visible = false;

        }

        private void StopRecordPanel_MouseEnter(object sender, EventArgs e)
        {
            StopRecordPanel.BackgroundImage = CodingByVoice.Properties.Resources.stopRecord_hover;
            StopRecordPanel.Size = new Size(StopRecordPanel.Size.Height + 6, StopRecordPanel.Size.Width + 6);
            StopRecordPanel.Location = new Point(StopRecordPanel.Location.X - 3, StopRecordPanel.Location.Y - 3);
            StopRecordLabel.Visible = true;
        }

        private void StopRecordPanel_MouseLeave(object sender, EventArgs e)
        {
            StopRecordPanel.BackgroundImage = CodingByVoice.Properties.Resources.stopRecord;
            StopRecordPanel.Size = new Size(StopRecordPanel.Size.Height - 6, StopRecordPanel.Size.Width - 6);
            StopRecordPanel.Location = new Point(StopRecordPanel.Location.X + 3, StopRecordPanel.Location.Y + 3);
            StopRecordLabel.Visible = false;
        }

        private void AddVarPanel_MouseEnter(object sender, EventArgs e)
        {
            AddVarPanel.BackgroundImage = CodingByVoice.Properties.Resources.addVar_hover;
            AddVarPanel.Size = new Size(AddVarPanel.Size.Height + 6, AddVarPanel.Size.Width + 6);
            AddVarPanel.Location = new Point(AddVarPanel.Location.X - 3, AddVarPanel.Location.Y - 3);
            AddVarLabel.Visible = true;
        }

        private void AddVarPanel_MouseLeave(object sender, EventArgs e)
        {
            AddVarPanel.BackgroundImage = CodingByVoice.Properties.Resources.addVar;
            AddVarPanel.Size = new Size(AddVarPanel.Size.Height - 6, AddVarPanel.Size.Width - 6);
            AddVarPanel.Location = new Point(AddVarPanel.Location.X + 3, AddVarPanel.Location.Y + 3);
            AddVarLabel.Visible = false;
        }

        private void SettingsPanel_MouseEnter(object sender, EventArgs e)
        {
            LogsPanel.BackgroundImage = CodingByVoice.Properties.Resources.logs_hover;
            LogsPanel.Size = new Size(LogsPanel.Size.Height + 6, LogsPanel.Size.Width + 6);
            LogsPanel.Location = new Point(LogsPanel.Location.X - 3, LogsPanel.Location.Y - 3);
            LogsLabel.Visible = true;
        }

        private void SettingsPanel_MouseLeave(object sender, EventArgs e)
        {
            LogsPanel.BackgroundImage = CodingByVoice.Properties.Resources.logs;
            LogsPanel.Size = new Size(LogsPanel.Size.Height - 6, LogsPanel.Size.Width - 6);
            LogsPanel.Location = new Point(LogsPanel.Location.X + 3, LogsPanel.Location.Y + 3);
            LogsLabel.Visible = false;
        }

        
    }
}
