
namespace PLLUG
{
    public class Cylinder:IShape
    {
        public double Height { get; set; }
        public double  Radius { get; set; }

        public Cylinder(double height ,double radius)
        {
            Height = height;
            Radius = radius;
        }

        public bool PassThroughCircle(RoundedObject robj)
        {
            //throw new NotImplementedException();
            if (robj.Radius > Radius)
            {
                return true;
            }
            return false;
        }

        public bool PassThroughRectangle(SimpleObject sobj)
        {
            if ((sobj.Width < sobj.Height && Radius * 2 < sobj.Width) || 
                (sobj.Width > sobj.Height && Radius * 2 < sobj.Height)){
                return true;
            }
            return false;
        }
    }
}
