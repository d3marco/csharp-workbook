using System;

namespace Enum
{
    enum WeekDays
    {
        MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When is your birthday?");
            string birthDay = Console.ReadLine();
            // Console.WriteLine("Red + Yellow = "+primaryCombined);
        }
        public static string Age(this HtmlHelper helper, DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age.ToString();
        }
    }
}
