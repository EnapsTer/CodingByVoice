using System.Collections.Generic;
using CodingByVoice.Presenters;
using System.Windows.Forms;

namespace CodingByVoice.Views
{
    public interface IVariablesView
    {
        VariablesPresenter Presenter { set; }
        List<string> VariablesNames { get; set; }
        MessageBox MessageBox { get; set; }
        string VariableName { get; set; }
        int SelectedVariable { get; set; }
        void ThrowException(string message);

    }
}
