using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var concrete = new ConcreteComponent();

            //concrete.operation();
            var concreteDecorator = new ConcreteDecorator(concrete);
            concreteDecorator.operation();
        }
    }
}
