using System;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaWindowFail
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void CloseWindow(object? parameter)
        {
            Window?.Close();
        }

        public System.Windows.Window? Window { get; set; }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public ICommand CloseWindowCommand => new ActionCommand(CloseWindow);
    }

    public sealed class ActionCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        private readonly Action<object?> _action;

        public ActionCommand(Action<object?> action) => _action = action;

        public void Execute(object? parameter) => _action.Invoke(parameter);
    }
}
