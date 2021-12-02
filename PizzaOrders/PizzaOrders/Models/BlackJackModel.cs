namespace PizzaOrders.Areas.BlackJack.Models
{
    public class BlackJackModel
    {
        public int NumberOne { get; set; }
        
        public int NumberTwo { get; set; }
        
        public int Result => NumberOne + NumberTwo;

        public int DealerNumberOne { get; set; }
        public int DealerNumberTwo { get; set; }
        public int DealerResult => DealerNumberOne + DealerNumberTwo;

        public string Winner { get; set; }
    }
}