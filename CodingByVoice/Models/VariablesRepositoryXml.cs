using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CodingByVoice.Models;

namespace CodingByVoice.Models
{
    public class VariablesRepositoryXml: IVariablesRepositoryXml
    {
        static private readonly string repositoryPath = @"..\..\Grammars\";
        static private readonly string repositoryName = @"VariablesGrammar.xml";
        static private readonly string ns = "http://www.w3.org/2001/06/grammar";
        private XmlDocument xdoc = new XmlDocument();
        private XmlNamespaceManager nsMgr;
        private List<string> variableNames;
        

        public VariablesRepositoryXml()
        {
            xdoc.Load(repositoryPath + repositoryName);
            nsMgr = new XmlNamespaceManager(xdoc.NameTable);
            nsMgr.AddNamespace("g", ns);

            variableNames = new List<string>();
            loadVaribaleNames();
            
        }

        public int Count
        {
            get
            {
                return variableNames.Count;
            }
        }

        public List<string> GetAllVariables()
        {
            return variableNames;
        }

        public void AddVariableName(string variableName)
        {
            XmlNode root = xdoc.SelectSingleNode("//g:rule[@id=\"Variables\"]/g:one-of", nsMgr);
            XmlElement item = xdoc.CreateElement("item", ns);
            item.InnerText = String.Format(" {0} ", variableName);
            XmlElement tag = xdoc.CreateElement("tag", ns);
            tag.InnerText = String.Format(" $ = \"{0}\" ", variableName);
            item.AppendChild(tag);
            root.AppendChild(item);
            xdoc.Save(repositoryPath + repositoryName);

            variableNames.Add(variableName);
        }

        public string GetVariableName(int index)
        {
            return variableNames[index];
        }

        public void EditVariableName(int index, string name)
        {
            XmlNode item = xdoc.SelectSingleNode("//g:rule[@id=\"Variables\"]/g:one-of", nsMgr);
            item.ChildNodes[index].InnerXml = String.Format(" {0} <tag> $ = \"{0}\" </tag>", name);
            xdoc.Save(repositoryPath + repositoryName);

            variableNames[index] = name;
        }

        public void RemoveVariable(int index)
        {
            XmlNode item = xdoc.SelectSingleNode("//g:rule[@id=\"Variables\"]/g:one-of", nsMgr);
            Console.WriteLine(item.ChildNodes[index].InnerText);

            item.RemoveChild(item.ChildNodes[index]);
            xdoc.Save(repositoryPath + repositoryName);

            variableNames.RemoveAt(index);
        }

        public bool Contains(string name)
        {
            return variableNames.Contains(name);
        }

        private void loadVaribaleNames()
        {
            XmlNodeList items = xdoc.SelectNodes("//g:rule[@id=\"Variables\"]/g:one-of//g:tag", nsMgr);
            foreach (XmlNode node in items)
            {
                string name = node.InnerText.Split(new char[] { ' ', '"', '$', '=' }, StringSplitOptions.RemoveEmptyEntries)[0];
                variableNames.Add(name);
            }
        }


    }
}
