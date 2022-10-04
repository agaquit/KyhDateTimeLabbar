using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhDateTimeLabbar
{
    public class App
    {

        public void Lab2()
        {
            var currentDate = DateTime.Now;
            var currentYear = currentDate.ToString("yyyy");
            Console.WriteLine($"Year: {currentYear}");
            var currentMonth = currentDate.Month;
            Console.WriteLine($"Month: {currentMonth}");
            var currentDay = currentDate.Day;
            Console.WriteLine($"Day: {currentDay}");
            var currentHour = currentDate.ToString("HH");
            Console.WriteLine($"Hour {currentHour}");
            var currentMinute = currentDate.ToString("mm");
            Console.WriteLine($"Minute: {currentMinute}");
            var currentSecond = currentDate.ToString("ss");
            Console.WriteLine($"Seconds: {currentSecond}");
            var currentMillisecond = currentDate.ToString("ms");
            Console.WriteLine($"Milliseconds: {currentMillisecond}");


            var monthName = "";
            switch (currentMonth)
            {
                case 1:
                    monthName = "Januari";
                    break;
                case 2:
                    monthName = "Februari";
                    break;
                case 3:
                    monthName = "Mars";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "Maj";
                    break;
                case 6:
                    monthName = "Juni";
                    break;
                case 7:
                    monthName = "Juli";
                    break;
                case 8:
                    monthName = "Augusti";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "Oktober";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
            }
            Console.WriteLine($"Månaden heter {monthName}");


            string veckoDagsString = currentDate.DayOfWeek.ToString();
            Console.WriteLine($"Dagens veckodag är {veckoDagsString}");
            string inSwedish = "";
            switch (currentDate.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    inSwedish = "Måndag";
                    break;
                case DayOfWeek.Tuesday:
                    inSwedish = "Tisdag";
                    break;
                case DayOfWeek.Wednesday:
                    inSwedish = "Onsdag";
                    break;
                case DayOfWeek.Thursday:
                    inSwedish = "Torsdag";
                    break;
                case DayOfWeek.Friday:
                    inSwedish = "Fredag";
                    break;
                case DayOfWeek.Saturday:
                    inSwedish = "Lördag";
                    break;
                case DayOfWeek.Sunday:
                    inSwedish = "Söndag";
                    break;

            }
            Console.WriteLine($"Dagens veckodag på svenska är {inSwedish}");

        }

        public void Lab1()
        {
            var currentDay = DateTime.Now;
            Console.WriteLine($"Complete Date: {currentDay}");
            var currentDay2 = currentDay.ToString("yyy-MM-dd");
            Console.WriteLine($"Short Date: {currentDay2}");
        }
        public void Run()
        {
            Lab2();
            Lab1();
            


        }


    }
}
