using System.Windows;
using UI.Shell;

namespace HumanFactor
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ShellView app = new ShellView();
            ShellViewModel context = new ShellViewModel();
            app.DataContext = context;
            app.Show();
        }

    }
}
