using System;
using CSharpFundamentals.Math;

/* Write a C# Sharp program to swap two numbers.
// Test Data:
// Input the First Number : 5
// Input the Second Number : 6
// Expected Output: 
// After Swapping :
// First Number : 6 
// Second Number : 5

public class Exercise5
{
    public static void Main(string[] args)
    {
        int num1, num2, tmp;

        Console.Write("Kérem az első számot: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kérem a második számot: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        tmp = num1;
        num1 = num2;
        num2 = tmp;
        Console.WriteLine();
        Console.WriteLine("Felcserélés után az első szám: {0}", num1);
        Console.WriteLine("Felcserélés után az második szám: {0}", num2);
        Console.ReadKey();
    }
}
*/

/* Write a C# Sharp program to print on screen the output of + - * /, of two numbers which will be entered by the user.

public class Exercise7
{
    public static void Main()
    {
        int nbr, multi;
        Console.Write("Adj meg egy számot: ");
        nbr = Convert.ToInt32(Console.ReadLine());

        Console.Write("Adj meg egy másik számot: ");
        multi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", nbr, multi, (nbr + multi));
        Console.WriteLine("{0} - {1} = {2}", nbr, multi, (nbr - multi));
        Console.WriteLine("{0} * {1} = {2}", nbr, multi, (nbr * multi));
        Console.WriteLine("{0} / {1} = {2}", nbr, multi, (nbr / multi));
        Console.ReadKey();
    }
}
*/

/* Kérj be egy szöveget, és alakítsd nagybetűssé
public class Exercise23
{
    public static void Main()
    {
        Console.Write("Írj be egy szöveget: ");
        string line = Console.ReadLine();
        Console.WriteLine(line.ToUpper());
        Console.ReadKey();
    }
}
*/

/* Variables
namespace Variables

{
    class Program
    {
        static void Main(string[] args)
        {
            // byte number = 2;
            // int count = 10;
            // float totalPrice = 20.95f;
            // char character = 'A';
            // string firstName = "Tomi";
            // bool isWorking = false;

            // int i = 1000;
            // byte b = (byte)i;
            // Console.WriteLine(b);

            try
            {
                var number = "1234";
                byte a = Convert.ToByte(number);

                Console.WriteLine(a);
            }
            catch (Exception)
            {
                Console.WriteLine("A szám nem alakítható byte-tá.");
            }

            
        }
    }
}
*/

/* Operators
namespace Operators
{
    class Program
    {
        static void Main()
        {
            var a = 10;
            var b = 3;

            Console.WriteLine((double)a / (double)b);
        }
    }
}
*/

/* CSharpFundamentals
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            // Készítünk egy Person objektumot
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(2,3);
            Console.WriteLine(result);
        }
    }
}
*/

