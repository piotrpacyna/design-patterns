using System;
using DesignPatterns.Core;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var decoratedWindows = new HorizontalScrollBarDecorator(new VerticalScrollBarDecorator(new BorderDecorator(new FormComponent())));
            decoratedWindows.Draw();

            LogHelper.LogSeparator();

            var borderedWindow = new BorderDecorator(new FormComponent());
            borderedWindow.Draw();

            LogHelper.LogSeparator();

            var scrolledWindows = new VerticalScrollBarDecorator(new HorizontalScrollBarDecorator(new FormComponent()));
            scrolledWindows.Draw();

            Console.ReadLine();
        }
    }
}
