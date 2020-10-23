using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Dka.NetCore.AvaloniaFirstApp.Views
{
    public class TodoListView : UserControl
    {
        public TodoListView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}