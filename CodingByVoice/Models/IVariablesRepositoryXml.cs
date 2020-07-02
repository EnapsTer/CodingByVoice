using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingByVoice.Models
{
    public interface IVariablesRepositoryXml
    {
        List<string> GetAllVariables();

        int Count { get; }

        string GetVariableName(int index);

        void EditVariableName(int index, string name);

        void RemoveVariable(int index);

        void AddVariableName(string variableName);

        bool Contains(string name);
    }
}
