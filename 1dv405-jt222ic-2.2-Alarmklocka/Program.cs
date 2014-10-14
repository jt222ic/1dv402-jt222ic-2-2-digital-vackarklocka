using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv405_jt222ic_2._2_Alarmklocka
{
    class Program
    {
        static void Main(string[] args)
        {
            //// test av standard konstruktorn test 1 ///
            AlarmClock test = new AlarmClock();
            ViewTestHeader("test 1.\nTest av standard konstruktorn");                                        //// test är objektet
            Console.WriteLine(test.ToString());
            // test 2 /// 2 parameter ////
            AlarmClock test2 = new AlarmClock(9, 42);
            ViewTestHeader("test 2.\nTest av standard konstruktorn");
            Console.WriteLine(test2.ToString());


            ////test 3 //// 4 parameter ///
            AlarmClock test3 = new AlarmClock(13, 24, 7, 23);
            ViewTestHeader("test 3. \nTest av standard konstruktorn");
            Console.WriteLine(test3.ToString());

            // 3 konstruktorer 2 metoder 1 fält med alla variablar för att få fram 3 första metoden//
            // omg så jobbig........ 
        
             //början av test 4 //
            AlarmClock test4 = new AlarmClock(23, 58, 7, 5);
            ViewTestHeader("Test 4: test utav TickTock Metoden så att klockan går 13 minuter.\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║ Väckarklocka, 13 gånger                                      ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝ ");
            Console.ResetColor();
            Run(test4,13);                     // visar att jag körs 13 gånger


            //test 5//
            AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("Test 5: test slå av alarmet\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║ Väckarklocka, 6gånger                                        ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝ ");
            Console.ResetColor();
            Run(test5,6);

            //test 6 //
            
            AlarmClock test6 = new AlarmClock();
            ViewTestHeader("Test 6: Test så att man inte kan ange för höga variabler.\n");


            try
            {
                test6.Hour = 45;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }

            try
            {
                test6.Minute = 70;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }

            try
            {
                test6.AlarmHour = 42;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
            try
            {
                test6.AlarmMinute = 70;
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
             ViewTestHeader("Test 7: Test som kollar så att när tid/ alarmtid blir tilldelade felaktiga värden.\n");
            try
            {
                AlarmClock test7 = new AlarmClock(42, 0);
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
            try
            {
                AlarmClock test7 = new AlarmClock(0, 0, 42, 0);
            }
            catch (ArgumentException failure)
            {
                ViewErrorMessage(failure.Message);
            }
        

        }
        static void Run(AlarmClock test45, int minutes)   // metoden för TICK-TOCK
        {
            for (int i = 0; minutes > i; ++i)
            {                         //döptes test 45 hämtas från test 4 och 5
                if (test45.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("♫");
                    Console.WriteLine(test45.ToString() + "Tjut tjut tjut!");
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.WriteLine(test45.ToString());
                }

            }

        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void ViewTestHeader(string header)      /// 2 metoder för att kunna skriva fram test 1,2 ,3
        {                                                      /// string metoden och override metoden
            Console.WriteLine();
            /// metod för att skriva de 3 första testerna
            Console.WriteLine(header);

        }
    }
}
