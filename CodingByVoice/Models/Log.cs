using System;
using System.IO;
using System.Diagnostics;

namespace CodingByVoice.Models
{
    class Log
    {

        static private readonly string filePath = @"..\..\logging\logs.txt";

        

static public void Logging(string state, bool tab = false)
{
    try
    {
        using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
        {
            sw.WriteLine(String.Format("{0}: [{1}]", state, DateTime.Now));
            if (tab == true)
                sw.WriteLine("\r\n");         
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

        static public void Logging(string value, string confidence, string speechText, string type)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(String.Format("-----[{0:T}]-----", DateTime.Now));
                    sw.WriteLine(String.Format("value: {0}", value));
                    sw.WriteLine(String.Format("confidence: {0}", confidence));
                    sw.WriteLine(String.Format("speech text: {0}", speechText));
                    sw.WriteLine(String.Format("type: {0}", type));

                    
                    Properties.Settings.Default.WordsCount++;
                    Properties.Settings.Default.ConfidenceSum += Double.Parse(confidence);
                    Properties.Settings.Default.AverageConfidence = Math.Round(Properties.Settings.Default.ConfidenceSum 
                        / Properties.Settings.Default.WordsCount, 5);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public string getLogsText()
        {
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return text;
        }

        static public void ClearLogFile()
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(filePath, false))
                {
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Properties.Settings.Default.WordsCount = 0;
            Properties.Settings.Default.AverageConfidence = 0;
            Properties.Settings.Default.ConfidenceSum = 0;
        }

        static public void OpenTxtFile()
        {
            Process.Start(filePath);
        }
    }
}
