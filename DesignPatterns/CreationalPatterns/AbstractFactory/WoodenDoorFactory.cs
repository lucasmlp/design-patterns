namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class WoodenDoorFactory : DoorFactory
    {
        public Door MakeDoor()
        {
            return new WoodenDoor();
        }

        public FittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }
}