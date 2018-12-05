using Avalonia;
using Avalonia.Markup.Xaml;

namespace test_avalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
