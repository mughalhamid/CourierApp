using Arch.EntityFrameworkCore;
using IconApp.Infrastructure;
using IconApp.Model;
using Microsoft.Extensions.DependencyInjection;

namespace IconApp.Tests
{
    public class MaltaShipCourierTest
    {
        [Fact]
        public void Test1()
        {
            double expectedPrize = 147.5;
            var mockPackage = new PackageInput()
            {
                Dimension = new Dimension()
                {
                    Width = 40,
                    Height = 30,
                    Depth = 10
                },
                Weight = 100,
            };

            var maltaShipCourierPrice = new MaltaShipCourier().CalculatePackage(mockPackage).FinalPrice;
            Assert.Equal(maltaShipCourierPrice, expectedPrize);
        }
    }
}