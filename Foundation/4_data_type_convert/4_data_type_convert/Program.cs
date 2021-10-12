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

            float float_deyer = 25.6f;
            double double_deyer = float_deyer;

            Console.WriteLine(double_deyer);




            //explicit casting ( manually )

            long longdeyer_2 = 25;
            int intdyeyer_2 = (int)longdeyer_2;

            double double_deyer_2 = 2332.3;
            float float_deyer_2 = (float)double_deyer_2;

            intdyeyer_2 =(int) double_deyer_2;

            Console.WriteLine(double_deyer_2);

            


        }
    }
}
