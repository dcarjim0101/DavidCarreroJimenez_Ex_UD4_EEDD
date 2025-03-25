using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{    
	[TestFigure] // contiene pruebas unitarias
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;
	
	[SetUp] // es el código de inicialización
        public void SetUp()
        {
            _primeService = new PrimeService();
        }  
      	
	[Test] // es un método de prueba
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

     }
}