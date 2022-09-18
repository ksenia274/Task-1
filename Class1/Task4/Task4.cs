﻿namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar)
        {
            string begendstr = "";
            for (int a = 1; a <= width; a++)
            {
                begendstr = begendstr + frameChar;
            }

            Console.WriteLine(begendstr);


            for (int i = 1; i <= height - 2; i++)
            {
                Console.Write(frameChar);
                for (int j = 1; j <= width - 2; j++)
                {
                    Console.Write(' ');
                }

                Console.WriteLine(frameChar);
            }

            Console.WriteLine(begendstr);
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            string begendstr = "";
            int a = 1;
            while (a <= width)
            {
                begendstr = begendstr + frameChar;
                a++;
            }

            Console.WriteLine(begendstr);
            int i = 1;
            while (i <= height - 2)
            {
                Console.Write(frameChar);
                int j = 1;
                while (j <= width - 2)
                {
                    Console.Write(' ');
                    j++;
                }

                Console.WriteLine(frameChar);
                i++;
            }

            Console.WriteLine(begendstr);
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            while (a != b)
            {
                if (a >= b) a -= b;
                else b -= a;
            }

            return a;
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double res = 1;
            double fact = 1;

            for (int i = 1; i != n; i++)
            {
                fact *= i;
                res += (Math.Pow(x, i)) / fact;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Console.WriteLine(Gcd(2, 3));
            Console.WriteLine(ExpTaylor(1.0, 10));
        }
    }
}