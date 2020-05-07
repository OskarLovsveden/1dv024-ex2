namespace examination_2
{
    abstract class Shape
    {
        Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        public bool Is3D
        {
            get => (ShapeType == ShapeType.Cuboid || ShapeType == ShapeType.Cylinder || ShapeType == ShapeType.Sphere);
        }
        public ShapeType ShapeType { get; private set; }
        public abstract string ToString(string format);
    }
}
