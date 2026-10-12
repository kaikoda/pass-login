using System;
using System.Windows;

namespace PassLogin
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                AppDomain.CurrentDomain.UnhandledException += (_, args) =>
                {
                    if (args.ExceptionObject is Exception ex)
                    {
                        MessageBox.Show(
                            $"Unexpected application error: {ex.Message}",
                            "Application Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
                };

                var app = new App();
                app.InitializeComponent();
                app.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"The application could not start: {ex.Message}",
                    "Startup Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                Environment.Exit(1);
            }
        }
    }
}

// Meta date: 2026-10-12
