namespace examination_2
{
    /// <summary>
    /// Shape public class
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Protected Shape constructor that takes parameter shapeType
        /// </summary>
        /// <param name="shapeType">Represents the ShapeType</param>
        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        /// <summary>
        /// Returns a boolean value representing if the shape is 3D
        /// </summary>
        /// <value>Returns true or false</value>
        public bool Is3D
        {
            get => (ShapeType == ShapeType.Cuboid || ShapeType == ShapeType.Cylinder || ShapeType == ShapeType.Sphere);
        }

        /// <summary>
        /// The ShapeType property represents the ShapeType
        /// </summary>
        /// <value>The ShapeType property gets/sets the value of the ShapeType</value>
        public ShapeType ShapeType { get; private set; }

        /// <summary>
        /// Overrides ToString method and formats a string representing the shape.
        /// </summary>
        /// <param name="format">String that determines how to format string.</param>
        /// <returns>A formatted string representing the shape</returns>
        public abstract string ToString(string format);
    }
}
