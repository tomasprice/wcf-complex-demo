using ConsoleClient.CalculatorServiceReferenceConsole;
using System;

namespace ConsoleClient
{
    class Program
    {
        static private CalculatorClient serviceReference = new CalculatorServiceReferenceConsole.CalculatorClient();
        static private int userOperation;
        static private ComplexNumber complexNumber_1;
        static private ComplexNumber complexNumber_2;


        static void Main(string[] args)
        {
            do
            {
                Menu();
                userOperation = int.Parse(Console.ReadLine().ToString());

                switch (userOperation)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Substract();
                        break;

                    case 3:
                        Multiply();
                        break;

                    case 4:
                        Divade();
                        break;

                }
                Console.ReadLine();
                Console.Clear();

            } while (userOperation != 6);
        }

        static private void Menu()
        {
            Console.WriteLine("******** Complex Calculator ********");
            Console.WriteLine("\n\n");
            Console.WriteLine("Select operation from bellow menu.");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divade");
            Console.WriteLine("6. Exit");
            Console.Write("\nWhat should I do?: ");
        }

        static private void Add()
        {
            GetComplex();
            var result = serviceReference.Add(complexNumber_1, complexNumber_2);
            var userOutput = CreateUserOutput(result);

            Console.WriteLine($"\t\nOperation of ({CreateUserOutput(complexNumber_1)}) + ({CreateUserOutput(complexNumber_2)}) = {userOutput}");
        }

        static private void Substract()
        {
            GetComplex();
            var result = serviceReference.Substract(complexNumber_1, complexNumber_2);
            var userOutput = CreateUserOutput(result);

            Console.WriteLine($"\t\nOperation of ({CreateUserOutput(complexNumber_1)}) - ({CreateUserOutput(complexNumber_2)}) = {userOutput}");
        }

        static private void Multiply()
        {
            GetComplex();
            var result = serviceReference.Multiply(complexNumber_1, complexNumber_2);
            var userOutput = CreateUserOutput(result);

            Console.WriteLine($"\t\nOperation of ({CreateUserOutput(complexNumber_1)}) * ({CreateUserOutput(complexNumber_2)}) = {userOutput}");
        }

        static private void Divade() 
        {
            GetComplex();
            var result = serviceReference.Divade(complexNumber_1, complexNumber_2);
            var userOutput = CreateUserOutput(result);

            Console.WriteLine($"\t\nOperation of ({CreateUserOutput(complexNumber_1)}) / ({CreateUserOutput(complexNumber_2)}) = {userOutput}");
        }

        static private void GetComplex()
        {
            double real;
            double imaginary;

            Console.Clear();
            Console.WriteLine("Type your numbers...\n");

            Console.WriteLine("\tComplex 1");
            Console.Write("\t\tReal: ");
            real = double.Parse(Console.ReadLine());

            Console.Write("\t\tImaginary: ");
            imaginary = double.Parse(Console.ReadLine());

            complexNumber_1 = new ComplexNumber
            {
                Real = real,
                Imaginary = imaginary
            };

            Console.WriteLine("\tComplex 2");
            Console.Write("\t\tReal: ");
            real = double.Parse(Console.ReadLine());

            Console.Write("\t\tImaginary: ");
            imaginary = double.Parse(Console.ReadLine());

            complexNumber_2 = new ComplexNumber
            {
                Real = real,
                Imaginary = imaginary
            };
        }

        private static string CreateUserOutput(ComplexNumber complexNumber)
        {
            if (complexNumber.Imaginary > 0)
            {
                return $"{complexNumber.Real} + {complexNumber.Imaginary}i";
            }
            complexNumber.Imaginary *= -1;
            return $"{complexNumber.Real} - {complexNumber.Imaginary}i";
        }
    }
}
