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
            results.Add(new Result(NameOfRunner.Text, Time.Text, Distance.Text ));

            // example: how to convert a string to a double
            String decimalNumberAsText = "3.14";
            double number = Convert.ToDouble(decimalNumberAsText);

            // example: how to convert a string to an int
            String integerAsText = "12";
            int number2 = Convert.ToInt32(integerAsText);
        }
    }
}
