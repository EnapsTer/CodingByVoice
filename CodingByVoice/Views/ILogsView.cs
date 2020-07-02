
using CodingByVoice.Presenters;

namespace CodingByVoice.Views
{
    public interface ILogsView
    {
        LogsPresenter Presenter { get; set; }
        string LogsText { get; set; }
        string TotalWords { get; set; }
        string AverageConfidence { get; set; }
    }
}
