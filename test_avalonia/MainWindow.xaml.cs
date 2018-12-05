using Avalonia;
using Avalonia.Controls;
using Avalonia.Diagnostics.ViewModels;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace test_avalonia
{
    public class MainWindow : Window
    {
        public TextObject2D hoge { get; set; }

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void OnClick_Button(object sender, RoutedEventArgs routedEventArgs)
        {
            Console.Write("hello");
        }
    }

    public class TextObject2D : ViewModelBase
    {

        public asd.TextObject2D Object = new asd.TextObject2D()
        {
            Position = new asd.Vector2DF(100, 100),
            Font = asd.Engine.Graphics.CreateDynamicFont("", 35, new asd.Color(255, 0, 0, 255), 1, new asd.Color(255, 255, 255, 255)),
            Text = "動的フォントによる文字列描画"
        };

        public string Text
        {
            get => Object.Text;
            set
            {
                Object.Text = value;
                RaisePropertyChanged("Text");
            }
        }
    }
}
