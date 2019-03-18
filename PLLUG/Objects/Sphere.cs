using System;

namespace PLLUG
{
    public class Sphere : IShape
    {
        public double Radius { get; private set; }//May change radius by Diameter

        public double Circumference { get; set; }

        public Sphere(double circumference)
        {
            Circumference = circumference;
            GetRadius();
        }



        public bool PassThroughCircle(RoundedObject robj)
        {
            if(robj.Radius > Radius)
            {
                return true;
            }
            return false;
        }

        public bool PassThroughRectangle(SimpleObject sobj)
        {
            if ((sobj.Width < sobj.Height && Radius * 2 < sobj.Width) ||
                (sobj.Width > sobj.Height && Radius * 2 < sobj.Height))
            {
                return true;
            }
            return false;
        }

        private double GetRadius()
        {
            return Radius = Circumference / Math.PI * 2;
        }
    }
}
