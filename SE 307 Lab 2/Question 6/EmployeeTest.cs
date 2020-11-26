namespace SE_307_Lab_2
{
    public class EmployeeTest
    {
        public void EmployeeTestScenario()
        {
            Employee employee1 = new Employee("Aytuğ", "HAN", 23, "Developer",20,30);
            Employee employee2 = new Employee("Asya", "Topçu", 23, "3D Artist",20,22);
            Employee employee3 = new Employee("Çağıl", "Fırat", 23, "Game Designer",20,22);
            
            employee1.DisplayEmployeeInformation();
            employee2.DisplayEmployeeInformation();
            employee3.DisplayEmployeeInformation();

            employee1.FirstName = null;
            employee1.LastName = null;
            employee1.Age = 13;
            employee1.WorkHoursForEachWeek = -2;
            employee1.PaymentForEachWorkHour = -2;
            
            employee1.DisplayEmployeeInformation();
        }
    }
}