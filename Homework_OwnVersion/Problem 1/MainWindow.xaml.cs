﻿using System;
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

namespace Problem_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Correct!");

            System.Diagnostics.Process.Start("file:///C:/Users/riley/OneDrive/Desktop/3033%20950/OwnProblem.html");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Incorrect");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Incorrect");
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Incorrect");
        }
    }
}
