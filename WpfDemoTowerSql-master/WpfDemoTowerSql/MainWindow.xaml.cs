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

namespace WpfDemoTowerSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DatabaseHandler databaseHandler;
        public MainWindow()
        {
            InitializeComponent();

            databaseHandler = new DatabaseHandler();

            // create database table
            databaseHandler.InitializeDatabase();
            Path.Text = databaseHandler.GetPathAndDbName();

            //databaseHandler.AddTower("Burj Khalifa", 830);

            ShowListOfTowers();
        }
        private void ShowListOfTowers()
        {
            List<Tower> towers = databaseHandler.GetTowers();
            ListOfTowers.ItemsSource = towers;
        }

        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            // dialog box
            // name: ___________
            // height: ___________
            // save or cancel

            AddTowerDialogBox dialogBox = new AddTowerDialogBox();

            // configure the dialog box
            dialogBox.Owner = this;

            // Open dialog box modally, 
            // that is have to finnish dialog before continuing with application.
            dialogBox.ShowDialog();

            if (dialogBox.DialogResult == true)
            {
                // add tower to database
                databaseHandler.AddTower(dialogBox.NameOfTower, dialogBox.HeightOfTower);

                ShowListOfTowers();
            }
            else
            {
                // failed
                // Message box to tell what went wrong
                // https://docs.microsoft.com/en-us/dotnet/desktop/wpf/app-development/dialog-boxes-overview?view=netframeworkdesktop-4.8
                
                string heading = "Adding tower failed";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBox.Show(dialogBox.ResultMessage, heading, button, icon);
            }



        }

        private void EditData_Click(object sender, RoutedEventArgs e)
        {
            // if tower selected
            // show dialog box
            // name ....
            // height ....
            // save or cancel
            // else - tell you have to select a tower
            Tower selectedTower = (Tower)ListOfTowers.SelectedValue;
            if (selectedTower != null)
            {
                
                EditTowerDialogBox dialogBox;
                //pass the tower to the dialog box
                dialogBox = new EditTowerDialogBox(selectedTower);

                // configure the dialog box
                dialogBox.Owner = this;

                // Open dialog box modally, 
                // that is have to finnish dialog before continuing with application.
                dialogBox.ShowDialog();

                if (dialogBox.DialogResult == true)
                {
                    databaseHandler.EditTower(dialogBox.Tower);

                    ShowListOfTowers();
                }
                else 
                {
                    // failed
                    // Message box to tell what went wrong
                    // https://docs.microsoft.com/en-us/dotnet/desktop/wpf/app-development/dialog-boxes-overview?view=netframeworkdesktop-4.8

                    string heading = "Ëdit tower failed";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBox.Show(dialogBox.ResultMessage, heading, button, icon);
                }

            }
            else
            {
                // no tower selected
                string message = "No tower selected. Select a tower to edit.";
                string heading = "No tower selected";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBox.Show(message, heading, button, icon);
            }
        }

        private void DeleteData_Click(object sender, RoutedEventArgs e)
        {
            Tower selectedTower = (Tower)ListOfTowers.SelectedValue;
            // if tower selected
            // show confirm with name and height
            // confirm delete or cancel
            
            
            if (selectedTower != null)
            {
                // Message box to confirm or cancel deletion.
                // https://docs.microsoft.com/en-us/dotnet/desktop/wpf/app-development/dialog-boxes-overview?view=netframeworkdesktop-4.8
                string message = "Do delete tower." + Environment.NewLine +
                "Name: " + selectedTower.Name + Environment.NewLine +
                "Height: " + selectedTower.Height;
                string heading = "Do delete selected tower";
                MessageBoxButton button = MessageBoxButton.OKCancel;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(message, heading, button, icon);
                if (result == MessageBoxResult.OK)
                {
                    // do delete
                    databaseHandler.DeleteTower(selectedTower);

                    ShowListOfTowers();
                }
                // otherwise do nothing

                
            }
            else
            {
                // no tower selected
                string message = "No tower selected. Select a tower to edit.";
                string heading = "No tower selected";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBox.Show(message, heading, button, icon);
            }
        }

    }
}