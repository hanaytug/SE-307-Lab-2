using System;

namespace SE_307_Lab_2
{
    public class Employee
    {
        private String _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value != null)
                {
                    _firstName = value;
                }
                else
                {
                    Console.WriteLine("First name cannot be null");
                }
            }
        }
        
        private String _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value != null)
                {
                    _lastName = value;
                }
                else
                {
                    Console.WriteLine("Last name cannot be null");
                }
            }
        }
        
        private int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value > 16 && value < 70)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greater than 16 and less than 70.");
                }
            }
            
        }
        
        private String _employeePosition;

        public string EmployeePosition
        {
            get => _employeePosition;
            set
            {
                if (value != null)
                {
                    _employeePosition = value;
                }
                else
                {
                    Console.WriteLine("Employee Position cannot be null");
                }
            }
        }
        
        private int _workHoursForEachWeek;

        public int WorkHoursForEachWeek
        {
            get => _workHoursForEachWeek;
            set
            {
                if (value >= 0)
                {
                    _workHoursForEachWeek = value;
                }
                else
                {
                    Console.WriteLine("Work Hours For Each Week must be positive");
                }
            }
        }
        
        private double _paymentForEachWorkHour;

        public double PaymentForEachWorkHour
        {
            get => _paymentForEachWorkHour;
            set
            {
                if (value >= 0)
                {
                    _paymentForEachWorkHour = value;
                }
                else
                {
                    Console.WriteLine("Payment For Each Work Hour must be positive");
                }
            }
        }
        
        public Employee(String firstName, String lastName, int age, String employeePosition, int workHoursForEachWeek,
            double paymentForEachWorkHour)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            EmployeePosition = employeePosition;
            WorkHoursForEachWeek = workHoursForEachWeek;
            PaymentForEachWorkHour = paymentForEachWorkHour;
        }

        public double CalculateWeeklySalary()
        {
            return WorkHoursForEachWeek * PaymentForEachWorkHour;
        }

        public void DisplayEmployeeInformation()
        {
            Console.WriteLine("First Name : " + FirstName);
            Console.WriteLine("Last Name : " + LastName);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Employee Position : " + EmployeePosition);
            Console.WriteLine("Salary : " + CalculateWeeklySalary());
            Console.WriteLine("--------------------------------");
        } 
    }
}