using EmployeeManagement;
using System.Windows;
using System.Windows.Navigation;

namespace EmployeeManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage()); // Убедитесь, что HomePage корректно подключён
        }

        private void NavigateToHomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void NavigateToEmployeeListPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmployeeListPage());
        }
    }
}