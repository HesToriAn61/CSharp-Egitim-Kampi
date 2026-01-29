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
            //    Console.WriteLine("Şifre doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Enter the Country: ");
            //country = Console.ReadLine();
            //Console.Write("Enter the Capital: ");
            //capital = Console.ReadLine();



            //if (country == "türkiye" && /* ||*/ capital == "ankara")
            //{
            //    Console.Write("Eşleşme doğru");
            //}
            //else { Console.WriteLine("Eşleşme yanlış"); }



            //int number;
            //number = int.Parse(Console.ReadLine());

            //if (number == 61)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else { Console.WriteLine("Sayı yanlış"); }


            //int exam1, exam2, exam3, average;
            //string result = "HATA!!";

            //Console.Write("Notlarınızı giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //exam2 = int.Parse(Console.ReadLine());
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if (average > 0 && average < 50)
            //{
            //    result = "Sonuç berbat";
            //}
            //else if (average >= 50 && average < 75)
            //{
            //    result = "Sonuç orta";
            //}
            //else if (average >= 75 && average < 85)
            //{
            //    result = "Sonuç iyi";
            //}
            //else if (average >= 85 && average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);




            #endregion

            #region Hesap Makinesi

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
            //        Console.WriteLine("Hatalı operatör");
            //        break;
            //}

            #endregion

            #region For Döngüsü

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

            #region While Döngüsü

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

            #region Örnek Sınav Sorusu

            //// 3 basamaklı sayının basamaklarını topla

            //int sayi = 261;
            //int sonuç = 0;

            //while (sayi > 0) {

            //    sonuç += sayi % 10; 
            //    sayi = sayi / 10;

            //}

            //Console.WriteLine(sonuç);

            #endregion

            #region Yıldızlarla Dik Üçgen Yapma

            //int count = 0;

            //for (int i = 1; i <= 5; i++) {

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Piramit Yapma

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
