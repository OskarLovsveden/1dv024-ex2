using System;

namespace examination_2
{
    /// <summary>
    /// Public abstract class Shape3D inheriting from Shape
    /// </summary>
    public abstract class Shape3D : Shape
    {
        /// <summary>
        /// Protected field representing the baseshape
        /// </summary>
        protected Shape2D _baseShape;

        /// <summary>
        /// Private field representing the height
        /// </summary>
        private double _height;

        /// <summary>
        /// Protected constructor for Shape3D that takes parameters shapeType, baseShape and height
        /// </summary>
        /// <param name="shapeType">Represents the ShapeType</param>
        /// <param name="baseShape">Represents the baseshape</param>
        /// <param name="height">Represents the height</param>
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
        : base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }

        /// <summary>
        /// The Height property represents the height of the Shape3D
        /// </summary>
        /// <value>The Height property gets/sets the value of the Shape3D height</value>
        public double Height
        {
            get => _height;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Height cannot be 0 or less.");
                _height = value;
            }
        }

        /// <summary>
        /// The MantelArea property represents the mantelarea of the Shape3D
        /// </summary>
        /// <value>The MantelArea property gets the value of the Shape3D mantelarea</value>
        public virtual double MantelArea { get => _baseShape.Perimeter * _height; }

        /// <summary>
        /// The TotalSurfaceArea property represents the total surfacearea of the Shape3D
        /// </summary>
        /// <value>The TotalSurfaceArea property gets the value of the Shape3D total surfacearea</value>
        public virtual double TotalSurfaceArea { get => MantelArea + 2 * _baseShape.Area; }

        /// <summary>
        /// The Volume property represents the volume of the Shape3D
        /// </summary>
        /// <value>The Volume property gets the value of the Shape3D volume</value>
        public virtual double Volume { get => _baseShape.Area * _height; }

        /// <summary>
        /// Ovverides the ToString method and returns a formatted string representing the shape
        /// </summary>
        /// <returns>A formatted string representing the shape</returns>
        public override string ToString() =>
        $"Längd : {_baseShape.Length:F1}\nBredd : {_baseShape.Width:F1}\nHeight : {Height:F1}\nMantelarea : {MantelArea:F1}\nBegränsningsarea : {TotalSurfaceArea:F1}\nVolym : {Volume:F1}";

        /// <summary>
        /// Ovverides the ToString method and returns a formatted string representing the shape
        /// </summary>
        /// <param name="format">A string determining how to format string</param>
        /// <returns>A formatted string representing the shape</returns>
        public override string ToString(string format)
        {
            switch (format)
            {
                case "G":
                case "":
                case null:
                    return ToString();
                case "R":
                    return $"{ShapeType} {_baseShape.Length:F1} {_baseShape.Width:F1} {Height:F1} {MantelArea:F1} {TotalSurfaceArea:F1} {Volume:F1}";
                default:
                    throw new FormatException("Could not format the text representation.");
            }
        }
    }
}
