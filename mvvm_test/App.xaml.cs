using Avalonia;
using Avalonia.Markup.Xaml;

namespace mvvm_test
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
