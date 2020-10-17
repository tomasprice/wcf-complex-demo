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
        // Conect service
        private CalculatorClient calculatorService = new CalculatorServiceReference.CalculatorClient();
        private Helper helper = new Helper();
        
        // Sets active textbox for user buttons input
        private int currentTextboxIndex = 0;
        private string[] textBoxes =
        {
            "textComplex_1_real",
            "textComplex_1_imaginary",
            "textComplex_2_real",
            "textComplex_2_imaginary"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        // Calculator input numeric button
        private void btn_click_1(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 1;
        }

        private void btn_click_2(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 2;
        }
        private void btn_click_3(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 3;
        }
        private void btn_click_4(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 4;
        }
        private void btn_click_5(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 5;
        }
        private void btn_click_6(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 6;
        }
        private void btn_click_7(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 7;
        }
        private void btn_click_8(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 8;
        }
        private void btn_click_9(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 9;
        }
        private void btn_click_dot(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += ".";
        }
        private void btn_click_zero(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            textbox.Text += 0;
        }

        // Textboxes interaction
        // Set active textbox
        private void textComplex_1_real_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            currentTextboxIndex = 0;
        }

        private void textComplex_1_imaginary_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            currentTextboxIndex = 1;
        }

        private void textComplex_2_real_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            currentTextboxIndex = 2;
        }

        private void textComplex_2_imaginary_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            currentTextboxIndex = 3;
        }

        // Operations
        private void btn_click_negation(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)this.FindName(textBoxes[currentTextboxIndex]);
            var text = double.Parse(textbox.Text);
            textbox.Text = (text * (-1)).ToString();
        }

        private void btn_click_clear(object sender, RoutedEventArgs e)
        {
            textComplex_1_real.Clear();
            textComplex_1_imaginary.Clear();
            textComplex_2_real.Clear();
            textComplex_2_imaginary.Clear();
            textResult.Clear();
        }
        private void btn_click_add(object sender, RoutedEventArgs e)
        {
            var complex_1 = helper.GetComplex(textComplex_1_real.Text, textComplex_1_imaginary.Text);
            var complex_2 = helper.GetComplex(textComplex_2_real.Text, textComplex_2_imaginary.Text);

            var result = calculatorService.Add(complex_1, complex_2);

            textResult.Text = helper.CreateUserOutput(result);
        }
        private void btn_click_substract(object sender, RoutedEventArgs e)
        {
            var complex_1 = helper.GetComplex(textComplex_1_real.Text, textComplex_1_imaginary.Text);
            var complex_2 = helper.GetComplex(textComplex_2_real.Text, textComplex_2_imaginary.Text);

            var result = calculatorService.Substract(complex_1, complex_2);

            textResult.Text = helper.CreateUserOutput(result);
        }
        private void btn_click_multiply(object sender, RoutedEventArgs e)
        {
            var complex_1 = helper.GetComplex(textComplex_1_real.Text, textComplex_1_imaginary.Text);
            var complex_2 = helper.GetComplex(textComplex_2_real.Text, textComplex_2_imaginary.Text);

            var result = calculatorService.Multiply(complex_1, complex_2);

            textResult.Text = helper.CreateUserOutput(result);
        }
        private void btn_click_divade(object sender, RoutedEventArgs e)
        {
            var complex_1 = helper.GetComplex(textComplex_1_real.Text, textComplex_1_imaginary.Text);
            var complex_2 = helper.GetComplex(textComplex_2_real.Text, textComplex_2_imaginary.Text);

            var result = calculatorService.Divade(complex_1, complex_2);

            textResult.Text = helper.CreateUserOutput(result);
        }
     
    }
}
