using System;

namespace PLLUG
{
    public static class ConsoleHelper
    {
        
        public static void ConsoleWork()
        {
           

            IShape shape = null;

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Console.WriteLine("Choose an object:\n1:Refregerator\n2:Cylinder\n3:Sphere\n");

            bool success2 = Int32.TryParse(Console.ReadLine(), out int object_num);

            if (success2)
            {
                switch (object_num)
                {
                    case 1:
                        Console.WriteLine("\nEnter parametrs for Refregerator:");
                        Console.Write("Height:");
                        //double heigth = Double.Parse(Console.ReadLine());
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Width:");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Length:");
                        double length = Convert.ToDouble(Console.ReadLine());
                        shape = new Refrigerator(height, width, length); ;
                        break;
                    case 2:
                        Console.WriteLine("\nEnter parametrs for Cylinder:");
                        Console.Write("Height:");
                        double cylinder_heigth = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Radius:");
                        double Radius = Convert.ToDouble(Console.ReadLine());
                        shape = new Cylinder(cylinder_heigth, Radius);
                        break;

                    case 3:
                        Console.WriteLine("\nEnter parametr for Sphere:");
                        Console.Write("Circumference:");
                        double circumference = Convert.ToDouble(Console.ReadLine());
                        shape = new Sphere(circumference);
                        break;

                    default:
                        Console.WriteLine("You should choose number from allowed range!! ");
                        break;
                }

                //double d = refrigerator.GetMinDiagonl();
                //Console.WriteLine("Diagonal:" +d);
            }
            
            if (shape != null)
            {
                bool res = false;

                Console.WriteLine("\nEnter type of window or door:\n1:Simple Door or Window\n2:Rounded Door or Window\n");


                bool success = Int32.TryParse(Console.ReadLine(),out int number);

                double r = 0;
                double h = 0;
                double w = 0;

                
                

                if (success)
                {
                    if (number == 2)
                    {
                        Console.Write("Enter Radius: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        RoundedObject roundedObject = new RoundedObject(r);
                        res = shape.PassThroughCircle(roundedObject);
                    }
                    else if (number == 1)
                    {
                        Console.Write("Enter Height: ");
                        h = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Width: ");
                        w = Convert.ToDouble(Console.ReadLine());
                        SimpleObject simpleObject = new SimpleObject(w,h);
                        res = shape.PassThroughRectangle(simpleObject);
                    }
                    else
                    {
                        Console.WriteLine("You should choose number from allowed range!! ");
                    }
                }
                else
                {
                    Console.WriteLine("You entered not a number!!");
                }

                Console.WriteLine(res);
            }        

            


            
            


            //try
            //{

            //}
            //catch (NullReferenceException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}        
        }
    }
}
