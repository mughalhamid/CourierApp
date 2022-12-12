namespace IconApp.Model
{
    public class PackageInput
    {
        public Dimension Dimension { get; set; }
        public int Weight { get; set; }
        
    }

    public class PackageCourier
    {
        public PackageInput Package { get; set; }
        public string CourierName { get; set; }
        public string DimensionsValidationMessage { get; set; }
        public string WeightValidationMessage { get; set; }
        public double PriceByDimension { get; set; }
        public double PriceByWeight { get; set; }
        public bool IsValid { get { return FinalPrice > 0; } }
        public double FinalPrice
        {
            get
            {
                return PriceByWeight > PriceByDimension ? PriceByWeight : PriceByDimension;
            }
        }
    }



    public class Dimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public int Value { get { return Width * Height * Depth; } }

    }
}
