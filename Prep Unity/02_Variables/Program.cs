using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variatons

            ////double num;
            ////num = 2.5;
            ////Console.WriteLine(num);

            //double applePrice, bananaPrice, mangoPrice, strawberryPrice;
            //double appleCount, bananaCount, mangoCount, strawberryCount;

            //applePrice = 2.50;
            //bananaPrice = 55.30;
            //mangoPrice = 24.5;
            //strawberryPrice = 15.2;

            //appleCount = 3.25;
            //bananaCount = 2.2;
            //mangoCount = 1;
            //strawberryCount = 2.4;

            //double totalPrice = applePrice*appleCount + bananaPrice*bananaCount + mangoPrice*mangoCount + strawberryPrice*strawberryCount;

            //Console.WriteLine("**** Fruits ****");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Apple - " + applePrice);
            //Console.WriteLine("Banana - " + bananaPrice);
            //Console.WriteLine("Mango - " + mangoPrice);
            //Console.WriteLine("Strawberry - " + strawberryPrice);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Total apple price = " + applePrice * appleCount);
            //Console.WriteLine("Total banana price = " + bananaPrice * bananaCount);
            //Console.WriteLine("Total mango price = " + mangoPrice * mangoCount);
            //Console.WriteLine("Total strawberry price = " + strawberryPrice * strawberryCount);
            //Console.WriteLine();
            //Console.WriteLine("Total Price = " + totalPrice);

            #endregion

            #region Char Variations

            //char letter;
            //letter = 'a';
            //Console.WriteLine(letter);

            #endregion

            #region String Data Input From the Keyboard

            //string passengerName , passengerSurname , passengerAge , passengerID ;

            //Console.WriteLine("Passenger:");
            //Console.WriteLine("------------------");
            //Console.Write("Name = ");
            //passengerName = Console.ReadLine();

            //Console.Write("Surname = ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Age = ");
            //passengerAge = Console.ReadLine();

            //Console.Write("ID = ");
            //passengerID = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("**** AirPort Passenger Registration ****"); 
            //Console.WriteLine();
            //Console.WriteLine("Passenger Information : " + passengerID + " / " + passengerName + " " + passengerSurname + " / " + passengerAge);

            #endregion

            #region Keyboard Inputs of Integers and Conversions

            //int number;
            //number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);

            //int monitorPrice, mousePrice, keyboardPrice, casePrice;
            //int monitorCount, mouseCount, keyboardCount, caseCount;

            //monitorPrice = 5000;
            //mousePrice = 1000;
            //keyboardPrice = 1500;
            //casePrice = 4500;

            //Console.Write("Monitor Count = ");
            //monitorCount = int.Parse(Console.ReadLine());

            //Console.Write("Mouse Count = ");
            //mouseCount = int.Parse(Console.ReadLine());

            //Console.Write("Keyboard Count = ");
            //keyboardCount = int.Parse(Console.ReadLine());

            //Console.Write("Case Count = ");
            //caseCount = int.Parse(Console.ReadLine());

            //int totalPrize = monitorPrice * monitorCount + mousePrice * mouseCount + keyboardPrice* keyboardCount + casePrice*caseCount;

            //Console.WriteLine("**** Purchase List ****");
            //Console.WriteLine();
            //Console.WriteLine("Total Monitor Prize = " + monitorPrice*monitorCount);
            //Console.WriteLine("Total Mouse Prize = " + mousePrice * mouseCount);
            //Console.WriteLine("Total Keyboard Prize = " + keyboardPrice*keyboardCount);
            //Console.WriteLine("Total Case Prize = " + casePrice*caseCount);
            //Console.WriteLine();
            //Console.WriteLine("Total Prize = " + totalPrize);

            #endregion

            #region Keyboard Decimal Number Inputs

            //double exam1, exam2, exam3, result;


            //Console.Write("Enter the first exam score = ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter the second exam score = ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter the last exam score = ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Your total score: " + result);

            #endregion

            #region  Keyboard Character Inputs

            //char gender;

            //Console.Write("Enter the your gender: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Your gender: " + gender);

            #endregion

            Console.Read();
        }
    }
}
