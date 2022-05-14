using System;
using System.Linq;



namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gcd(43, 15));
            

        } 
        public static int Gcd(int a, int b)
        {
            int ostatok;
            int gdc = 0;
            while(b != 0)
            {
                ostatok = a % b;
                a = b;
                b = ostatok;
                gdc = a;
               
            }
            return gdc;
        }
        
    }
}