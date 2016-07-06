//Program: Video_Week_08
//Description: In-video instruction example -- Event Handling in WPF apps
//Name: Andy E. Wold
//Date: 05 Jul 2016
//Instructor: Brother Daniel Masterson
//Course: CS 176 - Windows Desktop Design

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

namespace Code_Example_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_MyOtherClick;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello World.";
        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            myOtherLabel.Content = "Hello again.";
        }

        private void dateLabel_Initialized(object sender, EventArgs e)
        {
            dateLabel.Content = DateTime.Today.Date;
        }
    }
}
