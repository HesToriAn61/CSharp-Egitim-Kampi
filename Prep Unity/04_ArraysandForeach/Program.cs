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
            #region Arrays

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
            //Console.WriteLine("The biggest member of the array = " + nums.Max() + " The smallest member of the array = " + nums.Min());

            //int[] nums = new int[5];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"Enter the {i + 1}.member of array: ");
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

            //string word = "Hello";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Exam Note Application

            //Console.WriteLine("***** Student Exam Status *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.Write("Enter the student counts: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvrg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"Enter the {i + 1}.student name: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter the {j + 1}.note of which name is {studentNames[i]} : ");
            //        int score = int.Parse(Console.ReadLine());
            //        totalExamResult += score;
            //    }
            //    studentExamAvrg[i] = totalExamResult / 3;
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");

            //for (int k = 0; k < studentCount; k++)
            //{

            //    if (studentExamAvrg[k] < 50)
            //    {
            //        Console.WriteLine($"The student named {studentNames[k]} failed the course." + " Average: " + studentExamAvrg[k]);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The student named {studentNames[k]}  passed the course." + " Average: " + studentExamAvrg[k]);

            //    }
            //}
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine();


            #endregion

            Console.Read();
        }
    }
}
