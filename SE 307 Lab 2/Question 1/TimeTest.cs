using System;

namespace SE_307_Lab_2
{
    public class TimeTest
    {
        public void TimeTestScenario()
        {
            Time time = new Time();
            
            time.DisplayTime();

            time.Hour = 12;
            time.Minute = 32;
            time.Second = 20;
            
            time.DisplayTime();
            
            DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.Now.Date; This will print Today's date and 00:00:00 
            
            Console.WriteLine(date1);
            
            Console.WriteLine("--------------------------------");
        }
    }
}