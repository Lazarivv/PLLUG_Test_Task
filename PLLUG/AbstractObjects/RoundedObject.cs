namespace PLLUG
{
    public abstract class RoundedObject : Subject
    {
        public double Radius { get; set; }


        public RoundedObject(double Radius)
        {
            this.Radius = Radius;

        }

        public override bool IsContain(Refrigerator obj)
        {
            double RefDiagonal = obj.GetMinDiagonl();

            if (RefDiagonal < Radius * 2)
            {
                return true;
            }
            return false;
        }

        public double GetDiametr(double Radius)
        {
            return Radius * 2;
        }


    }
}
