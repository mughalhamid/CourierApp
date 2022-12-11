namespace IconApp.Model
{
    public class MaltaShipCourier : Courier
    {
        protected override string CourierName { get; set; } = "MaltaShip";
        protected override int WeightLowerLimit { get; set; } = 10;
        protected override int DimensionsLowerLimit { get; set; } = 500;

        public override double CalculatePriceByDimension(double dimension)
        {
            if (dimension >= DimensionsLowerLimit && dimension <= 1000) return 9.50;
            if (dimension > 1000 && dimension <= 2000) return 19.50;
            if (dimension > 2000 && dimension <= 5000) return 48.50;
            if (dimension > 5000) return 147.50;
            return 0;
        }

        public override double CalculatePriceByWeight(double weight)
        {
            if (weight >= WeightLowerLimit && weight <= 20) return 16.99;
            if (weight > 20 && weight <= 30) return 33.99;
            if (weight > 30)
            {
                var newWeight = weight - 25;
                return 43.99 + newWeight * 0.41;
            }
            return 0;
        }
    }
}
