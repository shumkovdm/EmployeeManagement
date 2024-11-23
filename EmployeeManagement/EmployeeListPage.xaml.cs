using EmployeeManagement;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeManagement
{
    public partial class EmployeeListPage : Page
    {
        private List<Employee> employees;

        public EmployeeListPage()
        {
            InitializeComponent();
            employees = new List<Employee>
            {
                new Employee { Name = "Айвон Петросов", Position = "Менеджер" },
                new Employee { Name = "Вова Адидас", Position = "Разработчик" },
                new Employee { Name = "Антон Найк", Position = "Дизайнер" }
            };
            EmployeeDataGrid.ItemsSource = employees;
        }

        private void EditEmployee(object sender, RoutedEventArgs e)
        {
            if (EmployeeDataGrid.SelectedItem is Employee selectedEmployee)
            {
                NavigationService.Navigate(new EmployeeEditPage(selectedEmployee));
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника.");
            }
        }
    }
}
