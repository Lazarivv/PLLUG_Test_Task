namespace PLLUG
{
    public abstract class SimpleObject : Subject
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public SimpleObject(double Width, double Heigth)
        {
            this.Width = Width;
            this.Height = Height;
        }


        public override bool IsContain(Refrigerator obj)
        {
            if ((obj.MinSide1 > Height && obj.MinSide2 > Width) || (obj.MinSide2 > Height && obj.MinSide1 > Width))
            {
                return true;
            }
            return false;
        }
    }
}
