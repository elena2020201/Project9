using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace статич_метод_символин_масс_результат_целочисл_м_с_кодом
{
    class Program
    {
        static char[] rands(int n)
        {
            Random rnd = new Random();
            char[] symbs = new char[n];
            for (int k = 0; k < symbs.Length; k++)
            {
                symbs[k] = (char)('A' + rnd.Next(26));

            }

            return symbs;
        }
        static void Main()
        {
            char[] B;
            B = rands(10);
            Console.WriteLine("Случайные символы: ");
            foreach (char s in B)
            {
                Console.Write("|{0}", s);
            }
            Console.WriteLine("|");
            Console.ReadLine();
        
            }

        }
    }

        
