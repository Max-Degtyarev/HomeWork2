
//#define TASK1
//#define TASK2
#define TASK3

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;




namespace HomeWork2
{
    internal class Program
    {



        static void Main(string[] args)
        {

#if TASK1
            const int size = 5;
            int[] A = new int[size];
            WriteLine("Введите значения массива А:");


            for (int i = 0; i < size; i++)
            {
                A[i] = Int32.Parse(ReadLine());

            }

            WriteLine();
            WriteLine("Массив А:");
            for (int i = 0; i < size; i++)
            {
                Write(A[i] + "\t");

            }
            WriteLine();


            const int ROWS = 3;
            const int COLS = 4;


            double[][] B = new double[3][];
            Random rand = new Random();

            for (int i = 0; i < ROWS; i++)
            {
                B[i] = new double[COLS];
                for (int j = 0; j < COLS; j++)
                {
                    B[i][j] = ((double)rand.Next(100, 10000) / 100);

                }

            }

            WriteLine("Массив B:");

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    Write(B[i][j] + "\t");

                }
                WriteLine();
            }


            WriteLine("Минимальное значение массива B = " + MinValue(B, ROWS, COLS));
            WriteLine("Сумма всех элементов массива В = {0}", Sum(B, ROWS, COLS));
            WriteLine($"Сумма нечетных столбцов массива В = {SumCols(B, ROWS, COLS)}");
            


                        
            
#endif


#if TASK2
            int num1, num2, result;
            char symbol;

            WriteLine("Введите арифметическое выражение: ");

            num1 = Int32.Parse(ReadLine());
            symbol = Char.Parse(ReadLine());
            num2 = Int32.Parse(ReadLine());


            switch (symbol)
            {

                case ('+'):
                    result = num1 + num2;
                    WriteLine($"Результат вычисления {result}");
                    break;
                case ('-'):
                    result = num1 - num2;
                    WriteLine($"Результат вычисления {result}");
                    break;


            }

#endif





#if TASK3

            const int ROWS = 5;
            const int COLS = 5;


            int[][] B = new int[5][];
            Random rand = new Random();

            for (int i = 0; i < ROWS; i++)
            {
                B[i] = new int[COLS];
                for (int j = 0; j < COLS; j++)
                {
                    //B[i][j] = 100 * ((rand.NextDouble() * 2 - 1));
                    B[i][j] = (rand.Next(-100, 100));

                }

            }

            WriteLine("Массив B:");

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    Write(B[i][j] + "\t");

                }
                WriteLine();
            }



            int Minindexi = 0;
            int Minindexj = 0;

            int Maxindexi = 0;
            int Maxindexj = 0;


            MinValue();
            MaxValue();
            Sum2();

            void MinValue()
            {

                double Min = B[0][0];

                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        if (B[i][j] < Min)
                        {
                            Min = B[i][j];
                            Minindexi = i;
                            Minindexj = j;

                        }

                    }

                }
                WriteLine("Минимальное значение массива В {0}", Min);

            }

            void MaxValue()
            {
                double Max = B[0][0];

                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        if (B[i][j] > Max)
                        {
                            Max = B[i][j];
                            Maxindexi = i;
                            Maxindexj = j;

                        }

                    }

                }
                WriteLine("Максимально значение массива В {0}", Max);

            }


            void Sum2()
            {

                int sum = 0;
                int iteration = 0;

                for (int i = Minindexi > Maxindexi ? Maxindexi : Minindexi; i <= (Minindexi < Maxindexi ? Maxindexi : Minindexi); i++)
                {
                    int j = 0;
                    if (iteration == 0)
                    {
                        if (Minindexi > Maxindexi)
                        {
                            j = Maxindexj + 1;


                        }
                        else if (Minindexi < Maxindexi)
                        {

                            j = Minindexj + 1;

                        }

                    }

                    for (; j < (i == (Minindexi < Maxindexi ? Maxindexi : Minindexi) ? (Minindexi > Maxindexi ? Minindexj : Maxindexj) : COLS); j++)
                    {

                        sum += B[i][j];

                    }

                    iteration++;

                }

                WriteLine("Сумма элементов между минимальным и максимальным элементами = " + sum);


            } 
#endif






        }


        static double MinValue(double[][] B, int ROWS, int COLS)
        {
            double Min = B[0][0];

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (B[i][j] < Min) Min = B[i][j];

                }

            }
            return Min;
            

        }

        static double Sum(double[][] B, int ROWS, int COLS)
        {
            double sum = 0;

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    sum += B[i][j];

                }
            }
            return sum;
            


        }

        static double SumCols(double[][] B, int ROWS, int COLS)
        {
            double sum = 0;

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (j % 2 != 0)
                    {
                        sum += B[i][j];

                    }

                }
            }
            return sum;
            


        }


    }
}
