namespace examination_2
{
    public class Cuboid : Shape3D
    {

        public Cuboid(double length, double width, double height)
        : base(ShapeType.Cuboid, new Rectangle(length, width), height)
        { }
    }
}