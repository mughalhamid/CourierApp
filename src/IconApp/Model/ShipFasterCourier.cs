namespace IconApp.Model
{
    public class ShipFasterCourier : Courier
    {
        protected override string CourierName { get; set; } = "ShipFaster";
        protected override int WeightLowerLimit { get; set; } = 10;
        protected override int WeightUpperLimit { get; set; } = 30;
        protected override int DimensionsUpperLimit { get; set; } = 1700;

        public override double CalculatePriceByDimension(double dimension)
        {
            if (dimension <= 1000) return 11.99;
            if (dimension > 1000 && dimension <= DimensionsUpperLimit) return 21.99;
            return 0;
        }

        public override double CalculatePriceByWeight(double weight)
        {
            if (weight >= WeightLowerLimit && weight <= 15) return 16.50;
            if (weight > 15 && weight <= 25) return 36.50;
            if (weight > 25 && weight <= WeightUpperLimit)
            {
                var newWeight = weight - 25;
                return 40 + newWeight * 0.415;
            }
            return 0;
        }
    }
}
