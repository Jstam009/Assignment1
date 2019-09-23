using System;
using System.Collections;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: ");
            int a = 1, b = 23;
            printSelfDividingNumbers(a, b);
            Console.WriteLine("\n");

            Console.WriteLine("Question 2: ");
            int n2 = 4;
            printSeries(n2);
            Console.WriteLine("\n");

            Console.WriteLine("Question 3: ");
            int n3 = 5;
            printTriangle(n3);
            Console.WriteLine("\n");

            Console.WriteLine("Question 4: ");
            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);
            Console.WriteLine("\n");


            Console.WriteLine("Question 5: ");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {/** x – starting range, integer (int)* y – ending range, integer (int)* * summary      : 
            This method prints all the self-dividing numbers between x and y. * A self-dividing number is a number that is divisible by every digit it 
            contains.* 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0 and 128 % 8 == 0* 
            For example 1, 22 will print all the self.-dividing numbers between 1 and 22
            i.e. * 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22* Tip: Write a method isSelfDividing() to compute if a number is self-dividing or not.** 
            returns      : N/A* return type  : void**/

            try
            {
                bool isSelfDividing(int i) //Create the method and argument for self dividing numbers loop
                {
                    var number = i;
                    while (number > 1) //Number must be great than 1 to compute
                    {
                        var reminder = number % 10;
                        if (reminder == 0 || i % reminder != 0) //Create argument for is remainder is or is 0
                        {
                            return false;

                        }
                        number = number / 10;//Allows for number to continuously loop, will stop at 1 if not inserted
                    }
                    return true;

                }

                for (int i = x; i <= y; i++)//Count the numbers up to the inputted int value loop
                {

                    if (isSelfDividing(i) == true)
                    {
                        Console.Write(i + ", "); // Displays all inputs within i that meet self dividing number criteria
                    }


                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }
        public static void printSeries(int n2)
        {
            try
            {
                // Write your code here
                //Do a for loop for the amount of integer times, (for loop 1 to 5 inclusive if the int is 5 for exxample) 
                //I = E 1 -> Assuming passed, before getting into loop, have counter that is set to 0, done in two loops, outer and inner loop. 
                //Loop 1 will loop through one, then go into the inner loop for 2  
                //Square root formula

                for (int i = 1; i <= n2; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i + ", ");
                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n3)
        {
            try
            {
                int j;
                for (int i = n3; i > 0; i--)
                {
                    for (j = n3 - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (j = (2 * i) - 1; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
                //Start counter with 0, have out loop then inner loop
                //Outer loop will counter 1,2,3,4,
                //Inner loop will check for each element in outer loop array, every time you get a match you increment the counter 
                int r4 = 0;


                foreach (int stone in S)
                {
                    foreach (int jewel in J)
                    {
                        if (jewel == stone)
                            r4++;
                    }
                }

                return r4;
            }

            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
                //Pick smaller array, need to define all of the possible arrays within the array
                //Start from largest to smallest, then do 2,3,4,5, and 1,2,3,4 smaller 
                //Then 3,4,5/2,3,4/1,2,3
                int arrayA = 0;
                int arrayB = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[arrayA] == b[arrayB])
                    {
                        arrayA += 1;
                    }
                    else
                    {
                        arrayB += 1;
                    }
                     



                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            // return the arra
            return null;

        }
    }
}
public static void SolvePuzzle()
{
    try
    {
        // Write your code here
    }//Each letter can be 0-9 as the range, 
     //Use dictionarys in C#, GOOGLE
     //Going to have a loop within a loop, for the first part (UBER + COOL)
     //
    catch
    {
        Console.WriteLine("Exception occured while computing solvePuzzle()");
    }
}

      



