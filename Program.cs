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
            Title NewTitle = new Title
            {
               TextTitle=Title
            };
            Author NewAuthor = new Author
            {
               TextAuthor=Author
            };
            Content NewContent = new Content
            {
               TextContent=Content
            };
            Console.ForegroundColor = ConsoleColor.Blue;
            Book.Show(NewTitle.TextTitle);
            Console.ForegroundColor = ConsoleColor.Red;
            Book.Show(NewAuthor.TextAuthor);
            Console.ForegroundColor = ConsoleColor.Green;
            Book.Show(NewContent.TextContent);
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
    class Author
    {
        public string TextAuthor { get; set; }
        public static void Show(string Text)
        {
            System.Console.WriteLine(Text);
        }
    }
    class Book
    {
        public string TextBook { get; set; }
        public static void Show(string Text)
        {
            System.Console.WriteLine(Text);
        }
    }
    class Title
    {
        public string TextTitle { get; set; }
        public static void Show(string Text)
        {
            System.Console.WriteLine(Text);
        }
    }
    class Content
    {
        public string TextContent { get; set; }
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
