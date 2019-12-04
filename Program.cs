using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        Encoding ascii = Encoding.ASCII;
        static void Main(string[] args)
        {
            string str;
            if (args.Length ==0) for (; ; )
                {
                    Console.Write("Исходная строка (<Enter> для выхода): ");
                    str = Console.ReadLine();
                    if (str == "") break;
                    Console.WriteLine("{0}", ToCodes(str));
                }
            else Console.WriteLine("{0}", ToCodes(args[0]));
        }

        static string ToCodes(string p)
        {
            int i; string str="";
            for (i = 0; i < p.Length; i++)
            {
                str += Convert.ToByte(p[i]) + " ";
            }
            return "Коды символов: " + str + "\n";
        }
    }
}
