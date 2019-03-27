using System;

namespace Conditionals
{
    /* if else
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Reggel van");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Délután van");
            }
            else
            {
                Console.WriteLine("Este van");
            }
        }
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            // a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            // applications where values entered into input boxes need to be validated.)
 
            Console.WriteLine("Adj meg egy számot 1 és 10 között: ");
                var input = Console.ReadLine();
                var number = Convert.ToInt32(input);

                if (number >= 1 && number <= 10)
                {
                    Console.WriteLine("Tökéletes.");
                }
                else
                {
                    Console.WriteLine("Legyen 1 és 10 között.");
                }
         */

            /*
                // Write a program which takes two numbers from the console and displays the maximum of the two.

                // Console.WriteLine("Adj meg két számot, megmondom melyik a nagyobb: ");
                // var input1 = Console.ReadLine();
                // var input2 = Console.ReadLine();
                // var number1 = Convert.ToInt32(input1);
                // var number2 = Convert.ToInt32(input2);

                Console.WriteLine("Add meg az első számot: ");
                var number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Köszönöm. Add meg a második számot is:");
                var number2 = Convert.ToInt32(Console.ReadLine());

                var max = (number1 > number2) ? number1 : number2;
                Console.WriteLine("A nagyobb szám: {0}", max);
                */
            /*
            // Write a program and ask the user to enter the width and height of an image. Then tell if the image
            // is landscape or portrait.

            Console.WriteLine("Add meg a kép szélességét: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a kép magasságát: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? ImageOrientation.landscape : ImageOrientation.portrait;
            Console.WriteLine("A kép {0}", orientation);
        }

           public enum ImageOrientation
            {
            portrait,
            landscape
            }
        */

            // Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors,
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            // the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            // display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            // demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            // the console. If the number of demerit points is above 12, the program should display License Suspended.

            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}