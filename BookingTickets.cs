using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class BookingTickets
    {
        // Shows the final ticket
        public static string FinalTicket(string num1, string num2 /*string Title, string Length, string AR, string DT, string Screen, string Type, string Seats, string Price, int Screen1, int Seats1*/)
        {
            Console.Clear();
            Console.WriteLine();
            //Console.Write(Title + " \n" + Length + " \n" + AR + " \n" + DT + " \n" + Screen + " \n" + Type + " \n" + Seats + " \n" + Price);
            //Console.WriteLine();
            //Console.WriteLine("=======================================");
            //Console.WriteLine();
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine();
            Console.WriteLine("[1] CONFIRM BOOKING");
            Console.WriteLine("[2] MENU");
            int choice = int.Parse(num1/*Console.ReadLine()*/);

            if (choice == 1)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Booking Confirmed!");
                Console.WriteLine();
                return "1st - 1 - ACCEPTED - Booking Confirmed";
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine();
                //Console.Write(Title + " \n" + Length + " \n" + AR + " \n" + DT + " \n" + Screen + " \n" + Type + " \n" + Seats + " \n" + Price);
                //Console.WriteLine();
                //Console.WriteLine("=======================================");
                //Console.WriteLine();
                Console.WriteLine("ARE YOU SURE?");
                Console.WriteLine();
                Console.WriteLine("[1] YES");
                Console.WriteLine("[2] NO");
                int choice2 = int.Parse(num2/*Console.ReadLine()*/);

                if (choice2 == 1)
                {
                    return "2nd - 1 - ACCEPTED - Back to Main Menu";
                }
                else if (choice2 == 2)
                {
                    //FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                    return "2nd - 2 - ACCEPTED - FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);";
                }
                else
                {
                    //FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                    return "2nd - 3 - DENIED - FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);";
                }

            }
            else
            {
                //FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                return "1st - 3 - DENIED - FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);";
            }

        }
    }
}
