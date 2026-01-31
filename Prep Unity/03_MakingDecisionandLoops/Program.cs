using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecisionandLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Enter the password: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "Trabzonspor")
            //{
            //    Console.WriteLine("Password is true");
            //}

            //else
            //{
            //    Console.WriteLine("Password is false");
            //}

            //string capital, country;
            //Console.Write("Enter the Country: ");
            //country = Console.ReadLine();
            //Console.Write("Enter the Capital: ");
            //capital = Console.ReadLine();



            //if (country == "türkiye" && /* ||*/ capital == "ankara")
            //{
            //    Console.Write("Match is true");
            //}
            //else { Console.WriteLine("Match is wrong"); }



            //int number;
            //number = int.Parse(Console.ReadLine());

            //if (number == 61)
            //{
            //    Console.WriteLine("Number is true");
            //}
            //else { Console.WriteLine("Number is false"); }


            //int exam1, exam2, exam3, average;
            //string result = "ERROR!!";

            //Console.Write("Enter your scores: ");
            //exam1 = int.Parse(Console.ReadLine());
            //exam2 = int.Parse(Console.ReadLine());
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if (average > 0 && average < 50)
            //{
            //    result = "Result is disgusting";
            //}
            //else if (average >= 50 && average < 75)
            //{
            //    result = "Result is meh";
            //}
            //else if (average >= 75 && average < 85)
            //{
            //    result = "Result is good";
            //}
            //else if (average >= 85 && average <= 100)
            //{
            //    result = "Result is very good";
            //}
            //Console.WriteLine(result);




            #endregion

            #region Calculator

            //int num1, num2, result;

            //Console.Write("Enter the first number: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the operator: ");
            //char symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine(result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine(result);
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine(result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine(result);
            //        break;

            //    default:
            //        Console.WriteLine("Wrong operator");
            //        break;
            //}

            #endregion

            #region For Loop

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int result = 0;

            //for (int i = 1; i <= 24; i++){

            //    if (i % 2 == 0) {
            //        Console.WriteLine(i);
            //        result += i;
            //    }

            //}   
            //Console.WriteLine("--------");
            //Console.WriteLine(result);

            #endregion

            #region While Loop

            //int result = 0;
            //int i = 10;

            //while (i > 0)
            //{
            //    if (i % 2 == 0)
            //    {   
            //        Console.WriteLine(i);
            //        result += i;
            //    }
            //    i--;
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(result);

            #endregion

            #region Example

            //// Add the digits of a 3-digit number.

            //int number = 261;
            //int result = 0;

            //while (number > 0) {

            //    result += number % 10; 
            //    number = number / 10;

            //}

            //Console.WriteLine(result);

            #endregion

            #region Making a Right Triangle with Stars

            //int count = 0;

            //for (int i = 1; i <= 5; i++) {

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Building a Pyramid with Stars

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}
