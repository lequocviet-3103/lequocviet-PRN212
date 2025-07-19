using BusinessObjects;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LeQuocVietWPF
{
    /// <summary>
    /// Interaction logic for PersonalProfileWindow.xaml
    /// </summary>
    public partial class PersonalProfileWindow : Window
    {
        private readonly IEmployeeService iEmployeeService;
        private Employee emp;
        public PersonalProfileWindow()
        {
            InitializeComponent();
            iEmployeeService = new EmployeeService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProfile();
        }
        private void LoadProfile()
        {
            emp = Session.CurrentEmployee;
            if (emp != null)
            {
                emp = Session.CurrentEmployee;
                txtEmployeeId.Text = emp.EmployeeId.ToString();
                txtName.Text = emp.Name;
                txtUsername.Text = emp.UserName;
                txtPassword.Text = emp.Password;
                txtJob.Text = emp.JobTitle;
                txtBirth.SelectedDate = emp.BirthDate;
                txtHire.SelectedDate = emp.HireDate;
                txtAddress.Text = emp.Address;
            }
        }

       

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (emp == null)
            {
                MessageBox.Show("Employee data is not loaded.");
                return;
            }

            // Collect form data and update employee object
            emp.Name = txtName.Text;
            emp.UserName = txtUsername.Text;
            emp.Password = txtPassword.Text;
            emp.JobTitle = txtJob.Text;
            emp.BirthDate = txtBirth.SelectedDate;
            emp.HireDate = txtHire.SelectedDate;
            emp.Address = txtAddress.Text;

            iEmployeeService.updateEmployee(emp);

            Session.CurrentEmployee = emp;

            MessageBox.Show("Profile updated successfully.", "Update Profile", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
