using System;

namespace PLLUG
{
    public class Refrigerator:IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        public Refrigerator(double height, double width, double length)
        {
            Height = height;
            Width =  width;
            Length = length;
            GetTwoMinSides();
        }
        
        public double Diagonal
        {
            get; private set;
        }

        public double MinSide1
        {
            get; private set;
        }
               
        public double MinSide2
        {
            get; private set;            
        }

        private void GetTwoMinSides()
        {

            if (Height > Length && Height > Width)
            {
                MinSide1 = Length;
                MinSide2 = Width;
            }
            else if (Width > Length && Width > Height)
            {
                MinSide1 = Length;
                MinSide2 = Height;
            }
            else
            {
                MinSide1 = Width;
                MinSide2 = Height;
            }
        }

       
        public double GetMinDiagonl()
        {
            //This method returns the diagonal of the smallest surface of refrigerator and defines  sides of the smallest plane( MinSide1, MinSide2). 
            //This is done in case when refrigerator has a non-standard shape, length is bigger than height, and so on.
            //In fact, this is method that allows us to spin refrigeration by choosing the smallest plane.

            if(MinSide1 > 0 && MinSide2 > 0)
            {
                Diagonal = Math.Sqrt(Math.Pow(MinSide1, 2) + Math.Pow(MinSide2, 2));

                return Diagonal;
            }          

            return 0;

            
        }

        public bool PassThroughCircle(RoundedObject robj)
        {
            //throw new NotImplementedException();
            double RefDiagonal = GetMinDiagonl();

            if (RefDiagonal < robj.Diameter)
            {
                return true;
            }
            return false;
        }

        public bool PassThroughRectangle(SimpleObject sobj)
        {
            if ((MinSide1 < sobj.Height && MinSide2 < sobj.Width) || (MinSide2 < sobj.Height && MinSide1 < sobj.Width))
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }
    }
}
