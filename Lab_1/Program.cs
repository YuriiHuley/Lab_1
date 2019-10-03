using System;

namespace Lab_1
{
    class Program
    {
        //1
        public static int GetArraySize(int N)
        {
            int a = 0;
            while (N != 0)
            {
                N /= 10;
                a++;
            }

            return a;
        }

        //2
        public static int[] GetArray(int N)
        {
            int lenghtArray = GetArraySize(N);
            int[] numbers = new int[lenghtArray];
            for (int i = lenghtArray - 1; i >= 0; i--)
            {
                int res= N % 10;
                N /= 10;
                numbers[i] = res;
                
            }
            //виведення масиву в консоль
            //for (int i = 0; i < lenghtArray; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            
            
            return numbers;
        }

        //3
        public static double ArithmeticMean(int N)
        {

            int[] ar = GetArray(N);
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            double ArithmeticMean = (double) sum / ar.Length;
            return ArithmeticMean;
        }

        //4
        public static double GeometricMean(int N)
        {
            int[] ar = GetArray(N);
            int mult = 1;
            for (int i = 0; i < ar.Length; i++)
            {
                mult *= ar[i];
            }

            double GeometricMean = Math.Pow(mult, (1 / ar.Length));
            return GeometricMean;
        }

        //5
        public static int Factorial(int N)
        {
            int factorial = 1; // значення факторіалу
            for (int i = 2; i <= N; i++) // цикл починаємо з 2 бо нема сенсу починати з 1
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        //6
        public static int SumEven(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        //7
        public static int SumOdd(int N)
        {
            int sum = 0;
            int i = 1;
            while ( i <= N)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
                i++;
            }
        
            return sum;
        }
        //8.1
        public static int SumEven(int start, int finish)
        {
            int sum = 0;
            do
            {
                if (start % 2 == 0)
                {
                    sum += start;
                }

                start++;
            } while (start <= finish);

            return sum;
        }
        //8.2
        public static int SumOdd(int start, int finish)
        {
            int sum = 0;
                do
                {
                    if (start % 2 != 0)
                    {
                        sum += start;
                    }

                    start++;
                } while (start <= finish);

                return sum;
            }


        static void Main(string[] args)
        {
            int N = 253;
            Console.WriteLine(GetArraySize(N));
            Console.WriteLine(GetArray(N));
            Console.WriteLine(ArithmeticMean(N));
            Console.WriteLine(GeometricMean(N));
            Console.WriteLine(SumEven(N));
            Console.WriteLine(SumOdd(N));
            Console.WriteLine(SumOdd(5,34));
            Console.WriteLine(SumEven(3,100));
        }
    }
} 