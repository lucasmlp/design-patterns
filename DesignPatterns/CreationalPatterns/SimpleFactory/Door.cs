namespace SimpleFactory
{
    public abstract class Door
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public Door(double width, double height)
        {
            this.Width = width;
            this.Height = height;
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