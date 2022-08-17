using NUnit.Framework;
using Task1.Components;
using Task1.Products;

namespace Task1.Tests
{
    public class Tests
    {
        private Bread _bread;

        [SetUp]
        public void Setup()
        {
            _bread = new Bread
            {
                Compounds =
                {
                    new Flour(50, 100),
                    new Water(0, 0),
                    new Salt(10, 10),
                }
            };
        }

        [Test]
        public void Test1()
        {
            // arrange
            int expected = 72;

            // act
            var actual = _bread.ProductPrice;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}