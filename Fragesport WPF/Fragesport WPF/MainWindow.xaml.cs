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
using Fragesport_File;

namespace Fragesport_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Program fragesport = new Program();
        QuestionCard question;
        Score score = new Score();
        public MainWindow()
        {
            InitializeComponent();
            fragesport.start();
            PrintNextQ();

        }

        private void CheckQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (fragesport.CheckAnswer(AnswerBox.Text, question, score))
            {
                //"You Guessed correctly!!"
                QuestionBox.Text = "You Guessed correctly!!";
                ScoreBox.Text = "Score: " + Convert.ToString(score.GetScore()) + " / " + Convert.ToString(score.GetMaxScore());
            }
            else 
            {
                //"You Guessed incorrectly!!"
                QuestionBox.Text = "You Guessed incorrectly!!";
            }
            AnswerBox.Text = "";
        }

        private void PreviousQuestion_Click(object sender, RoutedEventArgs e)
        {
            question = fragesport.GetPrevQuestion();
            if (question != null)
            {
                QuestionBox.Text = question.GetQuestionText();

                if (question.GetChoice() != null)
                {
                    int altNum = 1;
                    QuestionBox.Text += "\n";
                    foreach (var alt in question.GetChoice())
                    {
                        QuestionBox.Text += altNum + ". " + alt + "\n";
                        altNum++;
                    }
                }
            }
        }

        private void NextQuestion_Click(object sender, RoutedEventArgs e)
        {
            PrintNextQ();
        }

        private void PrintNextQ() 
        {
            question = fragesport.GetNextQuestion();
            
            if (question != null)
            {
                QuestionBox.Text = question.GetQuestionText();

                if (question.GetChoice() != null)
                {
                    int altNum = 1;
                    QuestionBox.Text += "\n";
                    foreach (var alt in question.GetChoice())
                    {
                        QuestionBox.Text += altNum + ". " + alt + "\n";
                        altNum++;
                    }
                }
            }
            else
            {
                QuestionBox.Text = "you have compleated the quiz and got the score " + Convert.ToString(score.GetScore()) + " / " + Convert.ToString(score.GetMaxScore());
            }
        }
    }
}
