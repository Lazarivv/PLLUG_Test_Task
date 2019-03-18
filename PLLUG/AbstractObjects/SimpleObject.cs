namespace PLLUG
{
    public class SimpleObject
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public SimpleObject(double width, double heigth)
        {
            
            Width = width;
            Height = heigth;
        }

        //public override bool IsContainCylinder(Cylinder obj)
        //{
        //    if((Width < Height && obj.Radius*2 < Width)||(Width > Height && obj.Radius * 2 < Height))
        //    {
        //        return true;
        //    }
        //    return false;

        //    //throw new System.NotImplementedException();
        //}


        //public override bool IsContainRefrigerator(Refrigerator obj)
        //{
        //    if ((obj.MinSide1 < Height && obj.MinSide2 < Width) || (obj.MinSide2 < Height && obj.MinSide1 < Width))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
            
        //}
    }
    public abstract class Subject
    {
        //public abstract bool IsContainRefrigerator(Refrigerator obj);

        //public abstract bool IsContainCylinder(Cylinder obj);

    }
}
