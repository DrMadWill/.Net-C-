using System;

namespace _4_data_type_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit casting ( automatically ) ozunden boyuk deyerler ozunden kicik deyerleri tuta bilir

            int intdeyer = 10;
            long longdeyer = intdeyer;

            Console.WriteLine(longdeyer);

            string stringdeyer = "123";
            int asdert = Int32.Parse(stringdeyer);
            Console.WriteLine(asdert+2);



            //explicit casting ( manually )

            long longdeyer_2 = 25;
            int intdyeyer_2 = (int)longdeyer_2;
            Console.WriteLine(intdyeyer_2);



        }
    }
}
