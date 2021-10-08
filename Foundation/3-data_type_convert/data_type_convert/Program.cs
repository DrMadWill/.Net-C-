using System;

namespace data_type_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. eded : ");
            int eded1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. eded : ");
            int eded2 = Convert.ToInt32(Console.ReadLine());
            int toplama = eded1 + eded2;
            Console.WriteLine($"Toplamanin cavab: {toplama}");
      

            int intdeyer = 15;
            long longdeyer = intdeyer;
            Console.WriteLine("");

        }
    }
}
