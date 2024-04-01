using ShapesTestTask;

namespace ShapesTestTaskUnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void NegativeSide1ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));

            Assert.Equal("Side value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void NegativeSide2ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(3, -4, 5));

            Assert.Equal("Side value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void NegativeSide3ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -5));

            Assert.Equal("Side value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void ZeroSide1ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));

            Assert.Equal("Side value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void ZeroSide2ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(3, 0, 5));

            Assert.Equal("Side value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void ZeroSide3ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 0));

            Assert.Equal("Side value has to be greater than zero", exception.Message);
        }

        [Fact]
        public void ImpossibleSideSumThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 7));

            Assert.Equal("Impossible triangle", exception.Message);
        }

        [Fact]
        public void GetAreaReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);

            var area = triangle.GetArea();

            Assert.Equal(6, area);
        }

        [Fact]
        public void IsRightTriangleReturnsTrueIfTriangleIsRight()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRightTriangle = triangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }

        [Fact]
        public void IsRightTriangleReturnsFalseIfTriangleIsNotRight()
        {
            var triangle = new Triangle(2, 3, 4);

            var isRightTriangle = triangle.IsRightTriangle();

            Assert.False(isRightTriangle);
        }
    }
}
