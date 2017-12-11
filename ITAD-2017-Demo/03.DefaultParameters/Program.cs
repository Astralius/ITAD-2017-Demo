using SensorDataPresenter;
using SensorsManager;
using System;

namespace _3.DefaultParameters
{
    class Program
    {
        /// <summary>
        /// This example shows dangers of using default parameters between assemblies.
        /// 
        /// Usage:
        /// 0. Set this project as StartUp project.
        /// 1. Hit Start (F5) and inspect the returned value. Notice the precision of the depth value.
        /// 2. Change 03b.SensorsManager.SensorData.cs line 21 to a different precision (e.g. 0.0 instead of 0.000).
        /// 3. Rebuild 03b.SensorsManager.
        /// 4. Hit Start (F5).
        /// 
        /// Explaination: 
        /// The value of default parameter is stored along with the assembly where these parameters are used. 
        /// If you change the value in the origin assembly (where the method with the default parameters is defined) it will have no effect
        /// on the assembly which uses this method, until you rebuild that assembly as well.
        /// </summary> 
        static void Main(string[] args)
        {
            // Below objects' classes are defined in two separate assemblies (SensorsManager.SensorData & SensorDataPresenter.ConsolePresenter)
            var speed = new SensorData("Depth", 15.1234, "meters");     
            var presenter = new ConsolePresenter();
            
            presenter.Show(speed);
            Console.ReadKey();
        }
    }
}
