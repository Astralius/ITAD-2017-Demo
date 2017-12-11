using SensorDataPresenter;
using SensorsManager;

namespace _3.DefaultParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = new SensorData("Depth", 15.1234, "meters");

            var presenter = new ConsolePresenter();
            presenter.Show(speed);
        }
    }
}
