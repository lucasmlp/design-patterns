namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class Carpenter : FittingExpert
    {
        public string GetDescription()
        {
            return "I can only fit wooden doors";
        }
    }
}