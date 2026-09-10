using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace session02C_
{
    internal class Program
    {
        class Point
        {
            public int x1;
            public int y1;

        }
        
        static void Main(string[] args)
        {
            //1-Write a program that allows the user to enter a number then print it.
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);


            //2-Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string text = "123abc";
            //int number2 = Convert.ToInt32(text);
            //Console.WriteLine(number2);

            //Unhandled exception. System.FormatException: The input string '123abc' was not in a correct format.


            //3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            double X = 0.1;
            double Y = 0.2;
            double Sum = X + Y;
            Console.WriteLine("Sum = " + Sum);
            //Sum = 0.30000000000000004 مش متمثلة صح فالنظام الباينري


            //4-Write C# program that Extract a substring from a given string.
            string text2 = "Hello, welcome to C# programming!";
            string sub1 = text2.Substring(7, 7);
            Console.WriteLine(sub1);


            //5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int d = 10;
            int t= d;
            Console.WriteLine("d = " + d);
            Console.WriteLine("t = " + t);

            t = 20;
            Console.WriteLine("d = " + d);
            Console.WriteLine("t = " + t);

            //6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Point P1 = new Point();
            P1.x1= 10;
            P1.y1 = 20;

            Point P2 = P1; 
            P2.x1 = 100; 

            Console.WriteLine("P1.X = " + P1.x1);
            Console.WriteLine("P1.Y = " + P1.y1);
            Console.WriteLine("P2.X = " + P2.x1);
            Console.WriteLine("P2.Y = " + P2.y1);


            //7-Write C# program that take two string variables and print them as one variable 
            string firstName = "Doha";
            string lastName = "Mohamed";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //8-Which of the following statements is correct about the C#.NET code snippet given below?
            int e;
            e = Convert.ToInt32(!(30 < 20));//A value 1 will be assigned to d.


            //9-Which of the following is the correct output for the C# code given below?
            Console.WriteLine(13 / 2 + " " + 13 % 2);//6 1


            //10
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            // 7 7











        }
    }
}
