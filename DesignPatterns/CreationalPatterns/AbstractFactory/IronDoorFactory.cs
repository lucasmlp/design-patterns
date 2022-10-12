namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class IronDoorFactory : DoorFactory
    {
        public Door MakeDoor()
        {
            return new IronDoor();
        }

        public FittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }
}