using ConsoleClient.CalculatorServiceReferenceConsole;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static private CalculatorClient serviceReference = new CalculatorServiceReferenceConsole.CalculatorClient();
        static private int userOperation;
        static private ComplexNumber complexNumber_1;
        static private ComplexNumber complexNumber_2;


        static async Task Main(string[] args)
        {
            do
            {
                Menu();
                userOperation = int.Parse(Console.ReadLine().ToString());
                try
                {
                    switch (userOperation)
                    {
                        case 1:
                            await Add();
                            break;

                        case 2:
                            await Substract();
                            break;

                        case 3:
                            await Multiply();
                            break;

                        case 4:
                            await Divade();
                            break;
                    }

                }
                catch(FaultException<CalculatorServiceReferenceConsole.DetailedException> ex)
                {
                    ExceptionMessageHandling(ex);
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

        static private async Task Add()
        {
            GetComplex();
            var result = await serviceReference.AddAsync(complexNumber_1, complexNumber_2);
            var userOutput = CreateUserOutput(result);

            Console.WriteLine($"\t\nOperation of ({CreateUserOutput(complexNumber_1)}) + ({CreateUserOutput(complexNumber_2)}) = {userOutput}");
        }

        static private async Task Substract()
        {
            GetComplex();
            var result = await serviceReference.SubstractAsync(complexNumber_1, complexNumber_2);
            var userOutput = CreateUserOutput(result);

            Console.WriteLine($"\t\nOperation of ({CreateUserOutput(complexNumber_1)}) - ({CreateUserOutput(complexNumber_2)}) = {userOutput}");
        }

        static private async Task Multiply()
        {
            GetComplex();
            var result = await serviceReference.MultiplyAsync(complexNumber_1, complexNumber_2);
            var userOutput = CreateUserOutput(result);

            Console.WriteLine($"\t\nOperation of ({CreateUserOutput(complexNumber_1)}) * ({CreateUserOutput(complexNumber_2)}) = {userOutput}");
        }

        static private async Task Divade() 
        {
            GetComplex();
            var result = await serviceReference.DivadeAsync(complexNumber_1, complexNumber_2);
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

        private static void ExceptionMessageHandling (FaultException<CalculatorServiceReferenceConsole.DetailedException> ex)
        {
            Console.WriteLine("\n\tAn error occured during selected operation!");
            Console.WriteLine($"\tMessage: {ex.Detail.Message}");
            Console.WriteLine($"\tDetails: "
                + $"{ex.Detail.Details}");
            Console.WriteLine($"\tTime: {ex.Detail.Date}");
        }
    }
}
