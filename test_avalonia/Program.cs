using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.Threading;

namespace test_avalonia
{
    class Program
    {

        static void Main(string[] args)
        {
            asd.Engine.Initialize("hoge", 640, 480, new asd.EngineOption());
            BuildAvaloniaApp();
            MainWindow window = new MainWindow();
            window.Show();
            window.DataContext = new asd.TextObject2D()
            {
                Position = new asd.Vector2DF(100, 100),
                Font = asd.Engine.Graphics.CreateDynamicFont("", 35, new asd.Color(255, 0, 0, 255), 1, new asd.Color(255, 255, 255, 255)),
                Text = "動的フォントによる文字列描画"
            };
            asd.Engine.AddObject2D((asd.TextObject2D)window.DataContext);
            //Dispatcher.UIThread.Post(Update, DispatcherPriority.Normal);
            while (asd.Engine.DoEvents())
            {
                Dispatcher.UIThread.RunJobs();
                asd.Engine.Update();
            }
            asd.Engine.Terminate();
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UseSkia()
                         .UseMonoMac()
                .LogToDebug()
                .SetupWithoutStarting();
    }
}
