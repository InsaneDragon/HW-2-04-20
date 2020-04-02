using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////1
            Console.Write("Length:"); double len = double.Parse(Console.ReadLine());
            Console.Write("Width:"); double width = double.Parse(Console.ReadLine());
            Rectange MyRec = new Rectange(len, width);
            System.Console.WriteLine(MyRec.Area);
            System.Console.WriteLine(MyRec.Perimetr);
            ///////////////////////////////////////////////////////////////////2
            System.Console.WriteLine("////////////////////////////////////2");
            Console.Write("Author:"); string Author = Console.ReadLine();
            Console.Write("Title:"); string Title = Console.ReadLine();
            Console.Write("Content:"); string Content = Console.ReadLine();
            Book NewBook = new Book
            {
                Author = Author,
                Title = Title,
                Content = Content
            };
            Console.ForegroundColor = ConsoleColor.Blue;
            Book.Show(Author);
            Console.ForegroundColor = ConsoleColor.Red;
            Book.Show(Title);
            Console.ForegroundColor = ConsoleColor.Green;
            Book.Show(Content);
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("//////////////////////////////////////////////////////3");
            System.Console.WriteLine("1.SuperMan");
            System.Console.WriteLine("2.SpiderMan");
            System.Console.WriteLine("3.BatMan");
            System.Console.Write("Choose Person(Write His Number):");
            int num=int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:{var NewHuman=new Human{Behaviour="Good",Condition="Amazing"};System.Console.WriteLine($"You choosed SuperMan his Behaviour is {NewHuman.Behaviour} and its  Condition is {NewHuman.Condition}");}break;
                case 2:{var NewHuman=new Human{Behaviour="Bad",Condition="Great"};System.Console.WriteLine($"You choosed SpiderMan his Behaviour is {NewHuman.Behaviour} and its  Condition is {NewHuman.Condition}");}break;
                case 3:{var NewHuman=new Human{Behaviour="Amazing",Condition="Ok"};System.Console.WriteLine($"You choosed Batman his Behaviour is {NewHuman.Behaviour} and its  Condition is {NewHuman.Condition}");}break;
            }

        }
        static double AreaCalculator(double a, double b)
        {
            return a * b;
        }
        static double PerimetrCalculator(double a, double b)
        {
            return 2 * (a + b);
        }
    }
    class Rectange
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectange(double a, double b) { side1 = a; side2 = b; }
        public double Area { get { return side1 * side2; } }
        public double Perimetr { get { return 2 * (side1 + side2); } }

    }
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public static void Show(string Text)
        {
            System.Console.WriteLine(Text);
        }

    }
    class Human
    {
        public string Behaviour { get; set; }
        public string Condition { get; set; }
    }

}
