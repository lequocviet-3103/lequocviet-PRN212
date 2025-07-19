using BusinessObjects_EF_IO;
using Services_EF_IO;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp_EF_IO
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            RestoreLoginInfomation();
        }

        private void RestoreLoginInfomation()
        {
            string file_log = "login_info.txt";
            if (File.Exists(file_log))
            {
                StreamReader sr = new StreamReader(file_log);
                string line = sr.ReadLine();
                //tách line thành 3 mảng phần tử
                //email;password,checked
                string [] arr = line.Split(';');
                if(arr.Length ==3 && arr[2]=="True")
                {
                    txtEmail.Text = arr[1];
                    txtPassword.Password = arr[1];
                    SaveLogin.IsChecked = true;
                }
            }
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Password;
                IAccountMemberService memberService = new AccountMemberService();
                AccountMember am = memberService.Login(email, password);
                if(am == null)
                {
                    MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra thông tin", "Đăng nhập thất bại",MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MainWindow mainWindow = new MainWindow(am);   
                    mainWindow.Show();
                    Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập, chi tiết: \n"+ ex.Message,
                    "Lỗi đăng nhập", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            

        }

        void SaveLoginInformation(AccountMember am, bool saved)
        {
            string data = am.EmailAddress + ";" + am.MemberPassword + "," + saved;
            string file_log = "login_info.txt";
            StreamWriter sw = new StreamWriter(file_log,false,Encoding.UTF8);
            sw.WriteLine(data);
            sw.Close();
            SaveLoginInformation(am, SaveLogin.IsChecked.Value);

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
