﻿using ComplexLibrary;
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

namespace les05wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewInterface
    {
        Adapter a;

        public MainWindow()
        {
            InitializeComponent();

            a = new Adapter(this);
        }

        public string Number1 => txt1.Text;

        public string Number2 => txt2.Text;

        public string OutputData { set => txtBlock.Text = value; }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            a.Sum();
        }
    }
}
