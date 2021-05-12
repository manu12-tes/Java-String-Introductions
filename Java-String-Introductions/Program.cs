using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_String_Introductions
{
    class Program
    {
        public static int Asc(string s)
        {
            return Encoding.ASCII.GetBytes(s)[0];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("dame primera cadena");
            String a = Console.ReadLine();
            Console.WriteLine("dame segunda cadena");
            String b = Console.ReadLine();

            Console.WriteLine((a.Length + b.Length));
            if (Asc(a) < Asc(b)) { Console.WriteLine("No"); }
            else { Console.WriteLine("Si"); }
            Console.WriteLine(a+" "+b);


        }
    }
}
