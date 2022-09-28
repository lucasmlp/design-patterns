namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public interface IProduct
    {
        string Operation();
    }

    abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }

    class ConcreteCreator1 : Creator
    {
        // This method has override because it needs to implement abstract method FactoryMethod that was inherited from a class
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteProduct1 : IProduct
    {
        // This method does not have override because it's implementing a method from the interface that the class is implementing
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    class ConcreteCreator2 : Creator
    {
        // This method has override because it needs to implement abstract method FactoryMethod that was inherited from a class
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    class ConcreteProduct2 : IProduct
    {
        // This method does not have override because it's implementing a method from the interface that the class is implementing
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}

