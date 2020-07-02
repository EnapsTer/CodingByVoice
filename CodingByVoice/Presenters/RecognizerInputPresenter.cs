using System;
using Microsoft.Speech.Recognition;
using CodingByVoice.Views;
using CodingByVoice.Models;
using CodingByVoice.Presenters;

namespace CodingByVoice.Presenters
{
    public class RecognizerInputPresenter
    {
        private readonly IMainView _view;

        private Recognizer recognizer;
        private InputCodeSimulator simulator;
        private bool isRecognizerActive = false;

        public RecognizerInputPresenter(IMainView view)
        {
            _view = view;
            _view.Presenter = this;

            Recognizer.Handler handler = RecognizerHandler;
            recognizer = new Recognizer(handler);

            simulator = new InputCodeSimulator();
            VariablesRepositoryXml variables = new VariablesRepositoryXml();
        }

        public void ShowVariableForm()
        {
            StopRec();
            MainPresenter.ShowVariableForm();
        }

        public void ShowLogsForm()
        {
            StopRec();
            MainPresenter.ShowLogsForm();
        }

        public void StartRec()
        {
            recognizer.StartRec();
            isRecognizerActive = true;
            Log.Logging("Start record");
        }

        public bool StopRec()
        {
            if (isRecognizerActive)
            {
                recognizer.StopRec();
                isRecognizerActive = false;
                Log.Logging("Stop recording", true);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RecognizerHandler(object sender, SpeechRecognizedEventArgs e)
        {
            string value = e.Result.Semantics["value"].Value.ToString();
            string confidence = e.Result.Confidence.ToString();
            string speechText = e.Result.Text;
            string type = e.Result.Semantics["type"].Value.ToString();




            if (type == "variable")
            {
                string capital = e.Result.Semantics["capital"].Value.ToString();
                simulator.SimulateVariable(value, capital);
            }
            else {
                simulator.SimulateKeyWords(type, value);
            }

            Log.Logging(value, confidence, speechText, type);
            Console.WriteLine(e.Result.Semantics["value"].Value.ToString() + " " + e.Result.Confidence);
            Console.WriteLine(e.Result.Text + " " + type);
        }

    }
}
