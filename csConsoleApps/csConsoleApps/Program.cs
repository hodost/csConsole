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

/*
namespace Tombok
{
class Program
{
    static void Main()
    {
        var numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);

        decimal temp = 20.4m;
        string s = String.Format ("The temperature is {0}°C.", temp);
        Console.WriteLine(s);

        var nbr = new int[3] { 4, 5, 6 };
        string list = string.Join(", ", nbr);
        Console.WriteLine(list);

        var firstName = "Kukorica";
        var lastName = "János";

        var fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);

        var myFullName = string.Format("Az én nevem {0} {1}", firstName, lastName);
        Console.WriteLine(myFullName);

    }
}
}
*/
/*
namespace Felsorolas
{
    public enum ShippingMethod
    {
        Regular,
        Registered,
        Express
    }

    class Pogram
    {
        static void Main()
        
            var method = ShippingMethod.Express;
            Console.WriteLine(method);

            var methodId = 1;
            Console.WriteLine((ShippingMethod)methodId);
            */

/*
namespace palindromecheck
{
class Program
{
    static void Main(string[] args)
    {

        string string1, rev;
        string1 = "asasasa";
        char[] ch = string1.ToCharArray();

        Array.Reverse(ch);
        rev = new string(ch);

        bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
        if (b == true)
        {
            Console.WriteLine("" + string1 + " is a Palindrome!");
        }
        else
        {
            Console.WriteLine(" " + string1 + " is not a Palindrome!");
        }
        Console.Read();
    }
}
}
*/
/*
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a = {0}, b = {1}", a,b));

            Console.WriteLine();

            var tomb1 = new int[3] { 1, 2, 3 };
            var tomb2 = tomb1;
            Console.WriteLine(string.Format("tomb1 1. eleme: {0}", tomb1[0]));
            tomb2[0] = 0;
            Console.WriteLine(string.Format("tomb1 1. eleme: {0}", tomb1[0]));
        }
    }
}
*/

namespace Valamimas
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
   
        static void Main()
        {
            var number = 1;
            Console.WriteLine("Main-en belüli number: {0}", number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine("person.Age: {0}", person.Age);
        }

        public static void Increment(int number)
        {
            number = 2;
            number += 10;
            Console.WriteLine(number);
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}