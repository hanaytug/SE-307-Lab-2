using System;

namespace SE_307_Lab_2
{
    public class Position
    {
        private int _x;
        public int X { get => _x; set => _x = value; }

        private int _y;
        public int Y { get => _y; set => _y = value;  }
        
        public Position()
        {
            _x = 0;
            _y = 0;
        }
        
        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void MoveXBy(int value) 
        {
            _x += value;
        }

        public void MoveYBy(int value)
        {
            _y += value;
        }

        public double CalculateDistanceToOrigin()
        {
            return Math.Sqrt(Math.Pow((_x), 2) + Math.Pow((_y), 2));
        }

        public void ShowDistanceToOrigin()
        {
            Console.WriteLine("Distance to Origin : " + CalculateDistanceToOrigin());
            Console.WriteLine("--------------------------------");
        }

        public void DisplayLocation()
        {
            Console.WriteLine(_x + ":" + _y);
            Console.WriteLine("--------------------------------");
        }
    }
}