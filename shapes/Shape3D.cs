using System;

namespace examination_2
{
    public abstract class Shape3D : Shape
    {
        Shape2D _baseShape;
        private double _height;
        public Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
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
    }
}
