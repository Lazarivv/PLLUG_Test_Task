using System;

namespace PLLUG
{
    public class Sphere : IShape
    {
        public double Diameter { get; private set; }

        public double Circumference { get; set; }
        

        public Sphere(double circumference)
        {
            Circumference = circumference;
            GetDiameter();
        }

        public bool PassThroughCircle(RoundedObject robj)
        {
            if(robj.Diameter > Diameter)
            {
                return true;
            }
            return false;
        }

        public bool PassThroughRectangle(SimpleObject sobj)
        {
            if ((sobj.Width < sobj.Height && Diameter < sobj.Width) ||
                (sobj.Width > sobj.Height && Diameter < sobj.Height))
            {
                return true;
            }
            return false;
        }

        private double GetDiameter()
        {
            return Diameter = Circumference / Math.PI;
        }
    }
}
