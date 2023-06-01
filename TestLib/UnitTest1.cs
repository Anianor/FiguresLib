using FiguresLib;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void Figure_Circle()
        {
            var result = Figures.Figure(2).Square();
            Assert.AreEqual( result, Figures.Circle(2).Square());
        }
        [Test]
        public void Figure_Triangle() 
        {
            var result = Figures.Figure(3,4,5).Square();

            Assert.AreEqual( result, Figures.Triangle(3,4,5).Square());
        }



        [Test]
        public void Triangle_ValidationValues_Fail()
        {
            double x = 11, y = 1, z = 5;
            try
            {
                Figures.Triangle(x, y, z);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.Fail(ex.ToString());
            }

        }
        [Test]
        public void Triangle_ValidationValuesForNegation_Fail()
        {
            double x = -11, y = 1, z = 5;
            try
            {
                Figures.Triangle(x, y, z);

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }

        }
        [Test]
        public void CalculateTriangleTest()
        {
            double x = 3.0, y = 4.0, z = 5.0;
            var result = Figures.Triangle(x, y, z).Square();
            Assert.IsTrue(result <= 6 && result > 5.99);
        }
        [Test]
        public void CheckIfTriangle_IsThisATriangle_False()
        {
            double x = 11, y = 1, z = 5;
            var result = Figures.Triangle(x, y, z).IsThisATriangle();
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckIfTriangle_IsThisATriangle_True()
        {
            double x = 5, y = 5, z = 5;
            var result = Figures.Triangle(x, y, z).IsThisATriangle();
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckIfTriangle_IsRightTriangle_False()
        {
            double x = 5, y = 5, z = 5;
            var result = Figures.Triangle(x, y, z).IsRightTriangle();
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckIfTriangle_IsRightTriangle_True()
        {
            double x = 3, y = 4, z = 5;
            var result = Figures.Triangle(x, y, z).IsRightTriangle();
            Assert.IsTrue(result);
        }
        [Test]
        public void Circle_ValidationValuesForNegation_Fail()
        {
            double x = -3;
            try
            {
                Figures.Circle(x);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.Fail(ex.ToString());
            }

        }
        [Test]
        public void CalculateCircleTest()
        {
            var result = Figures.Circle(3).Square();
            double testResult = Math.PI * Math.Pow(3, 2);
            Assert.AreEqual(result, testResult);
        }
    }
}