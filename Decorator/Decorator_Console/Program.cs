using System;

namespace Decorator_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcreteComponent concrete = new ConcreteComponent();

            //concrete.operation();
            ConcreateDecorator concreateDecorator = new ConcreateDecorator(concrete);
            concreateDecorator.operation();


            SendEmail sendEmail = new SendEmail();
            sendEmail.Send();


            Console.ReadLine();
        }
    }
}
