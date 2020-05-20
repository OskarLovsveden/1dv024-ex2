using System;

namespace examination_2
{
    /// <summary>
    /// Ellipse public class that inherits from Shape2D
    /// </summary>
    public class Ellipse : Shape2D
    {
        /// <summary>
        /// Constructor that takes parameter diameter
        /// </summary>
        /// <param name="diameter">Represents the diameter</param>
        public Ellipse(double diameter)
        : base(ShapeType.Ellipse, diameter, diameter)
        { }

        /// <summary>
        /// Constructor that takes parameters hdiameter and vdiameter
        /// </summary>
        /// <param name="hdiameter">Represents the hdiameter</param>
        /// <param name="vdiameter">Represents the vdiameter</param>
        public Ellipse(double hdiameter, double vdiameter)
        : base(ShapeType.Ellipse, hdiameter, vdiameter)
        { }

        /// <summary>
        /// The Area property represents the area of the Ellipse
        /// </summary>
        /// <value>The Area property gets the value of the Ellipse area</value>
        public override double Area
        {
            get
            {
                double a = Length / 2d;
                double b = Width / 2d;
                return Math.PI * (a * b);
            }
        }

        /// <summary>
        /// The Perimeter property represents the perimeter of the Ellipse
        /// </summary>
        /// <value>The Perimeter property gets the value of the Ellipse perimeter</value>
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
