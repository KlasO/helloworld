using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
               int myVar= 1;
                
            }
            else
                {
                 int   myVar= Convert.ToInt32(args[0]);
                };
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{Math.Pow(i,myVar)} ");
                Console.Write(Math.Pow(i,i) + " ");
                Console.WriteLine("Hello World!");
            }
        }
    }
}
