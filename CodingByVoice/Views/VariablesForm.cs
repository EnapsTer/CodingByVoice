using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;


namespace CodingByVoice.Views
{
    public partial class VariablesForm : Form, IVariablesView
    {
        /*Настройки для передвижения формы*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //булевая переменная, определяющая состояние редактирования
        private bool _isEditMode = false;

        public VariablesForm()
        {
            InitializeComponent();
        }

        //Свойство хранящяя экземпляр класса VariablePresenter
        public Presenters.VariablesPresenter Presenter { private get; set; }

        //Свойство для установки и возврата variableListBox
        public List<string> VariablesNames
        {
            get { return (List<string>)variableListBox.DataSource; }
            set { variableListBox.DataSource = value; }
        }

        //Свойство хранит номер выбранного элемента из variableLustBox
        public int SelectedVariable
        {
            get { return variableListBox.SelectedIndex; }
            set { variableListBox.SelectedIndex = value; }
        }

        //Имя выбранной переменной
        public string VariableName
        {
            get { return editTextBox.Text; }
            set { editTextBox.Text = value; }
        }

        //Выплывающее окно для вывода сообщений
        public MessageBox MessageBox { get; set; }

        //Общий метод для вывода ошибок
        public void ThrowException(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }


        //Валидатор для праильного названия переменной
        private bool variableValidator(string name)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");
            if (provider.IsValidIdentifier(name) && Regex.IsMatch(name, "^[a-zA-Z_$][a-zA-Z_$0-9]*$"))
                return true;
            else
                return false;
        }

        /*Обработчики кликов на объекты*/

        //Редактирования выбранной переменной
        private void editButton_Click(object sender, EventArgs e)
        {
            editTextBox.ReadOnly = _isEditMode;

            editButton.Text = _isEditMode ? "Edit" : "Save";
            _isEditMode = !_isEditMode;

            if (!_isEditMode)
            {
                //валидация для переменной
                if (variableValidator(editTextBox.Text))
                    Presenter.EditVariable();
                else
                    ThrowException("Invalid variable name");
            }
        }

        //Удаление переменной
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Presenter.DeleteVariable();
        }

        //Добавление новой переменной
        private void submitButton_Click(object sender, EventArgs e)
        {
            Presenter.AddVariable(variableTextBox.Text);
        }

        //Обработчик изменения выбранной переменной variableListBox
        private void variableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateVariablesView(variableListBox.SelectedIndex);
        }

        /* Обработчики для дизайна формы*/
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, mainPanel.ClientRectangle,
                       Color.Black, 5, ButtonBorderStyle.Solid, // left
                       Color.Black, 5, ButtonBorderStyle.Solid, // top
                       Color.Black, 5, ButtonBorderStyle.Solid, // right
                       Color.Black, 5, ButtonBorderStyle.Solid);// bottom
        }

        private void mainPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Presenter.ShowMainForm();
            this.Close();
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

        private void submitButton_MouseEnter(object sender, EventArgs e)
        {
            submitButton.BackColor = Color.LightGreen;
        }

        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            submitButton.BackColor = Color.Transparent;
        }

        private void editButton_MouseEnter(object sender, EventArgs e)
        {
            editButton.BackColor = Color.LightGreen;
        }

        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            editButton.BackColor = Color.Transparent;
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.IndianRed;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.Transparent;
        }

        
    }
}
