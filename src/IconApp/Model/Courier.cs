namespace IconApp.Model
{
    public abstract class Courier
    {
        protected virtual string CourierName { get; set; } = "Courier";
        protected virtual int DimensionsUpperLimit { get; set; } = 0;
        protected virtual int DimensionsLowerLimit { get; set; } = 1;
        protected virtual int WeightUpperLimit { get; set; } = 0;
        protected virtual int WeightLowerLimit { get; set; } = 1;

        public abstract double CalculatePriceByDimension(double dimension);
        public abstract double CalculatePriceByWeight(double weight);


        public PackageCourier CalculatePackage(PackageInput packageInput)
        {
            PackageCourier packageCourier = new()
            {
                Package = packageInput,
                CourierName = CourierName
            };

            bool isValidDimensions = false;
            bool isValidWeight = false;

            if (packageInput.Dimension.Value >= DimensionsLowerLimit)
            {
                if (DimensionsUpperLimit == 0 || packageInput.Dimension.Value <= DimensionsUpperLimit)
                {
                    isValidDimensions = true;
                }
            }

            if (WeightLowerLimit > 0 && packageInput.Weight >= WeightLowerLimit)
            {
                if (WeightUpperLimit == 0 || packageInput.Weight <= WeightUpperLimit)
                {
                    isValidWeight = true;
                }
            }

            if (!isValidDimensions || !isValidWeight)
            {
                return packageCourier;
            }

            packageCourier.PriceByDimension = CalculatePriceByDimension(packageInput.Dimension.Value);
            packageCourier.PriceByWeight = CalculatePriceByWeight(packageInput.Weight);

            return packageCourier;
        }

    }
}
