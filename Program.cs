using System;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                TestingClass.TestMenu();
            }
        }

        public static string Menu(string num)
        {

            //BookingFilms Film = new BookingFilms();

            Console.WriteLine();
            Console.WriteLine("Cinema Booking System");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine();
            Console.WriteLine("[1] START");
            Console.WriteLine("[2] HELP");
            int user = int.Parse(num /*Console.ReadLine()*/);

            if (user == 1)
            {
                // FILM CHOICES
                //Film.Films();
                return "1 - ACCEPTED - Film.Films();";
            }
            else if (user == 2)
            {
                // HELP
                //Help();
                return "2 - ACCEPTED - Help();";
            }
            else
            {
                // BACK TO OPTIONS
                //Console.WriteLine();
                //Console.WriteLine("Incorrect Option");
                //Thread.Sleep(2000);
                return "3 - DENIED - Back to Main Menu";

            }

        }

        public static string Help(string num)
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Films: \n\nBLAH BLAH BLAH");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Type of Seats: \n\nBLAH BLAH BLAH");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Ticket: \n\nBLAH BLAH BLAH");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("Please choose the following option:");
            Console.WriteLine();
            Console.WriteLine("[1] BACK");
            int user = int.Parse(num /*Console.ReadLine()*/);

            if (user == 1)
            {
                // BACK TO MENU
                //Thread.Sleep(1000);
                return "1 - ACCEPTED - Back to Main Menu";
            }
            else
            {
                // BACK TO OPTIONS
                //Console.WriteLine();
                //Thread.Sleep(2000);
                //Help();
                return "2 - DENIED - Help();";
            }
        }

    }
}
