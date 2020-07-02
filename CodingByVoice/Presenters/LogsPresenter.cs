using CodingByVoice.Views;
using CodingByVoice.Models;

namespace CodingByVoice.Presenters
{
    public class LogsPresenter
    {
        private readonly ILogsView _view;

        public LogsPresenter(ILogsView view)
        {
            _view = view;
            _view.Presenter = this;

            UpdateLogsView();
        }

        public void ShowMainForm()
        {
            MainPresenter.ShowMainForm();
        }

        public void UpdateLogsView()
        {
            _view.LogsText = Log.getLogsText();

            _view.TotalWords = Properties.Settings.Default.WordsCount.ToString();
            _view.AverageConfidence = Properties.Settings.Default.AverageConfidence.ToString();
        }

        public void ResetLogsFile()
        {
            Log.ClearLogFile();
            UpdateLogsView();
        }

        public void OpenFile()
        {
            Log.OpenTxtFile();
        }
    }
}
