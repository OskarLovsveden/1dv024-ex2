namespace examination_2
{
    public class Sphere : Shape3D
    {
        public Sphere(double diameter)
        : base(ShapeType.Sphere, new Ellipse(diameter), diameter)
        {
            Diameter = Height;
        }

        public double Diameter { get; set; }

        public override double MantelArea { get => _baseShape.Area * 4d; }

        public override double TotalSurfaceArea { get => _baseShape.Area * 4d; }

        public override double Volume { get => (4 / 3d) * _baseShape.Area * (Diameter / 2d); }
    }
}