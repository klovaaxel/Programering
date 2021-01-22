using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDemoTowerSql
{
    /// <summary>
    /// Interaction logic for EditTowerDialogBox.xaml
    /// </summary>
    public partial class EditTowerDialogBox : Window
    {
        private Tower tower;
        // TODO move field. Also in AddTowerDialogBox
        private string resultMessage = "";
        public EditTowerDialogBox(Tower tower)
        {
            InitializeComponent();
            this.tower = tower;

            // display name and height
            NameBox.Text = tower.Name;
            HeightBox.Text = tower.Height.ToString(); 

        }
        public string ResultMessage
        {
            get
            {
                return resultMessage;
            }
        }
        public Tower Tower
        {
            get
            {
                return tower;
            }
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // TODO Rewrite. Almost same code as in AddTowerDialogBox.

            // read name - validate at least one character
            // read height - validate is number
            // save in field tower
            string text = NameBox.Text;
            // remove leading och trailing white space
            text = text.Trim();
            // at least one character
            if (text.Length > 0)
            {
                tower.Name = text;
            }
            else
            {
                resultMessage = "Name of tower must contain at least one character.";
                // side effect: 
                // dialog closes
                this.DialogResult = false;
                return;
            }

            if (int.TryParse(HeightBox.Text, out int height))
            {
                // ok
                if (height > 0)
                {
                    //ok
                    tower.Height = height;
                }
                else
                {
                    resultMessage = "Height of tower must be greater than zero";
                    // side effect: 
                    // dialog closes
                    this.DialogResult = false;
                    return;
                }
                
            }
            else
            {
                resultMessage = "Height of tower must be a number";
                // side effect: 
                // dialog closes
                this.DialogResult = false;
                return;
            }

            // side effect: 
            // dialog closes
            this.DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // side effekt:
            // closes dialog
            this.DialogResult = false;
        }
    }
}
