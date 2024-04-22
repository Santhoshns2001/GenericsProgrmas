// See https://aka.ms/new-console-template for more information
using ArrayConcepts;
//using ArrayConcepts.ArrayAndGenericsAssignments;
using System.Numerics;

//Console.WriteLine("Hello, World!");



//ArrayAssignment.PrintIntArray();

//ArrayAssignment.PrintDoubletArray();

//ArrayAssignment.PrintCharArray();


//Calculator.Add();
//Calculator.Substract();
//Calculator.Multiplication();
//Calculator.Division();

// above methods are done by my way but it is not in proper way

// the proper way follows below


//Console.WriteLine("Enter the size of an integer array");
//int size=Convert.ToInt32(Console.ReadLine());
//int[] arr=new int[size];
//for(int i=0; i < arr.Length; i++)
//{
//    arr[i]= Convert.ToInt32(Console.ReadLine());
//}

//ArrayAssignment.PrintArray(arr);


//Console.WriteLine("Enter the size of an character array");
//int size2 = Convert.ToInt32(Console.ReadLine());
//char[] ch = new char[size2];
//for (int i = 0; i < ch.Length; i++)
//{
//    ch[i]=Convert.ToChar(Console.ReadLine());
//}

// ArrayAssignment.PrintArray(ch);

//Console.WriteLine("Enter the size of an double array");
//int size3 = Convert.ToInt32(Console.ReadLine());
//double[] d = new double[size3];
//for (int i = 0; i < d.Length; i++)
//{
//    d[i]= Convert.ToDouble(Console.ReadLine());
//}

//ArrayAssignment.PrintArray(d);


//Console.WriteLine("Enter the arithmetic operator to perform with two numbers");

//char opeartor = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("Enter two numbers");
//int number1=Convert.ToInt32(Console.ReadLine());
//int number2=Convert.ToInt32(Console.ReadLine());

//Calculator.calculate(opeartor, number1, number2);


//Assignment problems 

Console.WriteLine("Enter 3 numbers ");
Console.WriteLine("enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter third number");
int num3 = Convert.ToInt32(Console.ReadLine());

//ArrayAssignment.FindMaximumInInteger(num1,num2,num3);

int v = ArrayAssignment.FindMaximumByGenerics(num1, num2, num3);
Console.WriteLine("biggest of three is " + v);



Console.WriteLine("Enter 3 float values ");
Console.WriteLine("enter first float value");
float f1 = float.Parse(Console.ReadLine());
Console.WriteLine("enter second float value");
float f2 = float.Parse(Console.ReadLine());
Console.WriteLine("enter third float value");
float f3 = float.Parse(Console.ReadLine());

//ArrayAssignment.FindMaximumInFloat(f1, f2, f3);

float v1 = ArrayAssignment.FindMaximumByGenerics(f1, f2, f3);
Console.WriteLine("biggest of three float values  is " + v1);


Console.WriteLine("Enter three string values ");
Console.WriteLine("enter first string value");
string str1=Console.ReadLine();
Console.WriteLine("enter second string value");
string str2=Console.ReadLine();
Console.WriteLine("enter third string value");
string str3=Console.ReadLine();

//ArrayAssignment.FindMaximumInString(str1, str2, str3);


string? max = ArrayAssignment.FindMaximumByGenerics(str1, str2, str3);
Console.WriteLine("the  maximum of three strings is " + max);


