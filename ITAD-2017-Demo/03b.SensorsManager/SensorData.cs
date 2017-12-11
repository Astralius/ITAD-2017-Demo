namespace SensorsManager
{
    public class SensorData
    {
        public string Name { get; }

        public double Val { get; }

        public string Unit { get; }

        public SensorData(string name, double val, string unit)
        {
            Name = name;
            Val = val;
            Unit = unit;
        }

        public string ToFormattedString(string format="{0}: {1:0.00} {2}")
        {
            return string.Format(format, Name, Val, Unit);
        }
    }
}
