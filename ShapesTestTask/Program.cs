using ShapesTestTask;

var circle = new Circle(1/Math.Sqrt(Math.PI));
var triangle = new Triangle(2, 3, 4);
var shapes = new List<ShapeBase> { circle, triangle };
foreach (var shape in shapes)
    Console.WriteLine(shape.GetArea());

