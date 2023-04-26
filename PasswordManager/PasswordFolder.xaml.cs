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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordManager
{
    /// <summary>
    /// Interaktionslogik für PasswordFolder.xaml
    /// </summary>
    public partial class PasswordFolder : Page
    {
        private Database database;
        public PasswordFolder()
        {
            InitializeComponent();
        }

        private void AddFolderToDatabase()
        {
            if (database != null)
            {
                database.AddFolder();
            }
            else
            {
                MessageBox.Show("Please select or create a database first.");
            }
        }

        private void Btn_Options_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Options());
        }

        private void Btn_AddFirstFolder_Click(object sender, RoutedEventArgs e)
        {
            Btn_AddFirstFolder.Visibility = Visibility.Hidden;
            Btn_FirstFolder.Visibility = Visibility.Visible;
            Btn_AddSecondFolder.Visibility = Visibility.Visible;
        }

        private void Btn_AddSecondFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddSecondFolder.Visibility = Visibility.Hidden;
            Btn_SecondFolder.Visibility = Visibility.Visible;
            Btn_AddThirdFolder.Visibility = Visibility.Visible;
        }

        private void Btn_AddThirdFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddThirdFolder.Visibility = Visibility.Hidden;
            Btn_ThirdFolder.Visibility = Visibility.Visible;
            Btn_AddFourthFolder.Visibility = Visibility.Visible;
        }

        private void Btn_AddFourthFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddFourthFolder.Visibility = Visibility.Hidden;
            Btn_FourthFolder.Visibility = Visibility.Visible;
            Btn_AddFifthFolder.Visibility = Visibility.Visible;
        }

        private void Btn_AddFifthFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddFifthFolder.Visibility = Visibility.Hidden;
            Btn_FifthFolder.Visibility = Visibility.Visible;
        }
    }
}

