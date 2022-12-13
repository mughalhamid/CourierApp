using Arch.EntityFrameworkCore;
using IconApp.Infrastructure;
using IconApp.Model;
using Microsoft.Extensions.DependencyInjection;

namespace IconApp.Tests
{
    public class Cargo4YouCourierTest
    {
        [Fact]
        public void Test1()
        {
            double expectedPrize = 18;
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
            var cargo4YouCourierPrice = new Cargo4YouCourier().CalculatePackage(mockPackage).FinalPrice;
            Assert.Equal(cargo4YouCourierPrice, expectedPrize);
        }
    }
}