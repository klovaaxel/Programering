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
using Fragesport_File;

namespace Fragesport_WPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EditQuestion : Window
    {
        string questionID;
        QuestionCard selectedQuestion;
        Program program;

        public EditQuestion(Program program)
        {
            InitializeComponent();

            this.program = program;

            foreach (QuestionCard question in program.questions)
            {
                System.Windows.Controls.Button newBtn = new Button();

                newBtn.Content = question.Question;
                newBtn.Name = question.Id;
                newBtn.Click += ChooseQuestion_Click;

                QuestionList.Children.Add(newBtn);
            }

           
        }

        private void UpdateEditForm() 
        {
            selectedQuestion = program.GetQuestions(Convert.ToInt32(questionID));

            QuestionBox.Text = selectedQuestion.Question;
            AnswerBox.Text = selectedQuestion.Answer;
        }
        

        private void SaveEdit_Click(object sender, RoutedEventArgs e)
        {
            selectedQuestion.Question = QuestionBox.Text;
            selectedQuestion.Answer = AnswerBox.Text;

            program.EditQuestion(selectedQuestion);
        }
        private void ChooseQuestion_Click(object sender, RoutedEventArgs e)
        {
            questionID = (sender as Button).Name;
            UpdateEditForm();
        }
    }
}
