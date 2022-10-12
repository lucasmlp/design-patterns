namespace DesignPatterns.CreationalPatterns.SimpleFactory
{
    public abstract class Door
    {
        private double Width;
        private double Height;
        private double Weight;
        public Door(double width, double height, double weight)
        {
            this.Width = width;
            this.Height = height;
            this.Weight = weight;
        }
        public double GetWidth()
        {
            return this.Width;
        }
        public double GetHeight()
        {
            return this.Height;
        }
        public double GetWeight()
        {
            return this.Weight;
        }
    }

    public class WoodenDoor : Door
    {
        private string WoodType { get; set; }

        public WoodenDoor(double width, double height, double weight, string woodType) : base(width, height, weight)
        {
            this.WoodType = woodType;
        }
    }

    class DoorFactory
    {
        public WoodenDoor MakeWoodenDoor(double width, double height, double weight, string woodType)
        {
            return new WoodenDoor(width, height, weight, woodType);
        }
    }
}