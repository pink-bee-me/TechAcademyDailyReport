using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What Course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page/step number are you on?");
            string yourPageNumber = Console.ReadLine();
            int currentPageNumber = Convert.ToInt32(yourPageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \" true\" or \"false\".");
            string helpNeeded = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpNeeded);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveFeedback = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudiedToday = Console.ReadLine();
            int numberOfHoursStudiedToday = Convert.ToInt32(hoursStudiedToday);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
           // Console.WriteLine(yourName + ", " + yourCourse + ", " + yourPageNumber);
          //  Console.ReadLine();
        }
    }
}
