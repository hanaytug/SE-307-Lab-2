using System;

namespace SE_307_Lab_2
{
    public class Time
    {
        private int _hour;
        public int Hour  { get => _hour; set => _hour = value; }
        
        private int _minute;
        public int Minute { get => _minute; set => _minute = value;  }
        
        private int _second;
        public int Second { get => _second; set => _second = value; }

        public Time()
        {
            _hour = 0;
            _minute = 0;
            _second = 0;
        }
        
        public Time(int hour, int minute, int second)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
        }

        public void DisplayTime()
        {
            Console.WriteLine(Hour + ":" + Minute + ":" + Second);
            Console.WriteLine("--------------------------------");
        }
    }
}