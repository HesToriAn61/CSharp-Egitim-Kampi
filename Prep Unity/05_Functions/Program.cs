using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Function

            //void studentInfo()
            //{
            //    Console.WriteLine("Ali Yılmaz");
            //}

            //studentInfo();

            //void studentInfo(string studentName , string studentSurname)
            //{
            //    Console.WriteLine("Student name is " + studentName + " - Student surname is " + studentSurname);
            //}
            //studentInfo("Berat", "Dinç");

            //void studentInfo(string studentName, string studentSurname)
            //{
            //    Console.WriteLine("Student name is " + studentName + " - Student surname is " + studentSurname);
            //}

            //string name, surname;

            //Console.Write("Enter the student name: ");
            //name = Console.ReadLine();

            //Console.Write("Enter the student surname: ");
            //surname = Console.ReadLine();


            //studentInfo(name, surname);

            #endregion

            #region Int Function

            //int sum()
            //{
            //    int result = 0;
            //    int num1 = 5, num2 = 2;

            //    result = num1 + num2;

            //    return result;
            //}

            //Console.WriteLine(sum());

            //int sum(int num1,int num2) {

            //    int result = 0;
            //    result = num1 + num2;

            //    return result;
            //}
            //Console.WriteLine(sum(5, 8));

            //int sum (int num1 , int num2)
            //{
            //    int result = 0;
            //    result = num1 + num2;

            //    return result;
            //}

            //int number1,number2;

            //Console.Write("Enter the first number: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(sum(number1,number2));

            #endregion

            #region String Function

            //string score (int number1, int number2,int number3)
            //{
            //    int average = (number1 + number2 + number3)/3;

            //    if (average > 0 && average < 50) {
            //        return "You failed the exam";
            //    }
            //    else
            //    {
            //        return "You passed the exam";
            //    }
            //}

            //int score1, score2, score3;

            //Console.Write("Enter the exam scores: ");
            //score1 = int.Parse(Console.ReadLine());
            //score2 = int.Parse(Console.ReadLine());
            //score3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(score(score1, score2, score3));

            #endregion

            Console.Read();
        }
    }
}
