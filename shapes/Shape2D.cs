using System;

namespace examination_2
{
    /// <summary>
    /// Public abstract class Shape2D that inherits from Shape
    /// </summary>
    public abstract class Shape2D : Shape
    {
        /// <summary>
        /// Private field representing the length
        /// </summary>
        private double _length;

        /// <summary>
        /// Private field representing the width
        /// </summary>
        private double _width;

        /// <summary>
        /// Protected constructor that takes parameters shapeType, length and width
        /// </summary>
        /// <param name="shapeType">Represents the ShapeType</param>
        /// <param name="length">Represents the length</param>
        /// <param name="width">Represents the width</param>
        protected Shape2D(ShapeType shapeType, double length, double width)
        : base(shapeType)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// The Length property represents the length of the Shape2D
        /// </summary>
        /// <value>The Length property gets/sets the value of the Shape2D length</value>
        public double Length
        {
            get => _length;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Length cannot be 0 or less.");
                _length = value;
            }
        }

        /// <summary>
        /// The Width property represents the width of the Shape2D
        /// </summary>
        /// <value>The Width property gets/sets the value of the Shape2D width</value>
        public double Width
        {
            get => _width;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Width cannot be 0 or less.");
                _width = value;
            }
        }

        /// <summary>
        /// The Area property represents the area of the Shape2D
        /// </summary>
        /// <value>The Area property gets the value of the Shape2D area</value>
        public abstract double Area { get; }

        /// <summary>
        /// The Perimeter property represents the perimeter of the Shape2D
        /// </summary>
        /// <value>The Perimeter property gets the value of the Shape2D perimeter</value>
        public abstract double Perimeter { get; }

        /// <summary>
        /// Ovverides the ToString method and returns a formatted string representing the shape
        /// </summary>
        /// <returns>A formatted string representing the shape</returns>
        public override string ToString() => $"Längd : {_length:F1}\nBredd : {_width:F1}\nOmkrets : {Perimeter:F1}\nArea : {Area:F1}";

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
                    return $"{ShapeType} {_length:F1} {_width:F1} {Perimeter:F1} {Area:F1}";
                default:
                    throw new FormatException("Could not format the text representation.");
            }
        }
    }
}
