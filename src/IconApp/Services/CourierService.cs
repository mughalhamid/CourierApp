using IconApp.Infrastructure.Repository;
using IconApp.Model;

namespace IconApp.Services
{
    public class CourierService : ICourierService
    {
        private ICourierRepository _courierRepository { get; set; }
        public CourierService(ICourierRepository courierRepository)
        {
            _courierRepository = courierRepository;
        }

        public List<PackageCourier> GetAllPackages(PackageInput input)
        {
            var packages = new List<PackageCourier>()
            {
                new Cargo4YouCourier().CalculatePackage(input),
                new ShipFasterCourier().CalculatePackage(input),
                new MaltaShipCourier().CalculatePackage(input),
            };

            SavePackages(packages);
            return packages;
        }

        private async void SavePackages(List<PackageCourier> packages)
        {
            packages.ForEach(x =>
            {
                _courierRepository.SavePackage(x.CourierName, x.Package.Dimension.Value, x.FinalPrice, x.Package.Weight);
            });
        }
    }
}
