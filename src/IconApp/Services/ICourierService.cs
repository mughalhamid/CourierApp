using IconApp.Model;

namespace IconApp.Services
{
    public interface ICourierService
    {
        public List<PackageCourier> GetAllPackages(PackageInput input);
    }
}
