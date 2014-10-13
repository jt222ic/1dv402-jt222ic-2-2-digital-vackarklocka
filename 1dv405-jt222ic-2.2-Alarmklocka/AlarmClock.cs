using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv405_jt222ic_2._2_Alarmklocka
{
    class AlarmClock
    {              //// fält ////
        private int _alarmHour;                /// klasser indelad i egenskaper
        private int _alarmMinute;            //// underline för att förtydliga att 
        private int _hour;                   ////  variabeln tillhör private klass.
        private int _minute;



        public int AlarmHour        /// klass gör att man använder sig av private fält och göra dem till publika
        {
            get { return _alarmHour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Alarmtimmen ligger inte i intervallet 0-23 ");
                }
                _alarmHour = value;
            }
        }
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Alarmminuten ligger inte i intervallet 0-59");
                }
                _alarmMinute = value;
            }


        }
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("timmer ligger inte i intervallet 0-23");
                }

                _hour = value;
            }


        }
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("minuten ligger inte i intervallet 0-59");
                }
                _minute = value;



            }

        }


        ///kontruktorer samlas sig värden från egenskaper ////

        public AlarmClock()
            : this(0,0)   /// körs två parameter
        {
            /// tom eftersom uppgiften säger det. DEt ska inte upprepas med sig själv
        }


        public AlarmClock(int hour, int minute)
            : this(hour, minute,0,0)  /// körs för 4 parameter
        {
            ///tom kropp         
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            AlarmHour = alarmHour;   /// public klasser hämtar värden/egenskaper från kontruktor 
            AlarmMinute = alarmMinute;
            Hour = hour;
            Minute = minute;

            
                                             ///hämtar in världen från egenskaper
        }
        // metoden ansvarar om minuternas värden ökar med 1 //
        // övergår till True om värden överstämmer sig med Alarmtiden//
        public bool TickTock()
        {
                                    ///
            if (Minute < 59)       /// lopar tiden det ska gå 13 gånger.
            {
                ++Minute;       // om minuten är mindre än 59 plussas 1 
            }
            else
            {
                Minute = 0;        
                if (Hour < 23)
                {
                    ++Hour;
                    
                }
                else
                {
                    Hour = 0;
                }                   // om minuten är över 59 blir värdet 0 igen
            }                       // digital klockan har inte 24 i visning alltså 0 igen
            return AlarmHour == Hour && AlarmMinute == Minute;  //  returnera världet


        }
        public override string ToString()      ///// override över basmetoden  klass object som heter redan tostring
        {                                      //// detta är en Metod // blanda det inte med egenskaper 

            StringBuilder Display = new StringBuilder();


            Display.AppendFormat("{0,5}:0{1} <{2}:0{3}>", Hour, Minute, AlarmHour, AlarmMinute);

            if (Minute >= 10)
            {
                Display.Remove(6, 1);
            }
                                                 
            if (AlarmMinute >= 10)            /// lite osäker hur det fungerar
            {
                Display.Remove(12, 1);
            }

            return Display.ToString();

            /// alla konstruktor har samma namn som klassen// 
            /// metodens roll att returna en sträng som representeras värdet av en instans av klassen AlarmClock
        }
    }
}
