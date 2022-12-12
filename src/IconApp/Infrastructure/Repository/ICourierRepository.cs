namespace IconApp.Infrastructure.Repository
{
    public interface ICourierRepository
    {
        void SavePackage(string CourierName, int Dimension, double FinalPrice, int Weight);
    }
}
