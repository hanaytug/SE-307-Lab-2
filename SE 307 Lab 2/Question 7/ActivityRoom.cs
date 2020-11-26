using System;

namespace SE_307_Lab_2
{
    public class ActivityRoom
    {
        private int _numberOfPeopleInsideTheRoom;
        public int NumberOfPeopleInsideTheRoom { get => _numberOfPeopleInsideTheRoom; set => _numberOfPeopleInsideTheRoom = value; }
        
        private int _capacity;
        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value >= 4 && value <= 12)
                {
                    _capacity = value;
                }
                else
                {
                    Console.WriteLine("Capacity must be between 4 and 12");
                }
            }
        }
        
        private int _cumulativeAgeOfPeopleWhoseInsideTheRoomCurrently;
        public int CumulativeAgeOfPeopleWhoseInsideTheRoomCurrently
        {
            get => _cumulativeAgeOfPeopleWhoseInsideTheRoomCurrently;
            set
            {
                if (value >= 0) // Assuming that it will never be less than 0
                {
                    _cumulativeAgeOfPeopleWhoseInsideTheRoomCurrently = value;
                }
                else
                {
                    Console.WriteLine("Cumulative Age Of People Whose Inside The Room must be greater or equal to zero");
                }
            }
        }

        public ActivityRoom(int numberOfPeopleInsideTheRoom, int capacity,
            int cumulativeAgeOfPeopleWhoseInsideTheRoomCurrently)
        {
            NumberOfPeopleInsideTheRoom = numberOfPeopleInsideTheRoom;
            Capacity = capacity;
            CumulativeAgeOfPeopleWhoseInsideTheRoomCurrently = cumulativeAgeOfPeopleWhoseInsideTheRoomCurrently;
        }

        public void AcceptAPerson(int age)
        {
            if (age >= 13)
            {
                if (IsRoomFull())
                {
                    Console.WriteLine("the room is full, you should wait for entering the room");
                }
                else
                {
                    CumulativeAgeOfPeopleWhoseInsideTheRoomCurrently += age;
                    NumberOfPeopleInsideTheRoom++;
                }
            }
            else
            {
                Console.WriteLine("Age must be greater than or equal to 13");
            }
        }

        public void LeaveFromRoom(int age)
        {
            if (NumberOfPeopleInsideTheRoom != 0) // Assuming that it will never be less than zero
            {
                NumberOfPeopleInsideTheRoom--;
                CumulativeAgeOfPeopleWhoseInsideTheRoomCurrently -= age;
            }
        }

        public bool IsRoomFull()
        {
            return Capacity == NumberOfPeopleInsideTheRoom;
        }

        public double CalculateAverageAgeOfPeople()
        {
            return (double) CumulativeAgeOfPeopleWhoseInsideTheRoomCurrently / NumberOfPeopleInsideTheRoom;
        }

        public void DisplayActivityRoomInformation()
        {
            Console.WriteLine("Number Of People Inside The Room : " + NumberOfPeopleInsideTheRoom);
            Console.WriteLine("Average Age " + CalculateAverageAgeOfPeople());
            Console.WriteLine("Total Capacity : " + Capacity);
            Console.WriteLine("--------------------------------");
        }
    }
}