namespace ShapesTestTask
{
    public class Triangle : ShapeBase
    {
        public double Side1 { get;}
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Side value has to be greater than zero");

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                throw new ArgumentException("Impossible triangle");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double GetArea()
        {
            var halfPerimeter = (Side1 + Side2 + Side3) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
        }

        public bool IsRightTriangle()
        {
            if (Side1 > Side2 && Side1 > Side3)
                return Side1 * Side1 == Side2 * Side2 + Side3 * Side3;
            else if (Side2 > Side3)
                return Side2 * Side2 == Side1 * Side1 + Side3 * Side3;
            else
                return Side3 * Side3 == Side1 * Side1 + Side2 * Side2;
        }
    }
}
