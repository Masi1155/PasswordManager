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
using static System.Net.Mime.MediaTypeNames;

namespace PasswordManager
{
    /// <summary>
    /// Interaktionslogik für PasswordFolder.xaml
    /// </summary>
    public partial class PasswordFolder : Page
    {
        private Database database;
        private int currentfolder;
        public PasswordFolder(Database database)
        {
            InitializeComponent();
            this.database = database;
            getFolders();
        }

        private void Btn_MainMenu_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new MainPage_(this.database));
        }

        private void Btn_Options_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Options(this.database));
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

        private void Btn_FirstFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
            this.currentfolder = 1;
        }

        private void Btn_SecondFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
            this.currentfolder = 2;
        }

        private void Btn_ThirdFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
            this.currentfolder = 3;
        }

        private void Btn_FourthFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
            this.currentfolder = 4;
        }

        private void Btn_FifthFolder_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PasswordFolder(this.database));
            this.currentfolder = 5;
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

        private void Btn_Copy_Row1_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(1), true);
        }

        private void Btn_Copy_Row2_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(2), true);
        }

        private void Btn_Copy_Row3_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(3), true);
        }

        private void Btn_Copy_Row4_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(4), true);
        }

        private void Btn_Copy_Row5_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(5), true);
        }

        private void Btn_Copy_Row6_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(6), true);
        }

        private void Btn_Copy_Row7_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(7), true);
        }

        private void Btn_Copy_Row8_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(Copy_Click(8), true);
        }

        private String Copy_Click(int buttonnum)
        {
            return this.database.folders[currentfolder].entries[buttonnum].getPassword();
        }

        private void Btn_OpenPwDb_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

