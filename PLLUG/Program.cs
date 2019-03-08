using PLLUG.Objects;
using System;

namespace PLLUG
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            Console.WriteLine("Enter type of window or door:\n1:Door\n2:Rounded Door\n3:Window\n4:Rounded Window\n");

           
            bool success = Int32.TryParse(Console.ReadLine(), out number);

            double r = 0;
            double h = 0;
            double w = 0;            
            


            Subject subject =null;
            if (success)
            {
                if (number % 2 == 0)
                {
                    Console.Write("Enter Radius: ");
                    r = Double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Enter Height: ");
                    h = Double.Parse(Console.ReadLine());
                    Console.Write("Enter Width: ");
                    w = Double.Parse(Console.ReadLine());
                }
                


                switch (number)
                {
                    case 1:
                        subject = new Door(w, h);
                        break;
                    case 2:
                        subject = new RoundedDoor(r);
                        break;
                    case 3:
                        subject = new Window(w, h);
                        break;
                    case 4:
                        subject = new RoundedWindow(r);
                        break;


                    default:
                        Console.WriteLine("You should choose number from allowed range!! ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You entered not a number!!");
            }
            
            if(subject != null)
            {
                Console.WriteLine("\nEnter parametrs for Refregerator:");
                Console.Write("Height:");
                double Heigth = Double.Parse(Console.ReadLine());
                Console.Write("Width:");
                double Width = Double.Parse(Console.ReadLine());
                Console.Write("Length:");
                double Length = Double.Parse(Console.ReadLine());


                Refrigerator refrigerator = new Refrigerator(Heigth, Width, Length);

                //double d = refrigerator.GetMinDiagonl();
                //Console.WriteLine("Diagonal:" +d);

                bool res = subject.IsContain(refrigerator);
                Console.WriteLine(res);
            }
            
            
            //try
            //{
               
            //}
            //catch (NullReferenceException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}          
                        

            Console.ReadLine();
        }
    }                    
         
}   
    

   


   

    


      


