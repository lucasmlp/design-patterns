namespace DesignPatterns.CreationalPatterns.SimpleFactory
{
    public abstract class Door
    {
        private double Width;
        private double Height;
        public Door(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double GetWidth()
        {
            return this.Width;
        }
        public double GetHeight()
        {
            return this.Height;
        }
    }

    public class WoodenDoor : Door
    {
        private string WoodType { get; set; }

        public WoodenDoor(double width, double height, string woodType) : base(width, height)
        {
            this.WoodType = woodType;
        }
    }
}