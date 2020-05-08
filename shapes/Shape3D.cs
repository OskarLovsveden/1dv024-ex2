using System;

namespace examination_2
{
    public abstract class Shape3D : Shape
    {
        protected Shape2D _baseShape;

        private double _height;

        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
        : base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Height cannot be 0 or less.");
                _height = value;
            }
        }

        public virtual double MantelArea { get => _baseShape.Perimeter * _height; }

        public virtual double TotalSurfaceArea { get => MantelArea + 2 * _baseShape.Area; }

        public virtual double Volume { get => _baseShape.Area * _height; }

        public override string ToString() =>
        $"Längd : {_baseShape.Length:F1}\nBredd : {_baseShape.Width:F1}\nHeight : {Height:F1}\nMantelarea : {MantelArea:F1}\nBegränsningsarea : {TotalSurfaceArea:F1}\nVolym : {Volume:F1}";

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
