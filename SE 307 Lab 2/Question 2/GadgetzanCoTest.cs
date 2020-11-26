namespace SE_307_Lab_2
{
    public class GadgetzanCoTest
    {
        public void GadgetzanCoTestScenario()
        {
            GadgetzanCo gadgetzanCo = new GadgetzanCo();
            
            gadgetzanCo.DisplayCost();

            gadgetzanCo.ProductNumber = 307;
            gadgetzanCo.ProductName = "SE";
            gadgetzanCo.Price = 5.5;
            gadgetzanCo.Quantity = 5;
            
            gadgetzanCo.DisplayCost();
        }
    }
}