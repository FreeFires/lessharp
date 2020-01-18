using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lessharp
{
    class Program
    {
        /*
         * Функции
         * Функция возвращает максимальное число в массиве
        */
        static void Main(string[] args)
        {
            int[] digits = { 0, 3, 25, 99, 36, 101, 2, 43 };
            int[] digits2 = { 8, 3, 11, 54, 44, 43, 33, 9 };

            double[] num1 = { 0.2, 44.7, 10.8, 15.15 };
            double[] num2 = { 9.2, 13.5, 44.45, 19.15 };

            int max = 0; // переменная которая передается в функцию maxElement
            maxElement(digits, out max); // out - означает, что переменную max можно передаеть в функцию, в нашем случае функия maxElement

            Console.WriteLine("Maximum elevent in array digits = {0}", max);
            //Console.WriteLine("Maximum elevent in array digits2 = {0}", max2);
                        

            changeArr(ref digits, ref digits2);
            changeArr<double>(ref num1, ref num2);
            showArray<int>(digits, digits2); // <int> указывает тип данных,       !!! прописывать не обязательно

            Console.ReadKey();
        }

        public static void showArray<T>(T[] a, T[] b) // T - указывает на тип передаваемых данных
        {
            foreach (T item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            foreach (T item in b)
            {
                Console.Write(item);
            }
        }
        
        public static void maxElement(int[] numbers, out int max) // out - означант, что параметр принимает переменную которая находится вне функции maxElement
        {
            max = numbers[0];
            foreach (int el in numbers)
            {
                if (el > max) 
                    max = el;
            }
            //return max;
        }
        /*
         * Функция замены значений массива digits и digits2
         */
        public static void changeArr(ref int[] a, ref int[] b) // ref - ссылка на массив 'а'
        {
            int[] temp = new int[a.Length]; // временный массив
            a.CopyTo(temp, 0); // копирование значений массива 'а' во временный массив 'temp' начиная с индекса '0'
            Array.Clear(a, 0, a.Length); // очищаем массив 'a'. a - массив, 0 - начиная с елемента, a.Length - длинна массива
            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);
            temp.CopyTo(b, 0);
        }

        public static void changeArr<T>(ref T[] a, ref T[] b) // Т - укзывает на тип данных
        {
            T[] temp = new T[a.Length]; // временный массив
            a.CopyTo(temp, 0); // копирование значений массива 'а' во временный массив 'temp' начиная с индекса '0'
            Array.Clear(a, 0, a.Length); // очищаем массив 'a'. a - массив, 0 - начиная с елемента, a.Length - длинна массива
            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);
            temp.CopyTo(b, 0);
        }
    }
}
