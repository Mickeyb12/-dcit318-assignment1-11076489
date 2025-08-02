namespace TicketPriceCalculator
{
    public class TicketPriceCalculator
    {
        public decimal GetTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
                return 7.00m;
            else
                return 10.00m;
        }
    }
}