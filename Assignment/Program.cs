using System;
using System.Collections.Generic;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {


                //1




                //static void Main()
                //{

                //    Console.Write("Enter an integer:");
                //    int.TryParse(Console.ReadLine(), out int number);


                //    for (int i = 1; i <= number; i++)
                //    {
                //        Console.Write(i + (i < number ? ", " : ""));
                //    }
                //}




                //2

                //static void Main() {

                //    Console.Write("Enter an number");
                //    int.TryParse(Console.ReadLine(), out int number);

                //    for (int i = 1; i <= 12; i++)
                //    {
                //        Console.Write(number * i + (i < 12 ? " " : ""));
                //    }

                //}


                //3




                //static void Main()
                //{

                //    Console.Write("Enter an number");
                //    int.TryParse(Console.ReadLine(), out int number);

                //    for (int i = 2; i <= number; i += 2)
                //    {
                //        Console.Write(i + (i < number - 1 ? " " : ""));
                //    }
                //}




                //4



                //static void Main()
                //{

                //    Console.Write("Enter an number");
                //    int.TryParse(Console.ReadLine(), out int baseNumber);

                //    Console.Write("Enter an number");
                //    int.TryParse(Console.ReadLine(), out int exponent);


                //    int result = 1;
                //    for (int i = 1; i <= exponent; i++)
                //    {
                //        result *= baseNumber;
                //    }


                //    Console.WriteLine($"result: {result}");
                //}



                //5




                //static void Main()
                //{

                //    Console.WriteLine("Enter marks for five subjects:");

                //    int.TryParse(Console.ReadLine(), out int mark1);
                //    int.TryParse(Console.ReadLine(), out int mark2);
                //    int.TryParse(Console.ReadLine(), out int mark3);
                //    int.TryParse(Console.ReadLine(), out int mark4);
                //    int.TryParse(Console.ReadLine(), out int mark5);

                //    int total = mark1 + mark2 + mark3 + mark4 + mark5;

                //    double average = total / 5.0;

                //    double percentage = (total / 500.0) * 100;

                //    Console.WriteLine($"Total Marks = {total}");
                //    Console.WriteLine($"Average Marks = {average}");
                //    Console.WriteLine($"Percentage = {percentage}%");
                //}


                //6



                //static void Main()
                //{

                //    Console.Write("Enter the month number: ");
                //    int monthNumber = int.Parse(Console.ReadLine());


                //    int daysInMonth;

                //    if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 || monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
                //    {
                //        daysInMonth = 31;
                //    }
                //    else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
                //    {
                //        daysInMonth = 30;
                //    }
                //    else if (monthNumber == 2)
                //    {
                //        daysInMonth = 28;  
                //    }
                //    else
                //    {
                //        Console.WriteLine("Invalid month number.");
                //        return;
                //    }


                //    Console.WriteLine("Days in the month: " + daysInMonth);
                //}



                //7


                //static void Main()
                //{
                //    Console.WriteLine(" Calculator!");


                //    Console.Write("Enter the first number: ");
                //    double num1 = Convert.ToDouble(Console.ReadLine());


                //    Console.Write("Enter the operation (+, -, *, /): ");
                //    char operation = Console.ReadKey().KeyChar;
                //    Console.WriteLine();


                //    Console.Write("Enter the second number: ");
                //    double num2 = Convert.ToDouble(Console.ReadLine());


                //    if (operation == '+')
                //        Console.WriteLine($"Result: {num1 + num2}");
                //    else if (operation == '-')
                //        Console.WriteLine($"Result: {num1 - num2}");
                //    else if (operation == '*')
                //        Console.WriteLine($"Result: {num1 * num2}");
                //    else if (operation == '/')
                //    {
                //        if (num2 != 0)
                //            Console.WriteLine($"Result: {num1 / num2}");
                //        else
                //            Console.WriteLine("Error: Division by zero is not allowed.");
                //    }
                //    else
                //        Console.WriteLine("Error: Invalid operation.");


                //}



                //8


                //static void Main()
                //{
                //    Console.Write("Enter an integer: ");
                //    int number = Convert.ToInt32(Console.ReadLine());

                //    int reversedNumber = 0;

                //    while (number != 0)
                //    {
                //        int digit = number % 10; 
                //        reversedNumber = reversedNumber * 10 + digit; 
                //        number /= 10; 
                //    }

                //    Console.WriteLine($"Reversed number: {reversedNumber}");
                //}




                //9


                //static void Main()
                //{
                //    Console.Write("Input starting number of range: ");
                //    int start = Convert.ToInt32(Console.ReadLine());

                //    Console.Write("Input ending number of range: ");
                //    int end = Convert.ToInt32(Console.ReadLine());

                //    Console.WriteLine($"The prime numbers between {start} and {end} are:");

                //    for (int i = start; i <= end; i++)
                //    {
                //        if (IsPrime(i))
                //        {
                //            Console.Write(i + " ");
                //        }
                //    }
                //}

                //static bool IsPrime(int num)
                //{
                //    if (num <= 1) return false; 

                //    for (int i = 2; i <= Math.Sqrt(num); i++)
                //    {
                //        if (num % i == 0) return false;
                //    }

                //    return true;
                //}




                //10



                //static void Main()
                //{
                //    Console.Write("Enter a number to convert: ");
                //    int number = Convert.ToInt32(Console.ReadLine());

                //    string binary = ""; 

                //    if (number == 0)
                //    {
                //        binary = "0";
                //    }
                //    else
                //    {
                //        while (number > 0)
                //        {
                //            int remainder = number % 2; 
                //            binary = remainder + binary; 
                //            number /= 2; 
                //        }
                //    }

                //    Console.WriteLine($"The Binary of the given number is: {binary}");
                //}


                //11
                // Console.Write("Enter the size of the identity matrix (n): ");
                //int n = int.Parse(Console.ReadLine());

                //for (int i = 0; i < n; i++)
                //{
                //  for (int j = 0; j < n; j++)
                //{
                //   if (i == j)
                //  Console.Write("1 ");
                //  else
                //    Console.Write("0 ");
                //}
                //Console.WriteLine();

                //}

                //12

                //Console.Write("Enter the number of elements in the array: ");
                /*  int n = int.Parse(Console.ReadLine());
                  int[] array = new int[n];

                  Console.WriteLine("Enter the elements:");
                  for (int i = 0; i < n; i++)
                      array[i] = int.Parse(Console.ReadLine());

                  int sum = 0;
                  foreach (int num in array)
                      sum += num;

                  Console.WriteLine("The sum of the elements is: " + sum);*/

                //13
                /*
                 Console.Write("Enter the size of the arrays: ");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[n];

        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < n; i++)
            array1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of the second array:");
        for (int i = 0; i < n; i++)
            array2[i] = int.Parse(Console.ReadLine());

        int[] mergedArray = array1.Concat(array2).OrderBy(x => x).ToArray();

        Console.WriteLine("Merged and sorted array:");
        Console.WriteLine(string.Join(" ", mergedArray));
                 */
                //14
                /*
                    Console.Write("Enter the number of elements in the array: ");
                    int n = int.Parse(Console.ReadLine());
                    int[] array = new int[n];

                    Console.WriteLine("Enter the elements:");
                    for (int i = 0; i < n; i++)
                        array[i] = int.Parse(Console.ReadLine());
                */

                //15
                /*
                 Console.Write("Enter the number of elements in the array: ");
         int n = int.Parse(Console.ReadLine());
         int[] array = new int[n];

         Console.WriteLine("Enter the elements:");
         for (int i = 0; i < n; i++)
             array[i] = int.Parse(Console.ReadLine());

         int max = array[0], min = array[0];

         foreach (int num in array)
         {
             if (num > max) max = num;
             if (num < min) min = num;
         }

         Console.WriteLine($"Maximum element: {max}");
         Console.WriteLine($"Minimum element: {min}");
                 */
                //16
                /*
                 Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
            array[i] = int.Parse(Console.ReadLine());

        int max = array.Max();
        int secondMax = array.Where(x => x < max).Max();

        Console.WriteLine("The second largest element is: " + secondMax);
                 */

                //17

                /* Console.Write("Enter the number of elements in the array: ");
                 int n = int.Parse(Console.ReadLine());
                 int[] array = new int[n];

                 Console.WriteLine("Enter the elements:");
                 for (int i = 0; i < n; i++)
                     array[i] = int.Parse(Console.ReadLine());

                 int maxDistance = 0;

                 for (int i = 0; i < n; i++)
                 {
                     for (int j = i + 1; j < n; j++)
                     {
                         if (array[i] == array[j])
                         {
                             int distance = j - i;
                             if (distance > maxDistance)
                                 maxDistance = distance;
                         }
                     }
                 }

                 Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);
                */

                //18
                /*
                 ---------------------------------
                 */

                //19
                /*
                 Console.Write("Enter the number of elements in the array: ");
           int n = int.Parse(Console.ReadLine());
             int[] array = new int[n];

              Console.WriteLine("Enter the elements:");
             for (int i = 0; i < n; i++)
               array[i] = int.Parse(Console.ReadLine());

                -----------------------------

                 */
            }

        }
    }
}