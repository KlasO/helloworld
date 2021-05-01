using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar= 1;
            if (args.Length != 0 )
            {
                   myVar= Convert.ToInt32(args[0]);
                   if (args.Length > 1)
                   {
                     Console.WriteLine("Skipping the args beyond the args[0]=" + args[0]);
                     Console.WriteLine("But for the record, these are the arguments passed");
                    int index = 0;
                     foreach (var item in args)
                     {
                     Console.WriteLine("Argument " + index + " has the value " + item);
                     index++;
                     }
                   };
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
