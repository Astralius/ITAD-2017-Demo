using SensorsManager;
using System;

namespace SensorDataPresenter
{
    public class ConsolePresenter
    {
        public void Show(SensorData data)
        {
            // Below call ToFormattedString uses default parameters, which are stored along with the compiled assembly.
            Console.WriteLine(data.ToFormattedString());
        }
    }
}
