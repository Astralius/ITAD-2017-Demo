using SensorsManager;
using System;

namespace SensorDataPresenter
{
    public class ConsolePresenter
    {
        public void Show(SensorData data)
        {
            Console.WriteLine(data.ToFormattedString());
        }
    }
}
