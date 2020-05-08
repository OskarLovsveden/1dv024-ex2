using System;

namespace examination_2
{
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        public Shape2D(ShapeType shapeType, double length, double width)
        : base(shapeType)
        {
            Length = length;
            Width = width;
        }
        public double Length
        {
            get => _length;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Length cannot be 0 or less.");
                _length = value;
            }
        }
        public double Width
        {
            get => _width;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Width cannot be 0 or less.");
                _width = value;
            }
        }
        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        public override string ToString() => $"Längd : {_length:F1}\nBredd : {_width:F1}\nOmkrets : {Perimeter:F1}\nArea : {Area:F1}";

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
