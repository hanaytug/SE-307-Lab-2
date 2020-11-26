namespace SE_307_Lab_2
{
    public class PositionTest
    {
        public void PositionTestScenario()
        {
            Position position = new Position();
            
            position.DisplayLocation();
            position.ShowDistanceToOrigin();

            position.MoveXBy(5);
            position.MoveYBy(5);
            
            position.DisplayLocation();
            position.ShowDistanceToOrigin();
            
        }
    }
}