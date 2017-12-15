namespace BridgeTechWhizz
{
    public class MovieTicketShopping
    {
        public MovieTicketShopping(IDiscountStrategy discountStrategy)
        {
            CurrentDiscountStrategy = discountStrategy;
        }
        public string CustomerName { get; set; }

        public double BillAmount
        {
            get { return 250; }
            set { }
        }

        public IDiscountStrategy CurrentDiscountStrategy { get; set; }

        public double GetFinalBillAmount()
        {
            return CurrentDiscountStrategy.GetDiscountedBill(BillAmount);
        }
    }
}
