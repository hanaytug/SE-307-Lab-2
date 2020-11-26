using System;
using System.Threading;

namespace SE_307_Lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a problem to test it : ");

            while (true)
            {
                Console.WriteLine("1-) Problem 1 (Time Test)");
                Console.WriteLine("2-) Problem 2 (Gadgetzan Co)");
                Console.WriteLine("3-) Problem 3 (Position)");
                Console.WriteLine("5-) Problem 5 (Checking Bank Account)");
                Console.WriteLine("6-) Problem 6 (Employee)");
                Console.WriteLine("7-) Problem 7 (Activity Room)");
                Console.WriteLine("8-) Exit");
                
                int temp = Convert.ToInt32(Console.ReadLine());
            
                switch (temp)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Problem 1");
                        Console.WriteLine("--------------------------------");
                        TimeTest timeTest = new TimeTest();
                        timeTest.TimeTestScenario();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Problem 2");
                        Console.WriteLine("--------------------------------");
                        GadgetzanCoTest gadgetzanCoTest = new GadgetzanCoTest();
                        gadgetzanCoTest.GadgetzanCoTestScenario();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Problem 3");
                        Console.WriteLine("--------------------------------");
                        PositionTest positionTest = new PositionTest();
                        positionTest.PositionTestScenario();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Problem 5");
                        Console.WriteLine("--------------------------------");
                        CheckingBankAccountTest checkingBankAccountTest = new CheckingBankAccountTest();
                        checkingBankAccountTest.CheckingBankAccountScenario();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Problem 6");
                        Console.WriteLine("--------------------------------");
                        EmployeeTest employeeTest = new EmployeeTest();
                        employeeTest.EmployeeTestScenario();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Problem 7");
                        Console.WriteLine("--------------------------------");
                        ActivityRoomTest activityRoomTest = new ActivityRoomTest();
                        activityRoomTest.ActivityRoomTestScenario();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("You can only enter 1,2,3,5,6,7,8 (4th program is inside of the folder)");
                        Console.WriteLine("--------------------------------");
                        break;
                }
                
                Console.WriteLine("You should wait until the menu comes out again");
                Thread.Sleep(10000); // Time for you to read check the console PS : I know that this is not efficient at all it completely stops the thread.
                Console.Clear();
            }
            
        }
    }
}