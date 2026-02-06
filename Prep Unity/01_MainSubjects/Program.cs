using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Print Commands
            //Console.WriteLine("Hello World");
            //Console.Write("Hi");

            //Console.WriteLine("**** MENU ****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Soups");
            //Console.WriteLine("2 - Main Foods");
            //Console.WriteLine("3 - Sweets");
            //Console.WriteLine("4 - Drinks");
            //Console.WriteLine();
            //Console.WriteLine("**** MENU ****");
            #endregion

            #region String Variables
            //string name;
            //name = "Hüseyin Taha";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone;
            //string customerCity;

            //customerName = "Hüseyin Taha";
            //customerSurname = "Adanur";
            //customerEmail = "example@gmail.com";
            //customerPhone = "+90 561 610 61 61";
            //customerCity = "Trabzon";

            //Console.WriteLine("**** Rezervation ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");  
            //Console.WriteLine("Customer = " + customerName + " " + customerSurname);
            //Console.WriteLine("Communication = " + customerPhone);
            //Console.WriteLine("Email = " + customerEmail);
            //Console.WriteLine("City = " + customerCity);
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine();

            //customerName = "Çaycı";
            //customerSurname = "Taşkıran";
            //customerEmail = "ilker@gmail.com";
            //customerPhone = "+90 1234567890";
            //customerCity = "İstanbul";


            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Customer = " + customerName + " " + customerSurname);
            //Console.WriteLine("Communication = " + customerPhone);
            //Console.WriteLine("Email = " + customerEmail);
            //Console.WriteLine("City = " + customerCity);
            //Console.WriteLine("-----------------------------------------------");

            #endregion

            #region Integer Variables
            //int num;
            //num = 61;
            //Console.WriteLine(num);

            //int hamburgerPrice,pizzaPrice;
            //int friesPrice;
            //int lemonadePrice, cokePrice, waterPrice;

            //hamburgerPrice = 350;
            //pizzaPrice = 400;
            //friesPrice = 100;
            //lemonadePrice = 60;
            //cokePrice = 80;
            //waterPrice = 15;

            //Console.WriteLine("**** Menu Prices****");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("--Hamburger: " + hamburgerPrice);
            //Console.WriteLine("--Pizza: " + pizzaPrice);
            //Console.WriteLine("--Fries: " + friesPrice);
            //Console.WriteLine("--Lemonade: " + lemonadePrice);
            //Console.WriteLine("--Coke: " + cokePrice);
            //Console.WriteLine("--Water: " + waterPrice);
            //Console.WriteLine("-------------------------------") ;
            //Console.WriteLine();

            //int hamburgerCount, pizzaCount;
            //int friesCount;
            //int lemonadeCount,cokeCount,waterCount;

            //int totalHamburgerPrice,totalPizzaPrice;
            //int totalFriesPrice;
            //int totalLemonadePrice,totalCokePrice,totalWaterPrice;

            //hamburgerCount = 2;
            //pizzaCount = 1;
            //friesCount = 1;
            //lemonadeCount = 2;
            //cokeCount = 1;
            //waterCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalFriesPrice = friesCount *  friesPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;

            //int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalLemonadePrice + totalCokePrice + totalWaterPrice;

            //Console.WriteLine("**** Receipt ****");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("--Hamburger: " + totalHamburgerPrice);
            //Console.WriteLine("--Pizza: " + totalPizzaPrice);
            //Console.WriteLine("--Fries: " + totalFriesPrice);
            //Console.WriteLine("--Lemonade: " + totalLemonadePrice);
            //Console.WriteLine("--Coke: " + totalCokePrice);
            //Console.WriteLine("--Water: " + totalWaterPrice);
            //Console.WriteLine();
            //Console.WriteLine("Amount to be paid : " + totalPrice);
            //Console.WriteLine("-------------------------------");



            #endregion

            
            Random rastgele = new Random();

 
            int sayi = rastgele.Next(1, 21);

            int tahmin;
           
            for (int i = 0; i < 5; i++) {

                Console.Write($"{i + 1}. tahmini giriniz: ");
                tahmin = int.Parse(Console.ReadLine());
                if (sayi == tahmin)
                {
                    Console.WriteLine("Sayıyı doğru bildiniz.");
                    break;

                }
                if (sayi < tahmin)
                {
                    Console.WriteLine("Lütfen daha küçük bir sayi giriniz.");
                }
                if (sayi > tahmin)
                {
                    Console.WriteLine("Lütfen daha büyük bir sayi giriniz.");
                }

                }
            Console.WriteLine("Sayi = " + sayi);




                Console.Read();
        }
    }
}
