using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using mvvm_test.ViewModels;
using mvvm_test.Views;

namespace mvvm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start<MainWindow>(() => new MainWindowViewModel());
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .UseReactiveUI()
                .LogToDebug();
    }
}
