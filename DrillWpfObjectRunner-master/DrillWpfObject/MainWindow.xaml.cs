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

namespace DrillWpfObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Result> results = new List<Result>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // write code to save result in list named results
            results.Add(new Result(NameOfRunner.Text, Time.Text, Distance.Text));

            NameOfRunner.Text = "";
            Time.Text = "";
            Distance.Text = "";

        }

        private void ShowRunners_Click(object sender, RoutedEventArgs e)
        {
            ShowRunnersStack.Children.Clear();

            if (InputStack.Visibility == Visibility.Visible)
            {
                InputStack.Visibility = Visibility.Collapsed;

                foreach (Result runner in results)
                {
                    ShowRunnersStack.Children.Add(new TextBox() { Text = runner.ToString() });
                }
            }
            else 
            {
                InputStack.Visibility = Visibility.Visible;
            }
            
        }
    }
}
