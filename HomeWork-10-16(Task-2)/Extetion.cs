namespace HomeWork_10_16_Task_2_
{
    static class Extetion
    {
        public static double SumAdds(this double res, double[] arr)
        {
            foreach (double item in arr)
            {
                res += item;
            }
            return res;
        }
    }
}
