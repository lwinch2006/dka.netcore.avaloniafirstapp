using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Dka.NetCore.AvaloniaFirstApp1.Services;
using Dka.NetCore.AvaloniaFirstApp1.ViewModels;
using Dka.NetCore.AvaloniaFirstApp1.Views;

namespace Dka.NetCore.AvaloniaFirstApp1
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var db = new Database();
                
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(db)
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}