using System;
using System.Globalization;

namespace DateTimeManagement.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreatingTimeSpan();
        }
        static void CreatingDayOfWeek()
        {
            DateTime dt = new DateTime(2022, 06, 30);
            bool isEqual = dt.DayOfWeek == DayOfWeek.Thursday;                                                                
            Console.WriteLine(isEqual);
        }
        static void CreatingTimeSpan()
        {
            System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0);
            System.DateTime newDate1 = DateTime.Now.Add(duration);
            System.Console.WriteLine("newDate 1 + 30 day:   " + newDate1);
            System.DateTime newDate2 = newDate1.AddDays(120);

            System.Console.WriteLine("newDate 2 + 120 days:   "+newDate2);
            System.Console.WriteLine("newDate 2 - 30 day:   " + newDate2.Subtract(duration));


        }
        static void AddingDaysToaDate()
        {
            DateTime today = DateTime.Now; 
            DateTime newDate2 = today.AddDays(30); // Adding one month(as 30 days)  
            Console.WriteLine(newDate2); 
        }
        static void DateTimeFormatting()
        {
            DateTime tempDate = new DateTime(2022, 12, 08);
            //Console.WriteLine(tempDate.ToString("MMMM dd")); //December 08, 2022. 
            //Console.WriteLine(tempDate.ToString("MMMM dd yyyy HH:mm")); //December 08, 2022.

            string dateInItalia = tempDate.ToString("D", new CultureInfo("it"));

            DateTime originalResult ;
            // Converting Hindi Date to DateTime object  
            bool success = DateTime.TryParse(dateInItalia, new System.Globalization.CultureInfo("it"),
            System.Globalization.DateTimeStyles.None, out originalResult);
            Console.WriteLine(originalResult.ToString("MMMM dd yyyy HH:mm"));

        }
        static void DateTimeProperties()
        {
            DateTime myDate = new DateTime(2022, 12, 25, 10, 30, 45);
            int year = myDate.Year; // 2015  
            int month = myDate.Month; //12  
            int day = myDate.Day; // 25  
            int hour = myDate.Hour; // 10  
            int minute = myDate.Minute; // 30  
            int second = myDate.Second; // 45  
            int weekDay = (int)myDate.DayOfWeek; // 5 due to Friday   
        }
        static void DateTimWithDifferentCulture()
        {
            
            DateTime currentTime = DateTime.Now; //"1/9/2016 10:22:45 AM"  
                                                 //// Getting DateTime based on culture.  
            string dateInUSA = currentTime.ToString("D", new CultureInfo("en-US")); // USA - Saturday, January 09, 2016
            Console.WriteLine($"Date In USA:{dateInUSA}");
            
            string dateInHindi = currentTime.ToString("D", new CultureInfo("hi-IN")); // Hindi 
            Console.WriteLine($"Date In Hindi:{dateInHindi}");

            string dateInJapan = currentTime.ToString("D", new CultureInfo("ja-JP")); // Japan   
            Console.WriteLine($"Date In Japan:{dateInJapan}");

            string dateInFrench = currentTime.ToString("D", new CultureInfo("fr-FR")); // French  
            Console.WriteLine($"Date In French:{dateInFrench}");

            string dateInItalia = currentTime.ToString("D", new CultureInfo("it")); // Italia  
            Console.WriteLine($"Date In Italia:{dateInItalia}");


            // Convert Hindi Date to French Date  
             DateTime originalResult = new DateTime(2016, 01, 09);
            // Converting Hindi Date to DateTime object  
            bool success = DateTime.TryParse(dateInHindi, new System.Globalization.CultureInfo("hi-IN"),
            System.Globalization.DateTimeStyles.None, out originalResult);

            // Next convert current date to French date  
            string frenchTDate = originalResult.ToString("D", new CultureInfo("fr-FR")); // French - samedi 9 janvier 2016  

            // To get DatePattern from Culture  
            CultureInfo fr = new CultureInfo("fr-FR");
            string shortUsDateFormatString = fr.DateTimeFormat.LongDatePattern;
            string shortUsTimeFormatString = fr.DateTimeFormat.ShortTimePattern;

            ////---> To get all installed culture in .Net version  
            
            //foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            //{
            //    Console.WriteLine(ci.Name + ", " + ci.EnglishName);
            //}
        }
    }
}
    