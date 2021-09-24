using System;
using System.Linq;

namespace lineage
{
    class Program
    {
        static void Main(string[] args)

        {

            #region Ex: 1
            //while (true)
            //{




            //    Console.WriteLine("Balinizi daxil edin: ");

            //    int point = Convert.ToInt32(Console.ReadLine());


            //    if (point <= 100 && point >= 91)
            //    {
            //        Console.WriteLine("A");
            //    }

            //    else if (point <= 90 && point >= 81)
            //    {
            //        Console.WriteLine("B");
            //    }

            //    else if (point <= 80 && point >= 71)
            //    {
            //        Console.WriteLine("C");
            //    }

            //    else if (point <= 70 && point >= 61)
            //    {
            //        Console.WriteLine("D");
            //    }
            //    else if (point <= 60 && point >= 51)
            //    {
            //        Console.WriteLine("E");
            //    }

            //    else if (point <= 50)
            //    {
            //        Console.WriteLine("Kesr");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Error");
            //    }

            //}
            #endregion

            #region Ex: 2
            //Console.WriteLine("Ededi daxil edin: ");

            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if (num%i == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}
            #endregion

            #region Ex: 3
            //Console.WriteLine("Ededi daxil edin: ");

            //double num = Convert.ToDouble(Console.ReadLine());
            //int i = 0;
            //while(num >= 1)
            //{
            //    num /= 10;
            //    i++;
            //}

            //Console.WriteLine("Cavab: " + i + " mertebeli");
            #endregion

            #region Ex: 4
            //Console.WriteLine("Ededi daxil edin: ");

            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = 0;

            //while (num >= 1)
            //{
            //    result += num % 10;
            //    num = (num - (num % 10)) / 10;
            //}
            //Console.WriteLine("cavab: " + result);

            #endregion

            #region Ex: 7
            //int[] num = { 24, 31, 58, 45, 98, 63, 835 };

            // Console.WriteLine(num.Max() + num.Min());
            #endregion
           
            #region Ex: 8
            // Console.WriteLine("Secim daxil edin: ");

            // int season = Convert.ToInt32(Console.ReadLine());

            //switch(season)
            // {
            //     case 1:
            //         Console.WriteLine("yaz");
            //         break;
            //     case 2:
            //         Console.WriteLine("yay");
            //         break;
            //     case 3:
            //         Console.WriteLine("payiz");
            //         break;
            //     case 4:
            //         Console.WriteLine("qis");
            //         break;
            //     default:
            //         Console.WriteLine("bele  bir secim yoxdur");
            //         break;
            // }

            #endregion

            #region Ex: 9
            //string[] heroNames = { "Karina", "Lylia", "Yve", "Ling", "Granger" };
            //Console.WriteLine();
            #endregion

            #region Ex: 10
            //Console.WriteLine("1ci ededi daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2ci ededi daxil edin");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num * num2);
            #endregion









            //Console.WriteLine("Ededi daxil edin: ");


            //int i = 1;
            //int result = 1;
            //Console.WriteLine(Factorial());


        }


        #region Ex: 6
        static double Factorial(double i = 1, double result = 1)
        {

            double num = Convert.ToInt32(Console.ReadLine());


            while (i <= num)
            {
                result *= i;
                i++;
            }
            return result;

        }
        #endregion

        #region Ex: 5
        static void SadeEded(int num)
        {


            if (num % 2 == 0)
                Console.WriteLine("True");

            else
                Console.WriteLine("False");



        }
        #endregion


    }
}
        




























