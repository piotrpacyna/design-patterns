using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleOne = new TemplateOneClass();
            var exampleTwo = new TemplateTwoClass();

            exampleOne.TemplateMethod();
            exampleTwo.TemplateMethod();

            Console.ReadLine();
        }
    }
}
