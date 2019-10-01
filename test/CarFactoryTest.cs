using System;
using FluentAssertions;
using src;
using Xunit;

namespace test
{
    public class CarFactoryTest
    {
        [Theory]
        [InlineData("Electric")]
        [InlineData("electric")]
        [InlineData("eLeCtriC")]
        public void ShouldCreateElectricCarInstance(string type)
        {
            var carFactory = new CarFactory();
            var car = carFactory.CreateCar(type);

            car.Should().BeOfType<ElectricCar>();
            car.GetName().Should().Be("Electric");
        }

        [Theory]
        [InlineData("Petrol")]
        [InlineData("petrol")]
        [InlineData("pEtRoL")]
        public void ShouldCreatePetrolCarInstance(string type)
        {
            var carFactory = new CarFactory();
            var car = carFactory.CreateCar(type);

            car.Should().BeOfType<PetrolCar>();
            car.GetName().Should().Be("Petrol");
        }

        [Theory]
        [InlineData("hans")]
        [InlineData("car")]
        [InlineData("electricpetrol")]
        public void ShouldThrowNotSupportedExceptionWhenTypeIsInvalid(string type)
        {
            var carFactory = new CarFactory();
            Action getCar = () => carFactory.CreateCar(type);

            getCar.Should().ThrowExactly<NotSupportedException>();
        }
    }
}
