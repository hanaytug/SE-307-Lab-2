using System;

namespace SE_307_Lab_2
{
    public class ActivityRoomTest
    {
        public void ActivityRoomTestScenario()
        {
            ActivityRoom activityRoom = new ActivityRoom(0,4,0);
            
            activityRoom.AcceptAPerson(23);
            activityRoom.DisplayActivityRoomInformation();
            activityRoom.AcceptAPerson(55);
            activityRoom.AcceptAPerson(45);
            activityRoom.AcceptAPerson(23);
            activityRoom.AcceptAPerson(10);
            activityRoom.AcceptAPerson(32);
            activityRoom.DisplayActivityRoomInformation();
            Console.WriteLine("Average Age : " + activityRoom.CalculateAverageAgeOfPeople());
            activityRoom.AcceptAPerson(30);
            activityRoom.LeaveFromRoom(23);
            Console.WriteLine("Average Age : " + activityRoom.CalculateAverageAgeOfPeople());
            activityRoom.DisplayActivityRoomInformation();
            activityRoom.AcceptAPerson(30);
            Console.WriteLine("Average Age : " + activityRoom.CalculateAverageAgeOfPeople());
            activityRoom.DisplayActivityRoomInformation();
        }
    }
}