using System;

namespace HomeWork_10_16_Task_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertiser add1 = new Advertiser("add_1", 150.5);
            Advertiser add2 = new Advertiser("add_2", 250.5);
            Advertiser add3 = new Advertiser("add_3", 350.5);

            double[] adds = { add1.Cost, add2.Cost, add3.Cost };

            double results = 0;
            Console.WriteLine(results.SumAdds(adds));
        }
    }
}
