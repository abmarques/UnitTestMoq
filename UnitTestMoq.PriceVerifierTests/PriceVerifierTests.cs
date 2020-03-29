using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestMoq.PriceVerifier;

namespace UnitTestMoq.PriceVerifierTests
{
    [TestClass]
    public class PriceVerifierTests
    {
        [TestMethod]
        public void ValidateCheapProductPrice()
        {
            //arrange
            Product cheapProduct = new Product()
            {
                Price = 35
            };

            Mock<IProductPriceVerifier> mock = new Mock<IProductPriceVerifier>();
            mock.Setup(m => m.VerifyProductPrice(cheapProduct)).Returns("Product cheap!");
            ProductPriceVerifier verify = new ProductPriceVerifier();

            //act
            var expectedResult = mock.Object.VerifyProductPrice(cheapProduct);
            var result = verify.VerifyProductPrice(cheapProduct);

            //assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ValidateAverageProductPrice()
        {
            //arrange
            Product averageProduct = new Product()
            {
                Price = 55
            };

            Mock<IProductPriceVerifier> mock = new Mock<IProductPriceVerifier>();
            mock.Setup(m => m.VerifyProductPrice(averageProduct)).Returns("Product at average price!");
            ProductPriceVerifier verify = new ProductPriceVerifier();

            //act
            var expectedResult = mock.Object.VerifyProductPrice(averageProduct);
            var result = verify.VerifyProductPrice(averageProduct);

            //assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ValidateExpensiveProductPrice()
        {
            //arrange
            Product expensiveProduct = new Product()
            {
                Price = 200
            };

            Mock<IProductPriceVerifier> mock = new Mock<IProductPriceVerifier>();
            mock.Setup(m => m.VerifyProductPrice(expensiveProduct)).Returns("Product expensive!");
            ProductPriceVerifier verify = new ProductPriceVerifier();

            //act
            var expectedResult = mock.Object.VerifyProductPrice(expensiveProduct);
            var result = verify.VerifyProductPrice(expensiveProduct);

            //assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
