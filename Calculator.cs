using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConcepts
{
    public class Calculator
    {
        //public static  void Add()
        //{
        //    Console.WriteLine("Enter total numbers to add ");
        //    int numberSize=Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Now Please Enter numbers to add");
        //    int add = 0;
        //    for(int i = 1; i <=numberSize; i++)
        //    {
        //        int num=Convert.ToInt32(Console.ReadLine());
        //        add = add + num;
        //    }
        //    Console.WriteLine("the total addition of enterd numbers is "+add);
        //    Console.WriteLine();
        //}

        //public static void Substract()
        //{
        //    Console.WriteLine("Enter total numbers to subtract ");
        //    int numberSize = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Now Please Enter numbers to subtract");
        //    int subtract = 0;

        //    for (int i = 1; i <= numberSize; i++)
        //    {
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        subtract = subtract - num;
        //    }
        //    Console.WriteLine("the total subtraction of enterd numbers is " + subtract);
        //}
        //public static void Multiplication ()
        //{
        //    Console.WriteLine("Enter total numbers to Multiplication ");
        //    int numberSize = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Now Please Enter numbers to Multiplication");
        //    int multiplication = 0;

        //    for (int i = 1; i <= numberSize; i++)
        //    {
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        multiplication = multiplication * num;
        //    }
        //    Console.WriteLine("the total Multiplication of enterd numbers is " + multiplication);
        //}

        //public static void Division()
        //{
        //    Console.WriteLine("Enter total numbers to divide ");
        //    int numberSize = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Now Please Enter numbers to divide");
        //    int divide = 0;

        //    for (int i = 1; i <= numberSize; i++)
        //    {
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        divide = divide / num;
        //    }
        //    Console.WriteLine("the total subtraction of enterd numbers is " + divide);
        //}

        //or 

        public static void calculate(char opeartor,double num1,double num2)
        {

            switch(opeartor)
            {
                case '+':
                    Console.WriteLine(num1 + num2); 
                    break;

                case '-':
                    Console.WriteLine(num1-num2);
                    break;
                case '*':
                    Console.WriteLine(num1*num2);
                    break;

                case '/':
                    Console.WriteLine(num1/num2);
                    break;

            }
        }
    }
}
