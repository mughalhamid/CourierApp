namespace IconApp.Model
{
    public class CourierService
    {
        public static List<PackageCourier> GetAllPackages(PackageInput input)
        {
            var packages = new List<PackageCourier>()
            {
                new Cargo4YouCourier().CalculatePackage(input),
                new ShipFasterCourier().CalculatePackage(input),
                new MaltaShipCourier().CalculatePackage(input),

            };

            return packages;
        }
    }
}
