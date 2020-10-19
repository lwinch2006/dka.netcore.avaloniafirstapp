using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dka.NetCore.AvaloniaFirstApp1.Models;

namespace Dka.NetCore.AvaloniaFirstApp1.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public ObservableCollection<TodoItem> Items { get; }           
        
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }
    }
}