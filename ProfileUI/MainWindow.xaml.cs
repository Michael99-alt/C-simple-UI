using System.Windows;
using System.Windows.Media;

namespace ProfileUI
{
    public partial class MainWindow : Window
    {
        private bool isDarkTheme = false;
        private Brush originalGridBackground;

        public MainWindow()
        {
            InitializeComponent();
            originalGridBackground = MainGrid.Background;
            ThemeToggle.Click += ThemeToggle_Click;
        }

        private void ThemeToggle_Click(object sender, RoutedEventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            if (isDarkTheme)
            {
                ThemeToggle.Content = "☀️";
                MainGrid.Background = new SolidColorBrush(Color.FromRgb(30, 30, 30));
                ProfileBorder.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            }
            else
            {
                ThemeToggle.Content = "🌙";
                MainGrid.Background = originalGridBackground;
                ProfileBorder.Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}