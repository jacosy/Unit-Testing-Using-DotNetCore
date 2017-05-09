using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Service;

 namespace Prime.UnitTests.Services
 {
     [TestClass]
     public class PrimeService_IsPrimeShould
     {
         private readonly PrimeService _primeService;

         public PrimeService_IsPrimeShould()
         {
             this._primeService = new PrimeService();
         }

         [TestMethod]
         public void IsPrime_GivenValueOf1_ReturnFalse()
         {             
             // arrange

             // act
             var result = _primeService.IsPrime(1);

             // assert
             Assert.IsFalse(result, $"1 should not be prime");
         }
     }
 }