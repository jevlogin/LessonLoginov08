using ComplexLibrary;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Complex z1;
            var f = Complex.TryParse(txt1.Text, out z1);

            Complex z2;
            f &= Complex.TryParse(txt2.Text, out z2);

            if (f)
            {
                txtBlock.Text = Complex.SumComplex(z1, z2).ToString();
            }
        }
    }
}
