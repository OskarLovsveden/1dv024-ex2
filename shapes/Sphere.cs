namespace examination_2
{
    /// <summary>
    /// Public class Sphere that inherits from Shape3D
    /// </summary>
    public class Sphere : Shape3D
    {
        /// <summary>
        /// Constructor for Sphere that takes parameter diameter
        /// </summary>
        /// <param name="diameter">Represents the diameter of Sphere</param>
        public Sphere(double diameter)
        : base(ShapeType.Sphere, new Ellipse(diameter), diameter)
        {
            Diameter = Height;
        }

        /// <summary>
        /// The Diameter property represents the diameter of the Sphere
        /// </summary>
        /// <value>The Diameter property gets/sets the value of the Sphere diameter</value>
        public double Diameter { get; set; }

        /// <summary>
        /// The MantelArea property represents the mantelarea of the Sphere
        /// </summary>
        /// <value>The MantelArea property gets the value of the Sphere mantelarea</value>
        public override double MantelArea { get => _baseShape.Area * 4d; }

        /// <summary>
        /// The TotalSurfaceArea property represents the total surfacearea of the Sphere
        /// </summary>
        /// <value>The TotalSurfaceArea property gets the value of the Sphere total surfacearea</value>
        public override double TotalSurfaceArea { get => _baseShape.Area * 4d; }

        /// <summary>
        /// The Volume property represents the volume of the Sphere
        /// </summary>
        /// <value>The Volume property gets the value of the Sphere volume</value>
        public override double Volume { get => (4 / 3d) * _baseShape.Area * (Diameter / 2d); }
    }
}