using System.Diagnostics.Metrics;

namespace Ass05
{
    internal class Program
    {

        /*  static void IncrementByValue(int number)
          {
              number += 1;
              Console.WriteLine("Inside IncrementByValue: " + number);
          }


          static void IncrementByReference(ref int number)
          {
              number += 1;
              Console.WriteLine("Inside IncrementByReference: " + number);
          }*/ //1
        /* class MyClass
         {
             public int Number;
         }*/




        /* static void ModifyObjectByValue(MyClass obj)
         {
             obj.Number = 20;
             Console.WriteLine("Inside ModifyObjectByValue: " + obj.Number);
         }

         static void ModifyObjectByReference(ref MyClass obj)
         {
             obj = new MyClass { Number = 30 };
             Console.WriteLine("Inside ModifyObjectByReference: " + obj.Number);
         }*/ //2

        // Function that accepts four parameters and returns the sum of the first two numbers and the difference of the second two numbers
        /*  static int Calculate(int num1, int num2, int num3, int num4)
          {
              int sum = num1 + num2;
              int difference = num3 - num4;
              return $"({sum}, {difference});"*/ //3

        // Function to calculate the sum of the individual digits of a given number
        /*  static int SumOfDigits(int number)
          {
              int sum = 0;
              while (number != 0)
              {
                  sum += number % 10; 
                  number /= 10;      
              }
              return sum;
          }*/ //4

        // Function to check if a number is prime
      /*  static bool IsPrime(int number)
        {
            
            if (number < 2)
            {
                return false;
            }

            
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true; // prime
        }*/ //5






        static void Main(string[] args)
        {
            #region 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
             Passing by Value: When a parameter is passed by value
            a copy of the actual value is passed to the method Changes
            made to the parameter inside the method do not affect the original value outside the method.

             Passing by Reference: When a parameter is passed by reference
            a reference to the actual value is passed to the method Changes
            made to the parameter inside the method affect the original value outside the method.



             */

            /* int x = 5;

             // Passing by value
             Console.WriteLine("Before IncrementByValue: " + x);
             IncrementByValue(x);
             Console.WriteLine("After IncrementByValue: " + x);

             // Passing by reference
             Console.WriteLine("Before IncrementByReference: " + x);
             IncrementByReference(ref x);
             Console.WriteLine("After IncrementByReference: " + x);*/

            #endregion
            #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
             Passing by Value (Reference Type): When a reference type is passed by value,
             the method receives a copy of the reference and  Changes made to the object data
             will be reflected outside the method because
             both the original reference and the copy point to the same object
             However reassigning the reference itself inside the method will not affect the original reference.

            Passing by Reference (Reference Type): When a reference type is passed by reference
            the method receives a reference to the reference and  This allows the method 
            to modify the reference itself meaning it can reassign the reference to a 
            different object and this change will be reflected outside the method.*/


            /* MyClass myObject = new MyClass { Number = 10 };

             // Passing by value
             Console.WriteLine("Before ModifyObjectByValue: " + myObject.Number);
             ModifyObjectByValue(myObject);
             Console.WriteLine("After ModifyObjectByValue: " + myObject.Number);

             // Passing by reference
             Console.WriteLine("Before ModifyObjectByReference: " + myObject.Number);
             ModifyObjectByReference(ref myObject);
             Console.WriteLine("After ModifyObjectByReference: " + myObject.Number);*/


            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            // Accepting four parameters from the user
            /*  Console.WriteLine("Enter four numbers:");

              Console.Write("Enter the first number: ");
              int num1 = int.Parse(Console.ReadLine());

              Console.Write("Enter the second number: ");
              int num2 = int.Parse(Console.ReadLine());

              Console.Write("Enter the third number: ");
              int num3 = int.Parse(Console.ReadLine());

              Console.Write("Enter the fourth number: ");
              int num4 = int.Parse(Console.ReadLine());

              // Calling the function and getting the results
              var results = Calculate(num1, num2, num3, num4);

              // Displaying the results
              Console.WriteLine("Summation Result of first two numbers: " + results.sum);
              Console.WriteLine("Subtraction Result of last two numbers: " + results.difference);*/

            #endregion

            #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7

            /*  Console.Write("Enter a number: ");
              int number = int.Parse(Console.ReadLine());

              // Calculate the sum of the digits
              int sum = SumOfDigits(number);

              // Display the result
              Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");*/
            #endregion

            #region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:



            /*  Console.Write("Enter a number: ");
              int number = int.Parse(Console.ReadLine());

              // Check if the number is prime
              bool result = IsPrime(number);

              // Display the result
              if (result)
              {
                  Console.WriteLine($"{number} is a prime number.");
              }
              else
              {
                  Console.WriteLine($"{number} is not a prime number.");
              }*/
            #endregion

            #region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            #endregion
            #region 7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            #endregion
            #region 8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            #endregion

            #endregion
        }
    }
}
