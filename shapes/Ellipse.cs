using System;

namespace examination_2
{
    public class Ellipse : Shape2D
    {
        public Ellipse(double diameter)
        : base(ShapeType.Ellipse, diameter / 2, diameter / 2)
        {

        }
        public Ellipse(double hdiameter, double vdiameter)
        : base(ShapeType.Ellipse, hdiameter / 2, vdiameter / 2)
        {

        }

        public override double Area { get => Math.PI * (Length * Width); }
        public override double Perimeter { get => 2 * Math.PI * Math.Sqrt((Length * Length + Width * Width) / 2); }
    }
}
