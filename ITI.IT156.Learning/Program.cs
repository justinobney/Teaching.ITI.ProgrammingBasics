using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.IT156.Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = "justin".ToUpper() == "JUSTIN";
            Console.WriteLine("isTrue ::: {0}", isTrue);

            bool isFalse = "Programming" == "Boring? Difficult?";
            Console.WriteLine("Programming == Boring? Difficult? ::: {0}", isFalse);

            Util myUtil = new Util();
            if (Util.IsWednesday() && myUtil.IsNightTime())
            {
                Console.WriteLine("Students are here...");
            }


            Console.ReadLine();
        }
    }

    public class Util
    {
        public bool IsNightTime()
        {
            Console.WriteLine("Checking if it is night time...");
            return DateTime.Now.Hour > 17;
        }

        public static bool IsWednesday()
        {
            Console.WriteLine("Checking if it is Wednesday...");
            return DateTime.Now.DayOfWeek == DayOfWeek.Wednesday;
        }
    }
}
