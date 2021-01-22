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
    /// Interaction logic for AddTowerDialogBox.xaml
    /// </summary>
    public partial class AddTowerDialogBox : Window
    {
        // tower to be added to database
        private string nameOfTower;
        private int heightOfTower;
        private string resultMessage = "";
        public AddTowerDialogBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Message is set if name och height is invalid.
        /// </summary>
        public string ResultMessage
        {
            get
            {
                return resultMessage;
            }
        }
        public string NameOfTower
        {
            get
            {
                return nameOfTower;
            }           
        }
        public int HeightOfTower
        {
            get
            {
                return heightOfTower;
            }           
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // read name - validate at least one character
            // read height - validate is number
            // save in field tower
            string text = NameBox.Text;
            // remove leading och trailing white space
            text = text.Trim();
            // at least one character
            if (text.Length > 0)
            {
                nameOfTower = text;
            }
            else
            {
                resultMessage = "Name of tower must contain at least one character.";
                // side effect: 
                // dialog closes
                this.DialogResult = false;
                return;
            }

            // check if height is integer
            if (int.TryParse(HeightBox.Text, out int height))
            {
                // ok
                if (height > 0)
                {
                    //ok
                    heightOfTower = height;
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
