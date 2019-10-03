using System;

namespace Lab_1
{
    class Program
    {
        //1
        public static int GetArraySize(long N)
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
        public static long[] GetArray(long N)
        {
            int lenghtArray = GetArraySize(N);
            long[] numbers = new long[lenghtArray];
            for (int i = lenghtArray - 1; i >= 0; i--)
            {
                long res= N % 10;
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
        public static double ArithmeticMean(long N)
        {

            long[] ar = GetArray(N);
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            double ArithmeticMean = (double) sum / ar.Length;
            return ArithmeticMean;
        }

        //4
        public static double GeometricMean(long N)
        {
            long[] ar = GetArray(N);
            long mult = 1;
            for (int i = 0; i < ar.Length; i++)
            {
                mult *= ar[i];
            }

            double GeometricMean = Math.Pow(mult, (1 / ar.Length));
            return GeometricMean;
        }

        //5
        public static int Factorial(long N)
        {
            int factorial = 1; // значення факторіалу
            for (int i = 2; i <= N; i++) // цикл починаємо з 2 бо нема сенсу починати з 1
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        //6
        public static int SumEven(long N)
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
        public static int SumOdd(long N)
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
            long N;
            int start, finish;
            
            while (true)
            {
                try
                {
                    Console.Write("Enter N ");
                    N = Convert.ToInt64(Console.ReadLine());
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is outside the range of the int64 type. ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                }
            }

            Console.WriteLine(GetArraySize(N));
            Console.WriteLine(GetArray(N));
            Console.WriteLine(ArithmeticMean(N));
            Console.WriteLine(GeometricMean(N));
            Console.WriteLine(Factorial(N));
            Console.WriteLine(SumEven(N));
            Console.WriteLine(SumOdd(N));
            
            Console.WriteLine("Set array interval, first element");
            start = Convert.ToByte(Console.ReadLine());
            Console.Write("last element: ");
            finish = Convert.ToByte(Console.ReadLine());

            if (finish-start < 0)
            {
                Console.WriteLine("Wrong diapason");
            }
            else
            {
                Console.WriteLine(SumOdd(start, finish));
                Console.WriteLine(SumEven(start, finish));

            }

        }
    }
} 