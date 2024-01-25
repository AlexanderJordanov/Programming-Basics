using System;

namespace TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Град	   0 ≤ s ≤ 500  /	500 < s ≤ 1 000  /	1 000 < s ≤ 10 000	/ s > 10 000
            //Sofia     5 %                7 %                    8 %             12 %
            //Varna     4.5 %              7.5 %                  10 %            13 %
            //Plovdiv   5.5 %              8 %                    12 %            14.5 %


                        string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;

           if ( sales >= 0 && sales <= 500)
            { 
                switch (city)
                {
                    case "Sofia": commission = sales * 0.05; break;
                    case "Varna": commission = sales * 0.045; break;
                    case "Plovdiv": commission = sales *0.055; break;
                    default: Console.WriteLine("error"); break;
                }
                    

            }
           else if ( sales > 500 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia": commission = sales * 0.07; break;
                    case "Varna": commission = sales * 0.075; break;
                    case "Plovdiv": commission = sales *0.08; break;
                    default: Console.WriteLine("error"); break;
                }
            }
           else if ( sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia": commission = sales * 0.08; break;
                    case "Varna": commission = sales * 0.1; break;
                    case "Plovdiv": commission = sales * 0.12; break;
                    default: Console.WriteLine("error"); break;
                }
            }
           else if ( sales > 10000)
            {
                switch (city)
                {
                    case "Sofia": commission = sales * 0.12; break;
                    case "Varna": commission = sales * 0.13; break;
                    case "Plovdiv": commission = sales *0.145; break;
                    default: Console.WriteLine("error"); break;
                }
            }
           else
            {
                Console.WriteLine("error");
            }
           if ( commission > 0 ) { Console.WriteLine($"{commission:f2}"); }
        }
    }
}
