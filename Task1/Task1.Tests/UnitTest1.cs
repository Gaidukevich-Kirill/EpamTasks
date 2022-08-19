using NUnit.Framework;
using Task1.Components;
using Task1.Products;

namespace Task1.Tests
{
    public class Tests
    {
        private Bread _bread;
        private WhiteBread _whiteBread;
        private Baguette _baguette;

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

            _whiteBread = new WhiteBread()
            {
                Compounds =
                {
                    new Flour(40, 40),
                    new Water(0, 0),
                    new Salt(10, 10),
                    new Sugar(20, 20),
                    new Egg(20, 20),
                }
            };

            _baguette = new Baguette()
            {
                Compounds =
                {
                    new Flour(30, 30),
                    new Water(0, 0),
                    new Sugar(30, 30),
                    new Salt(10, 10),
                    new Egg(30, 30)
                }
            };
        }

        //------------------------------------------Bread------------------------------------
        [Test]
        public void TestBreadProductPrice()
        {
            // arrange
            int expected = 72;

            // act
            var actual = _bread.ProductPrice;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test] 
        public void TestBreadProductCalories()
        {
            // arrange
            int expected = 110;

            // act
            var actual = _bread.ProductCalories;

            // assert
            Assert.AreEqual(expected, actual);
        }

        //----------------------------------------------------------WhiteBread---------------------------------
        [Test]
        public void TestWhiteBreadProductPrice()
        {
            // arrange
            int expected = 99;

            // act
            var actual = _whiteBread.ProductPrice;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestWhiteBreadProductCalories()
        {
            // arrange
            int expected = 90;

            // act
            var actual = _whiteBread.ProductCalories;

            // assert
            Assert.AreEqual(expected, actual);
        }

        //------------------------------------------------------Baguette---------------------------------
        [Test]
        public void TestBaguetteProductPrice()
        {
            // arrange
            int expected = 126;

            // act
            var actual = _baguette.ProductPrice;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestBaguetteProductCalories()
        {
            // arrange
            int expected = 100;

            // act
            var actual = _baguette.ProductCalories;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}