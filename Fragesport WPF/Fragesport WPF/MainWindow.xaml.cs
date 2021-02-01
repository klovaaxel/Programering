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
            PrintQ();

        }

        private void CheckQuestion_Click(object sender, RoutedEventArgs e)
        {
            Button knapp = (Button)sender;
            String answer = AnswerBox.Text;
            if (knapp.DataContext != null)
            {
                answer = knapp.DataContext.ToString();
            }
            else 
            {
                answer = AnswerBox.Text;
            }
            if (fragesport.CheckAnswer(answer, question, score))
            {
                //"You Guessed correctly!!"
                QuestionBox.Text = "You Guessed correctly!!";
                ScoreBox.Text = "Score: " + Convert.ToString(score.GetScore()) + " / " + Convert.ToString(score.GetMaxScore());
            }
            else 
            {
                //"You Guessed incorrectly!!"
                QuestionBox.Text = " You Guessed incorrectly!! The correct asnwer was '" + fragesport.GetAnswer(question) + "'";
            }
            altStack.Children.Clear();
            AnswerBox.Text = "";
        }

        private void PreviousQuestion_Click(object sender, RoutedEventArgs e)
        {
            question = fragesport.GetPrevQuestion();
            if (question != null)
            {
                QuestionBox.Text = question.GetQuestionText();
                altStack.Children.Clear();
                //answerStack.Children.Clear();
                CheckStack.Children.Clear();
                answerStack.Visibility = Visibility.Hidden;

                if (question.GetChoice() != null)
                {
                    int altNum = 1;
                    QuestionBox.Text += "\n";
                    foreach (var alt in question.GetChoice())
                    {
                        Button button = new Button() { Content = alt, DataContext = Convert.ToString(altNum) };
                        button.Click += new RoutedEventHandler(CheckQuestion_Click);
                        altStack.Children.Add(button);
                        altNum++;
                    }
                }
                else 
                {
                    //answerStack.Children.Add(new TextBlock() { Text = "Answer Box" });
                    //answerStack.Children.Add(new TextBox() { Name = "AnswerBox", Width = 200 });
                    answerStack.Visibility = Visibility.Visible;

                    Button button = new Button() { Name = "CheckQuestion", Content = "Check Question" };
                    button.Click += new RoutedEventHandler(CheckQuestion_Click);
                    CheckStack.Children.Add(button);
                }
            }
        }

        private void NextQuestion_Click(object sender, RoutedEventArgs e)
        {
            PrintQ();
        }

        private void PrintQ() 
        {
            question = fragesport.GetNextQuestion();
            
            if (question != null)
            {
                QuestionBox.Text = question.GetQuestionText();
                altStack.Children.Clear();
                //answerStack.Children.Clear();
                CheckStack.Children.Clear();
                answerStack.Visibility = Visibility.Hidden;


                if (question.GetChoice() != null)
                {
                    int altNum = 1;
                    QuestionBox.Text += "\n";
                    foreach (var alt in question.GetChoice())
                    {
                        Button button = new Button() { Content = alt, DataContext = Convert.ToString(altNum) };
                        button.Click += new RoutedEventHandler(CheckQuestion_Click);
                        altStack.Children.Add(button);
                        altNum++;
                    }
                }
                else
                {
                    //answerStack.Children.Add(new TextBlock() { Text = "Answer Box" });
                    //answerStack.Children.Add(new TextBox() { Name = "AnswerBox", Width = 200  });
                    answerStack.Visibility = Visibility.Visible; //THIS HERE
                    Button button = new Button() { Name = "CheckQuestion", Content = "Check Question" };
                    button.Click += new RoutedEventHandler(CheckQuestion_Click);
                    CheckStack.Children.Add(button);
                }
            }
            else
            {
                QuestionBox.Text = "you have compleated the quiz and got the score " + Convert.ToString(score.GetScore()) + " / " + Convert.ToString(score.GetMaxScore());
            }
        }

        private void AnswerBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private async void Admin_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow appWindow = await AdminWindow.TryCreateAsync();
        }
    }
}
