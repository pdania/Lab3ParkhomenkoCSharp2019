﻿using System.Windows;
using Lab3ParkhomenkoCSharp2019.ViewModels;

namespace Lab3ParkhomenkoCSharp2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
