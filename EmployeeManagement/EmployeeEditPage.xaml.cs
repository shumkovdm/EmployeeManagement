using EmployeeManagement;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeManagement
{
    public partial class EmployeeEditPage : Page
    {
        private Employee employee;

        public EmployeeEditPage(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            NameTextBox.Text = employee.Name;
            PositionTextBox.Text = employee.Position;
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            employee.Name = NameTextBox.Text;
            employee.Position = PositionTextBox.Text;
            MessageBox.Show("Изменения сохранены!");
            NavigationService.GoBack();
        }
    }
}