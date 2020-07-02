using CodingByVoice.Views;
using System.Windows.Forms;
using CodingByVoice.Models;

namespace CodingByVoice.Presenters
{
    public class MainPresenter
    {

        static private VariablesRepositoryXml _repository = new VariablesRepositoryXml();
        static private MainForm mainView = new MainForm();

        static public void RunApp()
        {
            RecognizerInputPresenter recognizerInputPresenter = new RecognizerInputPresenter(mainView);
            Application.Run(mainView);
        }

        static public void ShowMainForm()
        {
            mainView.Visible = true;   
        }

        static public void ShowVariableForm()
        {
            var variableView = new VariablesForm();
            VariablesPresenter variablesPresenter = new VariablesPresenter(_repository, variableView);
            variableView.Show();
        }

        static public void ShowLogsForm()
        {
            var logsView = new LogsForm();
            LogsPresenter logsPresenter = new LogsPresenter(logsView);
            logsView.Show();
        }

    }
}
