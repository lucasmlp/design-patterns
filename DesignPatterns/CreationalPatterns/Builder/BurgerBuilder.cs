namespace DesignPatterns.CreationalPatterns.Builder
{
    public class BurgerBuilder
    {
        public int size { get; set; }

        public bool cheese = false;
        public bool pepperoni = false;
        public bool lettuce = false;
        public bool tomato = false;

        public BurgerBuilder(int size)
        {
            this.size = size;
        }

        public BurgerBuilder addPepperoni()
        {
            this.pepperoni = true;
            return this;
        }

        public BurgerBuilder addLettuce()
        {
            this.lettuce = true;
            return this;
        }

        public BurgerBuilder addCheese()
        {
            this.cheese = true;
            return this;
        }

        public BurgerBuilder addTomato()
        {
            this.tomato = true;
            return this;
        }

        public Burger build()
        {
            return new Burger(this);
        }
    }
}