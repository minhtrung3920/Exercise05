using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_z(); Console.WriteLine();
            Print_z_a(); Console.WriteLine();
            PrintUpper();  Console.WriteLine();
            
            ascii('a');
            Console.WriteLine();
            check_Upper_Lower('c');
            
        }
        public static void Print_a_z()
        {
            for (int c = 97; c <= 122; c++)
            {
                Console.Write((char) c );
            }
        }
        public static void Print_z_a()
        {
            for (int c = 122; c >= 97; c--)
            {
                Console.Write((char)c);
            }
        }
        public static void PrintUpper()
        {
            for (int c = 65; c <= 90; c++)
            {
                Console.Write((char)c);
            }
        }
        public static void ascii(char c)
        {
            for (int i = 65; i <= 122; i++)
            {
                if ((int)c == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void check_Upper_Lower(char c)
        {
            for (int i = 65; i <= 90; i++) 
            {
                if ((int)c == i) 
                {
                    Console.WriteLine("{0} is upper");
                }
            }
            for (int i = 97; i <= 122; i++) {
                if ((int)c == i) {
                    Console.WriteLine("{0} is lower:", c);
                }
            }
        }
     
    }
}
