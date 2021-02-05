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
    public partial class AddQuestion : Window
    {
        private Program program;
        public AddQuestion(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void AddQuestion_Click(object sender, RoutedEventArgs e)
        {
            program.AddTextQuestion(new QuestionText(QuestionBox.Text, AnswerBox.Text));

        }
    }
}
