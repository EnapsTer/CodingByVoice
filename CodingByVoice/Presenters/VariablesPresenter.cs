using System.Collections.Generic;
using System.Linq;
using CodingByVoice.Models;
using CodingByVoice.Views;

namespace CodingByVoice.Presenters
{
    public class VariablesPresenter
    {
        private readonly IVariablesRepositoryXml _repository;
        private readonly IVariablesView _view;

public VariablesPresenter(IVariablesRepositoryXml repository, IVariablesView variablesView)
{
    _repository = repository;
    _view = variablesView;
    _view.Presenter = this;

    UpdateVariablesListView();
}

        public void ShowMainForm()
        {
            MainPresenter.ShowMainForm();
        }

        public void UpdateVariablesListView()
        {
            List<string> variablesNames = _repository.GetAllVariables().ToList();
            int selectedVariable = _view.SelectedVariable >= 0 ? _view.SelectedVariable : 0;
            _view.VariablesNames = variablesNames;

            if (_repository.Count != 0)
                _view.SelectedVariable = selectedVariable;
            else
                _view.VariableName = "";
            
            
        }

        public void UpdateVariablesView(int index)
        {
            if (_repository.Count > 1)
            {
                string name = _repository.GetVariableName(index);
                _view.VariableName = name;
            }
        }

public void AddVariable(string variableName)
{
    if (!_repository.Contains(variableName.ToLower()))
    {
        _repository.AddVariableName(variableName.ToLower());
        UpdateVariablesListView();  
    }
    else
        _view.ThrowException("This name is already exists");
}

        public void DeleteVariable()
        {
            if (_repository.Count > 1)
            {
                _repository.RemoveVariable(_view.SelectedVariable);
                if (_repository.Count == _view.SelectedVariable)
                    _view.SelectedVariable--;
                UpdateVariablesListView();
            }
                
        }

        public void EditVariable()
        {
            if (!_repository.Contains(_view.VariableName.ToLower()))
            {
                if (_repository.Count != 0)
                {
                    _repository.EditVariableName(_view.SelectedVariable, _view.VariableName.ToLower());
                    UpdateVariablesListView();
                }
            }
            else
                _view.ThrowException("This name is already exists");
        }
    }
}
