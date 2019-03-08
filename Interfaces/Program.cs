using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    enum Season : byte
    {
        Winter = 250,
        Spring,
        Summer,
        Autumn
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            byte c =(byte)( a + b);

            Console.WriteLine(c);


            Console.WriteLine(Season.Summer);

           // MyClass myClass = new MyClass();
           //// myClass.Sum = 1000;


           // SampleClass sc = new SampleClass();
           // IControl ctrl = (IControl)sc;
           // ISurface srfc = (ISurface)sc;

           // // The following lines all call the same method. 
           // sc.Paint();
           // ctrl.Paint();
           // srfc.Paint();
            Console.ReadKey();
        }
    }
    interface A
    {
        void f();
    }

    interface B
    {
        void f();
    }

    class C : A, B
    {
        void A.f() { }
        void B.f() { }
    }

    interface IControl
    {
        void Paint();
    }
    interface ISurface
    {
        void Paint();
    }
    class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method.  
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }
}
