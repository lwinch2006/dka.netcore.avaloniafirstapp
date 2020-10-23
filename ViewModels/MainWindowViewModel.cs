using System.Linq;
using Dka.NetCore.AvaloniaFirstApp.Models;
using Dka.NetCore.AvaloniaFirstApp.Services;

namespace Dka.NetCore.AvaloniaFirstApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public TodoListViewModel List { get; }

        public MainWindowViewModel()
        {
            List = new TodoListViewModel(Enumerable.Empty<TodoItem>());
        }
        
        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }
    }
}
