using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ViewLocator.Generator.Demo.ViewModels;
using ViewLocator.Generator.Demo.Views;

namespace ViewLocator.Generator.Demo;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow { DataContext = new MainWindowViewModel(), };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
