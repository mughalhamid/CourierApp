using Arch.EntityFrameworkCore;
using IconApp.Infrastructure;
using IconApp.Model;
using Microsoft.Extensions.DependencyInjection;

namespace IconApp.Tests
{
    public class ShipFasterCourierTest
    {
        [Fact]
        public void Test1()
        {
            double expectedPrize = 16.5;
            var mockPackage = new PackageInput()
            {
                Dimension = new Dimension()
                {
                    Width = 2,
                    Height = 4,
                    Depth = 4
                },
                Weight = 14,
            };
            var shipFasterCourierPrice = new ShipFasterCourier().CalculatePackage(mockPackage).FinalPrice;
            Assert.Equal(shipFasterCourierPrice, expectedPrize);        }
    }
}