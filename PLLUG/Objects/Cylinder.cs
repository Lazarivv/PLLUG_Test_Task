
namespace PLLUG
{
    public class Cylinder:IShape
    {
        public double Height { get; set; }
        public double  Diameter { get; set; }

        public Cylinder(double height ,double diameter)
        {
            Height = height;
            Diameter = diameter;
        }

        public bool PassThroughCircle(RoundedObject robj)
        {
            //throw new NotImplementedException();
            if (robj.Diameter > Diameter)
            {
                return true;
            }
            return false;
        }

        public bool PassThroughRectangle(SimpleObject sobj)
        {
            if ((sobj.Width < sobj.Height && Diameter < sobj.Width) || 
                (sobj.Width > sobj.Height && Diameter < sobj.Height)){
                return true;
            }
            return false;
        }
    }
}
