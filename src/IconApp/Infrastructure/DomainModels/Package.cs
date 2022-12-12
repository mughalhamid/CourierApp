namespace IconApp.DomainModels
{
    public class Package : IDomainEntity
    {
        public int Id { get; set; }        
        public int Dimension { get; set; }
        public int Weight { get; set; }
        public string CourierName { get; set; }
        public double FinalPrice { get; set; }
    }
}
