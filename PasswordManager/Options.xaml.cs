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
        public Database database;
        public Options(Database database)
        {
            this.database = database;
            InitializeComponent();
            getFolders();
        }

        private void Btn_MainMenu_Click(object sender, RoutedEventArgs e)
        {
            if(this.database != null)
            {
                frame.NavigationService.Navigate(new MainPage_(this.database));
            }
            frame.NavigationService.Navigate(new MainPage_());
        }

        private void Btn_AddFirstFolder_Click(object sender, RoutedEventArgs e)
        {
            AddFolderToDatabase();
            getFolders();
        }

        private void Btn_AddSecondFolder_Click(Object sender, RoutedEventArgs e)
        {
            AddFolderToDatabase();
            getFolders();
        }

        private void Btn_AddThirdFolder_Click(Object sender, RoutedEventArgs e)
        {
            AddFolderToDatabase();
            getFolders();
        }

        private void Btn_AddFourthFolder_Click(Object sender, RoutedEventArgs e)
        {
            AddFolderToDatabase();
            getFolders();
        }

        private void Btn_AddFifthFolder_Click(Object sender, RoutedEventArgs e)
        {
            AddFolderToDatabase();
            getFolders();
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

        private void Button_SelcectPath_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if(database != null)
            {
                this.database.path = saveFileDialog.FileName;
            }
            else
            {
                this.database = new(saveFileDialog.FileName);
            }
        }

        private void Btn_FirstFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
        }

        private void Btn_SecondFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
        }

        private void Btn_ThirdFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
        }

        private void Btn_FourthFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
        }

        private void Btn_FifthFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
        }

        public void getFolders()
        {
            if (database != null)
            {
                if (database.folders.Count == 1)
                {
                    resetFolderView();
                    Btn_AddFirstFolder.Visibility = Visibility.Hidden;
                    Btn_FirstFolder.Visibility = Visibility.Visible;
                    Btn_AddSecondFolder.Visibility = Visibility.Visible;
                }
                else if (database.folders.Count == 2)
                {
                    resetFolderView();
                    Btn_AddFirstFolder.Visibility = Visibility.Hidden;
                    Btn_FirstFolder.Visibility = Visibility.Visible;
                    Btn_SecondFolder.Visibility = Visibility.Visible;
                    Btn_AddThirdFolder.Visibility = Visibility.Visible;

                }
                else if (database.folders.Count == 3)
                {
                    resetFolderView();
                    Btn_AddFirstFolder.Visibility = Visibility.Hidden;
                    Btn_FirstFolder.Visibility = Visibility.Visible;
                    Btn_SecondFolder.Visibility = Visibility.Visible;
                    Btn_ThirdFolder.Visibility = Visibility.Visible;
                    Btn_AddFourthFolder.Visibility = Visibility.Visible;

                }
                else if (database.folders.Count == 4)
                {
                    resetFolderView();
                    Btn_AddFirstFolder.Visibility = Visibility.Hidden;
                    Btn_FirstFolder.Visibility = Visibility.Visible;
                    Btn_SecondFolder.Visibility = Visibility.Visible;
                    Btn_ThirdFolder.Visibility = Visibility.Visible;
                    Btn_FourthFolder.Visibility = Visibility.Visible;
                    Btn_AddFifthFolder.Visibility = Visibility.Visible;

                }
                else if (database.folders.Count == 5)
                {
                    resetFolderView();
                    Btn_AddFirstFolder.Visibility = Visibility.Hidden;
                    Btn_FirstFolder.Visibility = Visibility.Visible;
                    Btn_SecondFolder.Visibility = Visibility.Visible;
                    Btn_ThirdFolder.Visibility = Visibility.Visible;
                    Btn_FourthFolder.Visibility = Visibility.Visible;
                    Btn_FifthFolder.Visibility = Visibility.Visible;

                }
            }
        }

        public void resetFolderView()
        {
            Btn_FirstFolder.Visibility = Visibility.Hidden;
            Btn_SecondFolder.Visibility = Visibility.Hidden;
            Btn_ThirdFolder.Visibility = Visibility.Hidden;
            Btn_FourthFolder.Visibility = Visibility.Hidden;
            Btn_FifthFolder.Visibility = Visibility.Hidden;
            Btn_AddFirstFolder.Visibility = Visibility.Visible;
            Btn_AddSecondFolder.Visibility = Visibility.Hidden;
            Btn_AddThirdFolder.Visibility = Visibility.Hidden;
            Btn_AddFourthFolder.Visibility = Visibility.Hidden;
            Btn_AddFifthFolder.Visibility = Visibility.Hidden;
        }
    }
}
