namespace katas.car_rental
{
    public abstract class Rent
    {
        protected string cuit;
        protected double factorDiscount;
        abstract public double Amount();
    }
}