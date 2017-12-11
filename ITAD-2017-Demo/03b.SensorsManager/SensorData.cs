namespace SensorsManager
{
    public class SensorData
    {
        public string Name { get; }

        public double Value { get; }

        public string Unit { get; }

        public SensorData(string name, double value, string unit)
        {
            this.Name = name;
            this.Value = value;
            this.Unit = unit;
        }

        /// <summary>
        /// Method using default parameter.
        /// </summary>
        public string ToFormattedString(string format="{0}: {1:0.000} {2}")
        {
            return string.Format(format, this.Name, this.Value, this.Unit);
        }
    }
}
