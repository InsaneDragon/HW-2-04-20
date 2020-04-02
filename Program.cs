using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Length:");double len=double.Parse(Console.ReadLine());
          Console.Write("Width:");double width=double.Parse(Console.ReadLine());
          Rectange MyRec=new Rectange(len,width);   
          System.Console.WriteLine(MyRec.Area);
          System.Console.WriteLine(MyRec.Perimetr);
        }
        static double AreaCalculator(double a,double b)
        {
            return a*b;
        }
        static double PerimetrCalculator(double a,double b)
        {
            return 2*(a+b);
        }
    }
    class Rectange
    {
        public double side1 { get; set; }public double side2 { get; set; }public Rectange(double a,double b){side1=a;side2=b;}
        public double Area{get{return side1*side2;}}public double Perimetr{get{return 2*(side1+side2);}}
        
    }
}
