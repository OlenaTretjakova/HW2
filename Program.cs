using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1/
            Console.WriteLine("Task 1.");
            Console.WriteLine();

            double[] A = new double[5];
            double[,] B = new double[3, 4];

            Console.WriteLine("Enter 5 decimal numbers for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                A[i] = double.Parse(Console.ReadLine());
            }

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.NextDouble() * 100;
                }
            }

            Console.WriteLine("\nArray A:");
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nArray B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            double maxA = A[0], minA = A[0], sumA = 0, productA = 1, sumEvenA = 0;
            foreach (var item in A)
            {
                maxA = Math.Max(maxA, item);
                minA = Math.Min(minA, item);
                sumA += item;
                productA *= item;
                if (item % 2 == 0)
                {
                    sumEvenA += item;
                }
            }

            double maxB = B[0, 0], minB = B[0, 0], sumB = 0, productB = 1, sumOddColumnsB = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    maxB = Math.Max(maxB, B[i, j]);
                    minB = Math.Min(minB, B[i, j]);
                    sumB += B[i, j];
                    productB *= B[i, j];
                    if (j % 2 != 0)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }
            }

            Console.WriteLine("\nOverall maximum element for A and B: " + Math.Max(maxA, maxB));
            Console.WriteLine("Overall minimum element for A and B: " + Math.Min(minA, minB));
            Console.WriteLine("Overall sum of all elements for A and B: " + (sumA + sumB));
            Console.WriteLine("Overall product of all elements for A and B: " + (productA * productB));
            Console.WriteLine("Sum of even elements of array A: " + sumEvenA);
            Console.WriteLine("Sum of odd columns of array B: " + sumOddColumnsB);


            //Task 2.
            Console.WriteLine();
            Console.WriteLine("Task 2.");
            Console.WriteLine();

            int[,] arrTask2 = new int[5, 5];

            Console.WriteLine("Array task 2 : ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrTask2[i, j] = rand.Next(-100, 101);
                    Console.Write(arrTask2[i, j] + " ");
                }
            }
            Console.WriteLine();

            int maxValueTask2 = arrTask2[0, 0];
            int minValueTask2 = arrTask2[0, 0];

            foreach (int element in arrTask2)
            {
                maxValueTask2 = Math.Max(maxValueTask2, element);
                minValueTask2 = Math.Min(minValueTask2, element);
            }

            int sumValuesFromMinToMax = 0;

            int[] newArrTask2 = new int[25];
            int indexNew = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    newArrTask2[indexNew] = arrTask2[i, j];
                    indexNew++;
                }
            }

            int indesxMinValue = Array.IndexOf(newArrTask2, minValueTask2);
            int indexMaxValue = Array.IndexOf(newArrTask2, maxValueTask2);

            for (int i = 0; i< 25; i++)
            {
                if (indesxMinValue < indexMaxValue)
                {
                    if(i >=indesxMinValue && i<= indexMaxValue)
                    {
                        sumValuesFromMinToMax += newArrTask2[i];
                    }
                }
                else if(indesxMinValue > indexMaxValue)
                {
                    if (i <= indesxMinValue && i >= indexMaxValue)
                    {
                        sumValuesFromMinToMax += newArrTask2[i];
                    }
                }

            }
               
            Console.WriteLine();
            Console.WriteLine($"Min value in array : {minValueTask2}");
            Console.WriteLine($"Max value in this two arrayes : {maxValueTask2}");
            Console.WriteLine($"Sum elements from min to max: {sumValuesFromMinToMax}");


            //Task 3.
            Console.WriteLine();
            Console.WriteLine("Task 3.");

            Console.WriteLine("Enter text: ");

            string textTask3 = Console.ReadLine();

            string [] arrTask3 = textTask3.Split(' ');

            Console.WriteLine("Encrypted text :");

            foreach(string str in arrTask3)
            {
                char[] chars = str.ToCharArray();
                
                for(int i = 0; i< chars.Length; i++)
                {
                    int numChar = 7 + chars[i];
                    chars[i] = (char)numChar;
                }

                string newStr = new string(chars) + ' ';
                Console.Write(newStr);
                    
            }
            Console.WriteLine();

            //Task 4.
            Console.WriteLine();
            Console.WriteLine("Task 4.");
            Console.WriteLine();

            int[,] matrix = new int[4, 6];
            Random rand1 = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand1.Next(-50, 50);
                }
            }

            Console.WriteLine("Matrix:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Enter a number to multiply the matrix by:");

            int numMult = int.Parse(Console.ReadLine());

            Console.WriteLine("Matrix * " + numMult + ":");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] * numMult + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] matrix1 = new int[4, 6];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = rand.Next(-50, 50);
                }
            }

            Console.WriteLine("Matrix 1:");

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] matrix3 = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix3[i, j] = 0;
                }
            }

            Console.WriteLine("Matrix * Matrix1:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix[i, j] * matrix1[i, j];
                    Console.Write(matrix3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Task 5.
            Console.WriteLine();
            Console.WriteLine("Task 5.");
            Console.WriteLine();

            Console.WriteLine("Enter exspression :");
            string task4 = Console.ReadLine();

            int result = 0;
            int num1 = 0;
            int num2 = 0;
            char operation = '+';

            foreach (var item in task4)
            {
                if (char.IsDigit(item))
                {
                    if (operation == '+')
                        num1 = num1 * 10 + (item - '0');
                    else if (operation == '-')
                        num2 = num2 * 10 + (item - '0');
                }
                else if (item == '+' || item == '-')
                {
                    if (operation == '-')
                        result -= num2;
                    else
                        result += num1;

                    operation = item;
                    num1 = num2 = 0;
                }
            }

            if (operation == '-')
                result -= num2;
            else
                result += num1;

            Console.WriteLine("Result: " + result);



            Console.ReadLine();


        }
    }
}
