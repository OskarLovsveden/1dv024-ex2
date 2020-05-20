namespace examination_2
{
    /// <summary>
    /// Cylinder public class that inherits from Shape3D
    /// </summary>
    public class Cylinder : Shape3D
    {
        /// <summary>
        /// Constructor that takes parameters hdiameter, vdiameter and height
        /// </summary>
        /// <param name="hdiameter">Represents the hdiameter</param>
        /// <param name="vdiameter">Represents the vdiameter</param>
        /// <param name="height">Represents the height</param>
        public Cylinder(double hdiameter, double vdiameter, double height)
        : base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        { }
    }
}
