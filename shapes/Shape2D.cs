using System;

namespace examination_2
{
    abstract class Shape2D : Shape
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

        public override string ToString() => $"Längd : {_length}\nBredd : {_width}\nOmkrets : {Perimeter}\nArea : {Area}";

        public override string ToString(string format)
        {
            switch (format)
            {
                case "G":
                case "":
                case null:
                    return ToString();
                case "R":
                    return $"{ShapeType} {_length} {_width} {Perimeter} {Area}";
                default:
                    throw new FormatException();
            }
        }
    }
}
