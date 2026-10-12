using System.Windows;

namespace PassLogin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                StatusMessage.Text = "❌ Username and password are required.";
                return;
            }

            // TODO: Implement secure password validation
            // For now, just a demo message
            if (ValidateCredentials(username, password))
            {
                StatusMessage.Text = "✅ Login successful!";
                MessageBox.Show($"Welcome, {username}!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Here you would open the main application window
            }
            else
            {
                StatusMessage.Text = "❌ Invalid credentials.";
            }
        }

        private void QRButton_Click(object sender, RoutedEventArgs e)
        {
            StatusMessage.Text = "📱 QR code sign-in not yet implemented.";
            MessageBox.Show("QR code authentication feature coming soon!", "Feature", MessageBoxButton.OK, MessageBoxImage.Information);
            // TODO: Implement QR code scanner
        }

        private void CameraButton_Click(object sender, RoutedEventArgs e)
        {
            StatusMessage.Text = "📷 Camera recognition not yet implemented.";
            MessageBox.Show("Camera-based recognition feature coming soon!", "Feature", MessageBoxButton.OK, MessageBoxImage.Information);
            // TODO: Implement camera/face recognition
        }

        private bool ValidateCredentials(string username, string password)
        {
            // TODO: Replace with actual secure authentication
            // This is a placeholder - implement proper password hashing (e.g., bcrypt, PBKDF2)
            return username == "admin" && password == "password123";
        }
    }
}
