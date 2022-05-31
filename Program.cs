using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            string str = "";
            str = str + one + two + three;

            Console.WriteLine(str);
        }
    }
}
