using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestingClass
    {
        public static void TestMenu()
        {
            
            Console.Clear();
            string menu1 = "1";
            string menu2 = "2";
            string menu3 = "3";
            var result1 = Program.Menu(menu1);
            Console.Clear();
            var result2 = Program.Menu(menu2);
            Console.Clear();
            var result3 = Program.Menu(menu3);
            Console.Clear();
            Console.WriteLine("Menu - Test Result 1: Sent '1' Returned " + result1);
            Console.WriteLine("Menu - Test Result 2: Sent '2' Returned " + result2);
            Console.WriteLine("Menu - Test Result 3: Sent '3' Returned " + result3);
            Console.ReadLine();
            TestHelp();
        }

        public static void TestHelp()
        {
            Console.Clear();
            string help1 = "1";
            string help2 = "2";
            var result1 = Program.Help(help1);
            Console.Clear();
            var result2 = Program.Help(help2);
            Console.Clear();
            Console.WriteLine("Help - Test Result 1: Sent '1' Returned " + result1);
            Console.WriteLine("Help - Test Result 2: Sent '2' Returned " + result2);
            Console.ReadLine();
            TestFilms();
        }

        public static void TestFilms()
        {
            Console.Clear();
            string films1 = "1";
            string films2 = "2";
            string films3 = "3";
            string films4 = "4";
            var result1 = BookingFilms.Films(films1);
            Console.Clear();
            var result2 = BookingFilms.Films(films2);
            Console.Clear();
            var result3 = BookingFilms.Films(films3);
            Console.Clear();
            var result4 = BookingFilms.Films(films4);
            Console.Clear();
            Console.WriteLine("Films - Test Result 1: Sent '1' Returned " + result1);
            Console.WriteLine("Films - Test Result 2: Sent '2' Returned " + result2);
            Console.WriteLine("Films - Test Result 3: Sent '3' Returned " + result3);
            Console.WriteLine("Films - Test Result 4: Sent '4' Returned " + result4);
            Console.ReadLine();
            TestSeats();
        }

        public static void TestSeats()
        {
            Console.Clear();
            string seats1 = "1";
            string seats2 = "2";
            string seats3 = "3";
            var result1 = BookingFilms.Seats(seats1);
            Console.Clear();
            var result2 = BookingFilms.Seats(seats2);
            Console.Clear();
            var result3 = BookingFilms.Seats(seats3);
            Console.Clear();
            Console.WriteLine("Seats - Test Result 1: Sent '1' Returned " + result1);
            Console.WriteLine("Seats - Test Result 2: Sent '2' Returned " + result2);
            Console.WriteLine("Seats - Test Result 3: Sent '3' Returned " + result3);
            Console.ReadLine();
            TestStandard();
        }

        public static void TestStandard()
        {
            Console.Clear();
            string standard1 = "1";
            var result1 = BookingSeats.Standard(standard1);
            Console.Clear();
            Console.WriteLine("Standard - Test Result 1: Sent '1' Returned " + result1);
            Console.ReadLine();
            TestVIP();
        }

        public static void TestVIP()
        {
            Console.Clear();
            string vip1 = "1";
            var result1 = BookingSeats.VIP(vip1);
            Console.Clear();
            Console.WriteLine("VIP - Test Result 1: Sent '1' Returned " + result1);
            Console.ReadLine();
            TestTicket();
        }

        public static void TestTicket()
        {
            Console.Clear();
            string placeholder1 = "2";
            string placeholder2 = "0";
            string ticket11 = "1";
            string ticket13 = "3";
            string ticket21 = "1";
            string ticket22 = "2";
            string ticket23 = "3";
            var result1 = BookingTickets.FinalTicket(ticket11, placeholder2);
            Console.Clear();
            var result2 = BookingTickets.FinalTicket(ticket13, placeholder2);
            Console.Clear();
            var result3 = BookingTickets.FinalTicket(placeholder1, ticket21);
            Console.Clear();
            var result4 = BookingTickets.FinalTicket(placeholder1, ticket22);
            Console.Clear();
            var result5 = BookingTickets.FinalTicket(placeholder1, ticket23);
            Console.Clear();
            Console.WriteLine("FinalTicket - Test Result 1.1: Sent '1, 0' Returned " + result1);
            Console.WriteLine("FinalTicket - Test Result 1.3: Sent '3, 0' Returned " + result2);
            Console.WriteLine("FinalTicket - Test Result 2.1: Sent '2, 1' Returned " + result3);
            Console.WriteLine("FinalTicket - Test Result 2.2: Sent '2, 2' Returned " + result4);
            Console.WriteLine("FinalTicket - Test Result 2.3: Sent '2, 3' Returned " + result5);
            Console.ReadLine();
        }
    }
}
