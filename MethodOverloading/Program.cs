using System;

namespace MethodOverloading
{
    class Program
    {
        public static int ADD(int x, int y)
        {
            return x + y;
        }

        public static decimal ADD(decimal z, decimal w)
        {
            return z + w;
        }

        public static string ADD( int x ,int y, bool money)
        {
            if  (money == true)

            {
                if( x + y == 1)
                {
                    return $" {x + y}: dollar";
                }
                return $" {x + y}: dollars"; 
                
            }
            else
            {
                return $"error";
            }
        }


        static void Main(string[] args)
        {
            bool money = true;
            Console.WriteLine(ADD(7,6, money));
        }
    }
}
