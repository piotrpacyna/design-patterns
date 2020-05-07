using DesignPatterns.Core;

namespace BuilderPattern
{
    public class Vehicle
    {
        public string Type { get; }
        public string Frame { get; private set; }
        public string Engine { get; private set; }
        public int Wheels { get; private set; }
        public int Doors { get; private set; }

        public Vehicle(string type)
        {
            Type = type;
        }

        public void CreateFrame(string value)
        {
            Frame = value;
        }

        public void CreateEngine(string value)
        {
            Engine = value;
        }

        public void CreateWheels(int value)
        {
            Wheels = value;
        }

        public void CreateDoors(int value)
        {
            Doors = value;
        }

        public void Print()
        {
            LogHelper.Log($"Type: {Type}");
            LogHelper.Log($"Frame: {Frame}");
            LogHelper.Log($"Engine: {Engine}");
            LogHelper.Log($"Wheels: {Wheels}");
            LogHelper.Log($"Doors: {Doors}");
            LogHelper.LogSeparator();
        }
    }
}
