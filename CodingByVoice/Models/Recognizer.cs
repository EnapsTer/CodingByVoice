using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;
using Microsoft.Speech.Recognition.SrgsGrammar;

namespace CodingByVoice.Models
{
    public class Recognizer
    {
        static System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        static private SpeechRecognitionEngine sre = new SpeechRecognitionEngine(culture);
        public delegate void Handler(object sender, SpeechRecognizedEventArgs e);


        public Recognizer(Handler handler)
        {
            LoadSpeechEngine(handler);

            LoadGrammar();
        }


        private void LoadSpeechEngine(Handler handler)
        {
            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(handler);
        }

        private void LoadGrammar()
        {
            string grammarPath = @"..\..\Grammars\";
            //Компилируем наше грамматическое правило в файл KeywordsGrammar.cfg
            FileStream fs = new FileStream(grammarPath + "KeywordsGrammar.cfg", FileMode.Create);
            SrgsGrammarCompiler.Compile(grammarPath + "KeywordsGrammar.xml", (Stream)fs);
            fs.Close();
            Grammar KeywordsGrammar = new Grammar(grammarPath + "KeywordsGrammar.cfg", "topLevel");
            KeywordsGrammar.Priority = 3;

            fs = new FileStream(grammarPath + "VariablesGrammar.cfg", FileMode.Create);
            SrgsGrammarCompiler.Compile(grammarPath + "VariablesGrammar.xml", (Stream)fs);
            fs.Close();
            Grammar VariableGrammar = new Grammar(grammarPath + "VariablesGrammar.cfg", "topLevel");
            VariableGrammar.Priority = 0;
            //Загружаем скомпилированный файл грамматики
            
            sre.LoadGrammar(KeywordsGrammar);
            sre.LoadGrammar(VariableGrammar);
        }


        public void StartRec()
        {
            sre.UnloadAllGrammars();
            LoadGrammar();
            sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void StopRec()
        {
            sre.RecognizeAsyncStop();
        }
    }
}
