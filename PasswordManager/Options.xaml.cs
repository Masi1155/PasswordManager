using Microsoft.Win32;
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
    /// Interaktionslogik für Options.xaml
    /// </summary>
    public partial class Options : Page
    {
        private Database database;
        public Options()
        {
            InitializeComponent();
        }

        private void Btn_MainMenu_Click(object sender, RoutedEventArgs e)
        {
            if (frame.NavigationService.CanGoBack)
            {
                frame.NavigationService.GoBack();
            }
            else
            {
                frame.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }

        private void Btn_AddFirstFolder_Click(object sender, RoutedEventArgs e)
        {
            Btn_AddFirstFolder.Visibility = Visibility.Hidden;
            Btn_FirstFolder.Visibility = Visibility.Visible;
            Btn_AddSecondFolder.Visibility = Visibility.Visible;
            AddFolderToDatabase();
        }

        private void Btn_AddSecondFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddSecondFolder.Visibility = Visibility.Hidden;
            Btn_SecondFolder.Visibility = Visibility.Visible;
            Btn_AddThirdFolder.Visibility = Visibility.Visible;
            AddFolderToDatabase();
        }

        private void Btn_AddThirdFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddThirdFolder.Visibility = Visibility.Hidden;
            Btn_ThirdFolder.Visibility = Visibility.Visible;
            Btn_AddFourthFolder.Visibility = Visibility.Visible;
            AddFolderToDatabase();
        }

        private void Btn_AddFourthFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddFourthFolder.Visibility = Visibility.Hidden;
            Btn_FourthFolder.Visibility = Visibility.Visible;
            Btn_AddFifthFolder.Visibility = Visibility.Visible;
            AddFolderToDatabase();
        }

        private void Btn_AddFifthFolder_Click(Object sender, RoutedEventArgs e)
        {
            Btn_AddFifthFolder.Visibility = Visibility.Hidden;
            Btn_FifthFolder.Visibility = Visibility.Visible;
            AddFolderToDatabase();
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
    }
}
