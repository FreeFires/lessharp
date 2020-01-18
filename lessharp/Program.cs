using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lessharp
{
    class Program
    {
        static void Main(string[] args)
        {
            print("Привет мир", 25);
            string name = "Георгий";
            print(name, 59);
            print("Helo WORLD!!!!", 21);
            print();



            Console.ReadKey();
        }
        public static void print(string words = "Hello", short number = 20)
        {
            Console.WriteLine("Переменная: {0}, число: {1}", words, number);
        }
    }
}
