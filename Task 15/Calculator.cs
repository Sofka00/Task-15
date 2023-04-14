using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_15
{
    public static class Calculator
    {
        public static int ReadFromConsol()
        {
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            return n;
        }
        public static int LinearEquation(int a, int b, int c)
        {
            int discriminant = (b * b) * (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("Нет корней");
            }
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / 2;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2;
                Console.WriteLine($" X1 = {x1}, X2 = {x2}");
            }
            if (discriminant == 0)
            {
                int x = (-b) / (2 * a);
                Console.WriteLine($"x = {x}");

            }
            return discriminant;
        }
        public static int ComparisonOfTwoNumber(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a + b;
                Console.WriteLine(result);

            }
            if (a == b)
            {
                result = a * b;
                Console.WriteLine(result);

            }
            if (a < b)
            {
                result = a - b;
                Console.WriteLine(result);
            }
            return result;

        }
        public static int UppercaseNumber(int number)
        {
            int dozense = number / 10;
            int unit = number % 10;
            switch (dozense)
            {
                case 1:

                    switch (unit)
                    {
                        case 0:
                            Console.WriteLine("Десять");
                            break;
                        case 1:
                            Console.WriteLine("Одиннадцать");
                            break;
                        case 2:
                            Console.WriteLine("Двенадцать");
                            break;
                        case 3:
                            Console.WriteLine(" Тринадцать ");
                            break;
                        case 4:
                            Console.WriteLine("Чеиырнадцать ");
                            break;
                        case 5:
                            Console.WriteLine("Пятнадцать");
                            break;
                        case 6:
                            Console.WriteLine(" Шестнадцать ");
                            break;
                        case 7:
                            Console.WriteLine(" Семнадцать ");
                            break;
                        case 8:
                            Console.WriteLine("Восемнадцать");
                            break;
                        case 9:
                            Console.WriteLine("Девятнадцать");
                            break;

                    }
                    break;
                case 2:
                    Console.Write("Двадцать");
                    break;
                case 3:
                    Console.Write("Тридцать ");
                    break;
                case 4:
                    Console.Write(" Сорок ");
                    break;
                case 5:
                    Console.Write("Пятьдесят");
                    break;
                case 6:
                    Console.Write("Шестьдесят");
                    break;
                case 7:
                    Console.Write("Семьдесят");
                    break;
                case 8:
                    Console.Write("Восемьдесят");
                    break;
                case 9:
                    Console.Write("Девяносто");
                    break;
            }
            if (dozense != 1) ;
            switch (unit)
            {
                case 1:
                    Console.Write("Один");
                    break;
                case 2:
                    Console.Write("Два");
                    break;
                case 3:
                    Console.Write("Три");
                    break;
                case 4:
                    Console.Write("Четыре");
                    break;
                case 5:
                    Console.Write("Пять");
                    break;
                case 6:
                    Console.Write("Шесть");
                    break;
                case 7:
                    Console.Write("Семь");
                    break;
                case 8:
                    Console.Write("Восемь");
                    break;
                case 9:
                    Console.Write("Девять");
                    break;
            }
            return number;
        }

        public static bool NumberFromRange(int number)
        {
            if (number >= 0 && number <= 10)
            {

                return true;
            }

            if (number >= 20 && number <= 30)
            {
                return true;
            }

            if (number >= 40 && number <= 50)
            {
                return true;
            }
            return false;

        }
        public static int SumOfRangeNumber(int number1, int number2)
        {
            int sum = 0;
            for (int i = number1; i <= number2; i++)
            {
                if (i % 7 == 0)
                {
                    sum = +i;
                }
            }
            return sum;

        }
        public static int FibonacciNumber(int number)
        {
            int value1 = 1;
            int value2 = 1;
            int fibo = 0;

            for (int i = 3; i < number; i++)
            {
                fibo = value1 + value2;

                if (value1 > value2)
                {
                    value2 = fibo;
                }
                else
                {
                    value1 = fibo;
                }
            }
            return number;

        }
        public static int NumberOfOddDigits (int number)
        {
            while (number != 0)
            {
                int tmp = number % 10;

                if (tmp % 2 > 0)
                {
                    Console.WriteLine(tmp);
                }
                number /= 10;
            }
            return number;
        }
        public static int MirrorNumber (int number)
        {
            int result = 0;
            while (number > 0)
            {
                int tmp = number % 10;
                number = number/ 10;
                result = result * 10;
                result = result + tmp;

            }
            return result;
        }
        public static bool SameDigitsFromTwoNumbers (string number, string number2)
        {

            for (int i = 0; i < number.Length; i++)
            {
                for (int z = 0; z < number2.Length; z++)
                {
                    if (number[i] == number2[z])
                    {
                        return  true;
                    }
                }
            } return false;
        }
        
            //int units = 0;
            //int dozens = 0;
            //int hundreds = 0;

            //do
            //{
            //    units= number % 10;
            //    number /= 10;
            //    hundreds = number2;

            //    do
            //    {

            //        dozens = hundreds % 10;
            //        hundreds /= 10;

            //        if (units == dozens)

            //        break;
            //        return true;

            //    } while (hundreds != 0);

            //    if (units == dozens)
            //    {
            //        return true;
                    
            //    }

            //} while (number != 0);

            //if (units != dozens) 
            //{
            //    return false;
            //}
          
        }
    }
    














