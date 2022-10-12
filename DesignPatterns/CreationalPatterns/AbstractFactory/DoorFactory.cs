namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    interface DoorFactory
    {
        Door MakeDoor();
        FittingExpert MakeFittingExpert();
    }
}