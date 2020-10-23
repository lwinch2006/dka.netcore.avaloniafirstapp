using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Dka.NetCore.AvaloniaFirstApp.Models;

namespace Dka.NetCore.AvaloniaFirstApp.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public ObservableCollection<TodoItem> Items { get; }

        public TodoListViewModel()
        {
            Items = new ObservableCollection<TodoItem>(Enumerable.Empty<TodoItem>());
        }
        
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }
    }
}