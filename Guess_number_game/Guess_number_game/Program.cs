using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_number_game
{
    class Program
    {

       static  int Quess(int _intrandom)
        {
            int quess;
            try { 
            quess = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("you can put only numbers!");
                return Quess(_intrandom);
            }
      

            if (quess == _intrandom)
            {
                Console.WriteLine("Right choice");
                return 1;
            }
            if (quess < _intrandom)
            {
                Console.WriteLine("Go up!");
                return Quess(_intrandom);
            }
            if (quess > _intrandom)
            {
                Console.WriteLine("Go down!");
                return  Quess(_intrandom);
            }
            else
            {

                return Quess(_intrandom);
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("HELLO in wuess number game!");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("You need to guess number from 1 to 10");
            Console.WriteLine("If your answer wrong we will tell you is it smaller or bigger");

            Random rnd = new Random();
           // bool @continue = true;
            int intrandom = rnd.Next(1, 10);
            Quess(intrandom);
            // Console.WriteLine(intrandom);
            //do
            //{
            //    int quess;
            //    quess = Convert.ToInt32(Console.ReadLine());

            //    if (quess == intrandom)
            //    {
            //        Console.WriteLine("Right choice");
            //        @continue = false;
            //    }
            //    if (quess < intrandom)
            //    {
            //        Console.WriteLine("Go up!");
            //    }
            //    if (quess > intrandom)
            //    {
            //        Console.WriteLine("Go down!");
            //    }
            //}
            //while (@continue);

            Console.ReadKey();

        }
    }
}
