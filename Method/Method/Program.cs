using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Sum(30, 40)); // 10,20 - arguments
            //Fullname("Kamran", "Jabiyev");
            //Fullname("Kenan", "Memmedli");
            //Console.WriteLine(SumAll(10,20,11));
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(SumArrIndex(3,100,23,45));

            #region Method overloading
            //Console.WriteLine(Sum(5, 10));
            #endregion

            #region value,reference types - stack,heap
            int a = 5;
            int b = a; //b=5-demekdir!!!
            a = 6;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);


            int[] arr = { 10, 20, 30 };
            int[] arr1 = arr; //int[] arr1={ 10, 20, 30 } eyni deyil!!!

            arr[0] = 100;

            Console.WriteLine("arr[0]="+arr[0]);
            Console.WriteLine("arr1[0]="+arr1[0]);
            #endregion
        }

        #region Method overloading
        //static int Sum(int n1, int n2, int n3 = 0)
        //{
        //    return n1 + n2 + n3;
        //}

        //static int Sum(params int[] arr)
        //{
        //    int result = 0;
        //    foreach (int index in arr)
        //    {
        //        result += index;
        //    }
        //    return result;
        //}

        //static int Sum(int n1, int n2)
        //{
        //    return n1 + n2;
        //}



        //Method signature -Method name, parametrs count,parametr's type 
        static void Print(string word)
        {
            Console.WriteLine(word);
        }

        static void Print(string word,string word2)
        {
            Console.WriteLine($"{word} {word2}");
        }

        static void Print(int x)
        {
            Console.WriteLine(x);
        }
        #endregion

        //static int SumArrIndex(params int[] arr)
        //{
        //    int result = 0;
        //    foreach (int index in arr)
        //    {
        //        result += index;
        //    }
        //    return result;
        //}

        /// <summary>
        /// Sum two parametrs
        /// </summary>
        /// <param name="n1">First parametr</param>
        /// <param name="n2">Second parametr</param>
        /// <returns></returns>
        //static int Sum(int n1,int n2) // n1,n2 - parametrs
        //{
        //    if (n1 > n2)
        //    {
        //        return n1 - n2;
        //    }
        //    return n1 + n2;
        //}

        //static int SumAll(int n1,int n2,int n3=0)
        //{
        //    return n1 + n2 + n3;
        //}

        //static void Fullname(string name,string surname)
        //{
        //    if (name == "Kamran")
        //    {
        //        Console.WriteLine("Teacher name");
        //        return;
        //    }
        //    Console.WriteLine($"{name} {surname}");
        //}


    }
}


