using System.Windows;

namespace PassLogin
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            // Hide the default startup window (if any)
            this.StartupUri = null;
            
            // Create and show the login window
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
