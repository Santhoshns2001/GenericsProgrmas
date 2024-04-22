using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConcepts
{
    internal class ArrayAssignment 
    {
        

        //public static void PrintIntArray()
        //{
        //    Console.WriteLine("Enter the size of an integer array");
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    int[] arr = new int[size];
        //    Console.WriteLine("Enter " + size + " values");

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }


        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]+" ");
        //    }


        //    Console.WriteLine();
        //}



        //public static void PrintCharArray()
        //{
        //    Console.WriteLine("Enter size of charcters");
        //    int size= Convert.ToInt32(Console.ReadLine());
        //    char [] ch = new char[size];

        //    Console.WriteLine("Enter "+size+" values");

        //    for(int i = 0; i < ch.Length; i++)
        //    {
        //        ch[i] = Char.Parse(Console.ReadLine());
        //    }
        //    for(int i = 0; i < ch.Length; i++)
        //    {
        //        Console.Write(ch[i]+" ");
        //    }

        //    Console.WriteLine();


        //}

        //public static void PrintDoubletArray()
        //{
        //    Console.WriteLine("Enter the size of an double array");
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    double[] arr = new double[size];
        //    Console.WriteLine("Enter " + size + " values");

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToDouble(Console.ReadLine());
        //    }


        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }


        //    Console.WriteLine();
        //}


        //or 

        //internal static void PrintArray<T>(T[] arr)
        //{
        //    foreach (T t in arr)
        //    {
        //        Console.WriteLine(t);
        //    }
        //}



        

        internal static void FindMaximumInInteger(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2 > max)
                max = num2;
            else if (num3 > max)
                max = num3;

            Console.WriteLine("biggest of three integers is "+max);

        }



        internal static void FindMaximumInFloat(float f1, float f2, float f3)
        {
            float max = f1;

            if (f2 > max)
                max = f2;
            else if (f3 > max)
                max = f3;

            Console.WriteLine("biggest of three integers is " + max);
        }

            internal static void FindMaximumInString(string? str1, string? str2, string? str3)

           
        {
            string max = str1;
            if (str1.Length.CompareTo(str2.Length) > 0)
                max = str1;
            else if (str2.Length.CompareTo(str3.Length) > 0)
                max = str3;

            Console.WriteLine("biggest of threxe strings is "+max);

        }

        internal static T FindMaximumByGenerics<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }

            else if (num2.CompareTo(num3) >= 0 && num2.CompareTo(num1) >= 0)
            {
                return num2;
            }
            else
                return num3;
        }
    }
}
