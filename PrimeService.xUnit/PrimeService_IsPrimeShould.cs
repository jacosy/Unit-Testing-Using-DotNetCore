using System;
using Xunit;
using Prime.Service;

namespace PrimeService.xUnit
{
    public class PrimeService_IsPrimeShould
    {
        private readonly Prime.Service.PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new Prime.Service.PrimeService();            
        }

        [Fact]
        public void IsPrime_GivenValueOf1_ReturnFalse()
        {
            // arrange

            // act
            var result = _primeService.IsPrime(1);

            // assert
            Assert.False(result, $"1 should not be prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_GivenValuesLessThan2_ReturnFalse(int value)
        {
            // arrange

            // act
            var result = _primeService.IsPrime(value);
            
            // assert
            Assert.False(result, $"{value} should not be prime");
         }
    }
}
