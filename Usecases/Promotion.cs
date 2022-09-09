namespace MyShop.Usecases
{
    public class Promotion
    {
        public double TotalPrice { get; set; }
        public int ItemCount { get; set; }

        public double GetDiscount()
        {
            if(TotalPrice >= 1000 & TotalPrice < 2000)
            {
                return TotalPrice * 0.1;
            }

            if(TotalPrice >= 2000)
            {
                return TotalPrice * 0.15;
            }

            if(TotalPrice < 1000 & ItemCount >= 4)
            {
                return TotalPrice * 0.05;
            }

            return 0.00;
        }
    }
}
