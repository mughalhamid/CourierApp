namespace IconApp.Model
{
    public class Cargo4YouCourier : Courier
    {
        protected override string CourierName { get; set; } = "Cargo4You";
        protected override int WeightUpperLimit { get; set; } = 20;
        protected override int DimensionsUpperLimit { get; set; } = 2000;

        public override double CalculatePriceByDimension(double dimension)
        {
            if (dimension <= 1000) return 10;
            if (dimension > 1000 && dimension <= DimensionsUpperLimit) return 20;
            return 0;
        }

        public override double CalculatePriceByWeight(double weight)
        {
            if (weight <= 2) return 15;
            if (weight > 2 && weight <= 15) return 18;
            if (weight > 15 && weight <= WeightUpperLimit) return 35;
            return 0;
        }
    }
}
