namespace HomeWork_10_16_Task_2_
{
    class Advertiser : User
    {
        public string Advertisement { get; set; }
        public double Cost { get; set; }

        public Advertiser(string advertisement, double cost)
        {
            Advertisement = advertisement;
            Cost = cost;
        }
    }
}
