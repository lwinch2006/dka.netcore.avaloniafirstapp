using System;
using System.Collections.Generic;
using System.Text;
using Dka.NetCore.AvaloniaFirstApp1.Services;

namespace Dka.NetCore.AvaloniaFirstApp1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public TodoListViewModel List { get; }
        
        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }
    }
}
