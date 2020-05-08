using System;

namespace examination_2
{
    public class Ellipse : Shape2D
    {
        public Ellipse(double diameter)
        : base(ShapeType.Ellipse, diameter, diameter)
        { }

        public Ellipse(double hdiameter, double vdiameter)
        : base(ShapeType.Ellipse, hdiameter, vdiameter)
        { }

        public override double Area
        {
            get
            {
                double a = Length / 2d;
                double b = Width / 2d;
                return Math.PI * (a * b);

            }
        }

        public override double Perimeter
        {
            get
            {

                double a = Length / 2d;
                double b = Width / 2d;
                return 2d * Math.PI * Math.Sqrt((a * a + b * b) / 2d);
            }
        }
    }
}
