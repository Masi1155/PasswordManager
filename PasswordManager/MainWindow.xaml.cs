﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordManager
{
    public partial class MainWindow : Window
    {
        private NavigationService navigationService;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Quit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Btn_Options_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Options());
        }
    }
}