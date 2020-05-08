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
                double a = Length / 2;
                double b = Width / 2;
                return Math.PI * (a * b);

            }
        }

        public override double Perimeter
        {
            get
            {

                double a = Length / 2;
                double b = Width / 2;
                return 2 * Math.PI * Math.Sqrt((a * a + b * b) / 2);
            }
        }
    }
}
