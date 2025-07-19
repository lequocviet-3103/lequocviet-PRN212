﻿using BusinessObjects_EF_IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_EF_IO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AccountMember LoginInfo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(AccountMember am)
        {
            InitializeComponent();
            LoginInfo = am;
            nameLogin.Content = "Xin chào [" + LoginInfo.FullName + "]";
        }
    }
}