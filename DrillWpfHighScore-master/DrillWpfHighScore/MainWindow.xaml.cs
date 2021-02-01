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

namespace DrillWpfHighScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // lista med poäng
        private List<Result> scores = new List<Result>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveScore_Click(object sender, RoutedEventArgs e)
        {
            // spara resultat i listan scores
            scores.Add(new Result(PlayerName.Text, Convert.ToInt32(Score.Text)));
            // sortera listan
            scores.Sort();

            HighScores.Text = "";
            for (int i = 0; i < 5; i++)
            {
                if (i < scores.Count())
                {
                    HighScores.Text += "Score: " + scores[i].Score + "  " + "Name: " + scores[i].Name + Environment.NewLine;
                }
            }

            // skriv ut top 5 som 
            // 1. Ada 1060
            // 2. Beda 980
            // ...
            // 5. ...

        }
    }
}
