using ShapesTestTask;

namespace ShapesTestTaskUnitTests
{
    public class CircleTests
    {
        [Fact]
        public void NegativeRadiusThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Circle(-10));

            Assert.Equal("Radius value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void ZeroRadiusThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Circle(0));

            Assert.Equal("Radius value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void GetAreaReturnsCorrectArea()
        {
            var circle = new Circle(10);

            var area = circle.GetArea();

            Assert.Equal(Math.PI * 10 * 10, area);
        }
    }
}