namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class Welder : FittingExpert
    {
        public string GetDescription()
        {
            return "I can only fit iron doors";
        }
    }
}