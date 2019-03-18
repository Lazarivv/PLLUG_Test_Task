namespace PLLUG
{
    public class RoundedObject
    {
        public double Radius { get; set; }


        public RoundedObject(double radius)
        {
            Radius = radius;
        }

        //public override bool IsContainCylinder(Cylinder obj)
        //{
        //    if(obj.Radius < Radius)
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        //public override bool IsContainRefrigerator(Refrigerator obj)
        //{
        //    double RefDiagonal = obj.GetMinDiagonl();

        //    if (RefDiagonal < Radius * 2)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public double GetDiametr(double Radius)
        {
            return Radius * 2;
        }


    }
}
