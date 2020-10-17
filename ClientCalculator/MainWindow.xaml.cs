using ClientCalculator.CalculatorServiceReference;
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

namespace ClientCalculator
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
        private void btn_click_1(object sender, RoutedEventArgs e)
        {
            var calculatorService = new CalculatorServiceReference.CalculatorClient();

            var complex_1 = new ComplexNumber
            {
                Real = double.Parse(textComplex_1_real.Text),
                Imaginary = double.Parse(textComplex_1_imaginary.Text)
            };

            var complex_2 = new ComplexNumber
            {
                Real = double.Parse(textComplex_2_real.Text),
                Imaginary = double.Parse(textComplex_2_imaginary.Text)
            };

            var result = calculatorService.Add(complex_1, complex_2);
        }

        private void btn_click_2(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_3(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_4(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_5(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_6(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_7(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_8(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_9(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_dot(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_zero(object sender, RoutedEventArgs e)
        {

        }

        // Operations
        private void btn_click_result(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_clear(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_add(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_substract(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_multiply(object sender, RoutedEventArgs e)
        {

        }
        private void btn_click_divade(object sender, RoutedEventArgs e)
        {

        }
    }
}
