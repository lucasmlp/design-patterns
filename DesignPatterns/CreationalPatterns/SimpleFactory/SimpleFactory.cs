namespace DesignPatterns.CreationalPatterns.SimpleFactory
{
    class Client
    {
        public void Main()
        {
            var door = new WoodenDoor(1.5, 2.2, "Carvalho");
        }
    }
}