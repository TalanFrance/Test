﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using GitWpfApplication.Sources;

namespace GitWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorVM calculator;
        public MainWindow()
        {
            calculator = new CalculatorVM();
            this.DataContext = calculator;
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[1-9][0-9]*");
            e.Handled = !regex.IsMatch(e.Text);
        }

        private void btnCalculer_Click(object sender, RoutedEventArgs e)
        {
            calculator.Multiplier();
        }
    }
}
