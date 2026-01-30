using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArraysandForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler

            //string[] cities = new string[5];
            //cities[0] = "Trabzon";
            //cities[1] = "Ankara";
            //cities[2] = "İstanbul";
            //cities[3] = "Bursa";
            //cities[4] = "Rize";

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] nums = { 5, 8, 15, 2, 1, 4, 11, 24, 61 };
            //Array.Sort(nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //int[] nums = { 5, 8, 15, 2, 1, 4, 11, 24, 61 };
            //Array.Reverse(nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //int[] nums = { 5, 8, 15, 2, 1, 4, 11, 24, 61 };
            //int index = Array.IndexOf(nums, 15);
            //Console.WriteLine(index);

            //int[] nums = { 5, 8, 15, 2, 1, 4, 11, 24, 61 };
            //Console.WriteLine("Dizinin en büyük elemanı = " + nums.Max() + " Dizinin en küçük elemanı = " + nums.Min());

            //int[] nums = new int[5];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"Dizinin {i + 1}. elemanını giriniz: ");
            //    nums[i]=  int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < nums.Length; i++) 
            //{ 
            //    Console.WriteLine(nums[i]);
            //}

            #endregion

            #region Foreach

            //string[] cities = { "Ankara", "Trabzon", "Paris", "Hamburg", "Milano" };

            //foreach (string x in cities) { 
            //    Console.WriteLine(x); 
            //}

            //List<int> list = new List<int>()
            //{

            //    1, 2, 3, 4, 5, 6, 9

            //};

            //foreach (int i in list) {
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Sınav Not Uygulaması

            Console.WriteLine("***** Öğrenci Sınav Durumu *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.Write("Öğrenci sayısını giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());
            string[] studentNames = new string[studentCount];
            double[] studentExamAvrg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}.notunu giriniz: ");
                    int score = int.Parse(Console.ReadLine());
                    totalExamResult += score;
                }
                studentExamAvrg[i] = totalExamResult / 3;
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            for (int k = 0; k < studentCount; k++)
            {

                if (studentExamAvrg[k] < 50)
                {
                    Console.WriteLine($"{studentNames[k]} isimli öğrenci dersten kalmıştır." + " Ortalama: " + studentExamAvrg[k]);
                }
                else
                {
                    Console.WriteLine($"{studentNames[k]} isimli öğrenci dersi geçmiştir." + " Ortalama: " + studentExamAvrg[k]);

                }
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine();


            #endregion

            Console.Read();
        }
    }
}
