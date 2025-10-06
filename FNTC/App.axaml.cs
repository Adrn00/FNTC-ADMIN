using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using FNTC.ViewModels;  // ✅ Make sure this using is here

namespace FNTC
{
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
                // ✅ Correct way to set DataContext
                desktop.MainWindow = new MainViewww
                {
                    DataContext = new MainViewwwModel()
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
