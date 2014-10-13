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
            Console.WriteLine(" ║ Väckarklocka, en vacker uppfinning som alla hatar på måndag. ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝ ");
            Console.ResetColor();
            Run(test4,13);                     // visar att jag körs 13 gånger

            AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("Test 5: test slå av alarmet\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║ Väckarklocka, en vacker uppfinning som alla hatar på måndag. ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝ ");
            Console.ResetColor();
            Run(test5,6);
        }
        static void Run(AlarmClock test45, int minutes)   // metoden för TICK-TOCK
        {                                                 //döptes test 45 hämtas från test 4 och 5
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


        private static void ViewTestHeader(string header)      /// 2 metoder för att kunna skriva fram test 1,2 ,3
        {                                                      /// string metoden och override metoden
            Console.WriteLine();
            /// metod för att skriva de 3 första testerna
            Console.WriteLine(header);

        }
    }
}
