namespace katas.car_rental
{
    public abstract class Rent
    {
        protected string cuit;
        protected double factorDiscount;
        private const string START_CUIT_COMPANY = "26";
        private const double DISCOUNT = 0.95;  
        private const double NORMAL = 1;

        public double Amount(){
            factorDiscount = cuit.StartsWith(START_CUIT_COMPANY) ? DISCOUNT : NORMAL;
            return getAmount();
        }

        public abstract double getAmount();
    }
}