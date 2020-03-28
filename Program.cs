using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////2
            int a = 1, b = 3, sum = 0, sum2 = 0;
            for (int i = a + 1; i < b; i++)
            {
                sum += i;
                if (i % 2 == 1)
                {
                    sum2 += i;
                }
            }
            System.Console.WriteLine(sum);
            System.Console.WriteLine(sum2);

            ////////////////////////////////3
            //pryamougolnik
            for (int i = 0; i < 30; i++) { System.Console.Write("*"); }
            for (int i = 0; i <= 5; i++) { System.Console.WriteLine("*                             *"); }
            for (int i = 0; i <= 30; i++) { System.Console.Write("*"); }
            System.Console.WriteLine("");
            System.Console.WriteLine("");


            //treugolnik
            int count = 0;
            for (int i = 0; i <= 10; i++)
            {
                System.Console.Write("*");
                for (int y = 0; y <= count; y++)
                {
                    Console.Write(" ");
                }
                System.Console.Write("*");
                count += 2;
                System.Console.WriteLine();
            }
            for (int i = 0; i <= 23; i++)
            {
                System.Console.Write("*");
            }


            //treugolnik(ravnostoronniy)
            int tr = 10;
            int tr2 = 0;
            for(int y=0;y<=10;y++)
            {
            for (int i = 0; i <= tr; i++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write("*");
            for(int i = 0; i < tr2; i++)
            {
                System.Console.Write(" ");
            }
            System.Console.WriteLine("*");
            tr--;
            tr2+=2;
            }
            for(int i=0;i<=23;i++)System.Console.Write("*");

            //Romb
            int tr3 = 10;
            int tr4 = 0;
            for(int y=0;y<=5;y++)
            {
            for (int i = 0; i <= tr3; i++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write("*");
            for(int i = 0; i < tr4; i++)
            {
                System.Console.Write(" ");
            }
            System.Console.WriteLine("*");
            tr3-=2;
            tr4+=4;
            }
            tr3=0;
            tr4=20;
            for(int y=0;y<=5;y++)
            {
            for (int i = 0; i <= tr3; i++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write("*");
            for(int i = 0; i < tr4; i++)
            {
                System.Console.Write(" ");
            }
            System.Console.WriteLine("*");
            tr3+=2;
            tr4-=4;
            }

            ///////////////////////////////////4
            double money = 1000;
            double procent = 1;
            int month = 0;
            while (money <= 1100)
            {
                money += money * procent / 100;
                month++;
            }
            System.Console.WriteLine("month:" + month);
            System.Console.WriteLine("money:" + money);
        }
    }
}
