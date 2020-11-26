using System;
using System.Diagnostics;

namespace SE_307_Lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            TimeTest timeTest = new TimeTest();
            timeTest.TimeTestScenario();
            
            Console.WriteLine("Question 2");
            GadgetzanCoTest gadgetzanCoTest = new GadgetzanCoTest();
            gadgetzanCoTest.GadgetzanCoTestScenario();
            
            Console.WriteLine("Question 3");
            PositionTest positionTest = new PositionTest();
            positionTest.PositionTestScenario();
            
            
            Console.WriteLine("Question 6");
            EmployeeTest employeeTest = new EmployeeTest();
            employeeTest.EmployeeTestScenario();

            Console.WriteLine("Question 7");
            ActivityRoomTest activityRoomTest = new ActivityRoomTest();
            activityRoomTest.ActivityRoomTestScenario();
        }
    }
}