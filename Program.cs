using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 10;
            string rightanswer="iphone";//Правильный ответ
            System.Console.WriteLine("Letaet Bobrov kusaet");
            for (int i = 0; i <= tries; tries--)
            {
                System.Console.WriteLine("Answer:");
                string answer = Console.ReadLine();
                if(answer.ToLower()==rightanswer.ToLower())
                {
                    System.Console.WriteLine("Thats right answer Congratulations!!!!!!!!!!!!!!!!!");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Thats Incorrect answer");
                    System.Console.WriteLine($"You have {tries} tries");
                }
            }
        }
    }
}
