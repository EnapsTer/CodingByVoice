using System;
using CodingByVoice.Presenters;
using System.Windows.Forms;


namespace CodingByVoice.Views
{
    public interface IMainView
    {
        RecognizerInputPresenter Presenter { set; }
        MessageBox MessageBox { get;  set; }
        void StopRecordError();
    }
}
