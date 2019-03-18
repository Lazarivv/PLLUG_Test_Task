namespace PLLUG
{
    interface IShape
    {
        bool PassThroughCircle(RoundedObject robj);
        bool PassThroughRectangle(SimpleObject sobj);
    }
}
