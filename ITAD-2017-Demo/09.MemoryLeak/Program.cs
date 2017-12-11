using System.Threading;

namespace _9.MemoryLeak
{
    class Program
    {
        public static CurrentSettings settings = new CurrentSettings();

        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                SimulateWindowCreation();
                Thread.Sleep(2000);
            }
        }

        public static void SimulateWindowCreation()
        {
            var t = new SettingsWindows();
            settings.OnChange += t.ChangeSettings;
        }
    }
}
