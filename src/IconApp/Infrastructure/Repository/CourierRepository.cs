using IconApp.DomainModels;

namespace IconApp.Infrastructure.Repository
{
    public class CourierRepository : ICourierRepository
    {
        private readonly AppDbContext _dbContext;

        public CourierRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async void SavePackage(string CourierName, int Dimension, double FinalPrice, int Weight)
        {
            _dbContext.Packages.Add(new Package()
            {
                CourierName = CourierName,
                Dimension = Dimension,
                FinalPrice = FinalPrice,
                Weight = Weight
            });

            _dbContext.SaveChanges();
        }
    }
}
