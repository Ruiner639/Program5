using System;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();//First number
            Int32.TryParse(number1, out int n1);
            if ((n1>=10) && (n1<= 20)) {
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number2 = Console.ReadLine();//I believe that a loop could be used here, and then the code would be shorter
            Int32.TryParse(number2, out int n2);
            int sum = n1 + n2;
            if ((n2 >= 10) && (n2 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number3 = Console.ReadLine();
            Int32.TryParse(number3, out int n3);
            sum = sum + n3;
            if ((n3 >= 10) && (n3 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number4 = Console.ReadLine();
            Int32.TryParse(number4, out int n4);
            sum = sum + n4;
            if ((n4 >= 10) && (n4 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number5 = Console.ReadLine();
            Int32.TryParse(number5, out int n5);
            sum = sum + n5;
            if ((n5 >= 10) && (n5 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number6 = Console.ReadLine();
            Int32.TryParse(number6, out int n6);
            sum = sum + n6;
            if ((n6 >= 10) && (n6 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
           
            string number7 = Console.ReadLine();
            Int32.TryParse(number7, out int n7);
            sum = sum + n7;
            if ((n7 >= 10) && (n7 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number8 = Console.ReadLine();
            Int32.TryParse(number8, out int n8);
            sum = sum + n8;
            if ((n8 >= 10) && (n8 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number9 = Console.ReadLine();
            Int32.TryParse(number9, out int n9);
            sum = sum + n9;
            if ((n9 >= 10) && (n9 <= 20))
            {
                Console.WriteLine("Sum of numbers at the moment: " + sum);
                Console.WriteLine("Enter the next number: ");
            }
            else
            {
                return;
            }
            string number10 = Console.ReadLine();
            Int32.TryParse(number5, out int n10);
            sum = sum + n10;
            if ((n10 >= 10) && (n10 <= 20))
            {
                Console.WriteLine("Sum of numbers: " + sum);
            
            }
            else
            {
                return;
            }


            Console.WriteLine(number1);
        }
    }
}
