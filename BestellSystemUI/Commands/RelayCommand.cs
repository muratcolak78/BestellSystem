
using System.Windows.Input;

namespace BestellSystemUI.Commands;

class RelayCommand : ICommand
{
    Action<object?> _action;
    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public RelayCommand(Action<object?> action)
    {
       _action = action;
    }

   

    public void Execute(object? parameter)
    {
        _action?.Invoke(parameter);
    }

   
}
