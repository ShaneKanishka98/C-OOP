class Abstract
{
    public static void main(String[] args)
    {
        Customer customer = new Customer();
        customer.CaluclateDiscount();
    }

    public abstract class Customer()
    {
        public string name { get; set; }

        public string age { get; set; }

        public string address { get; set; }

        // public virtual decimal caluclateDiscount() 
        // {
        //     throw new NotImplementedException("Will be done by child class.");
        // }

        public abstract decimal CaluclateDiscount();

    }

    class SilverCustomer : Customer
    {
        public override decimal CaluclateDiscount()
        {
            return 10;
        }
    }

    class GoldCustomer : Customer
    {
        public override decimal CaluclateDiscount()
        {
            return 20;
        }
    }
}
