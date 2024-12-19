using System.Windows;

namespace hw
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loginButton.Click += login_click;
            cancelButton.Click += cancel_click;
        }
        
        private void login_click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordBox.Password.Trim();
            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Ready.", "Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            
            MessageBox.Show("Ready.", "Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        
        private void cancel_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}