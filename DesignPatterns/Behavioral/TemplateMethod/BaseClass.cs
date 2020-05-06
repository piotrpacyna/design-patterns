namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class BaseClass
    {
        // Template method
        public void TemplateMethod()
        {
            Method1();
            Method2();
            Method3();
        }

        protected abstract void Method1();
        protected abstract void Method2();

        protected virtual void Method3()
        {
            //Do something in base class
        }
    }
}
