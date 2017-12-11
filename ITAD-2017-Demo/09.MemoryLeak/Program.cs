using System;
using System.Threading;

namespace _9.MemoryLeak
{
    class Program
    {
        public static CurrentSettings settings = new CurrentSettings();

        /// <summary>
        /// This example shows that you should be careful when adding event handlers (subscribers) to an event.
        /// Any handler added with += should be cleaned up with -= when you don't need it anymore.
        /// 
        /// Usage:
        /// 0. Set this project as StartUp project.
        /// 1. Start the program (F5). 
        /// 2. Do one of the below:
        /// 2.1. Use Performance Profiler (alt + F2) with Memory Usage option enabled.
        /// 2.2. Go to Windows Task Manager (Ctrl + Alt + Del) -> Processes. Find 9.MemoryLeak process.
        /// 3. Notice how the program is using more and more memory.
        /// 
        /// Explaination:
        /// Event handlers are treated separately of the scope where they have been added to an event. 
        /// Even though t object (SettingsWindows) goes out of scope in line 41, it still exists in memory because 
        /// it is necessary to call ChangeSettings method registered as handler for the OnChanged event (that has scope of the Program class).
        /// The handlers will not be garbage collected until the event itself goes out of scope (i.e. after Main method returns).
        /// </summary>
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                SimulateWindowCreation();
                Thread.Sleep(2000);
            }

            Console.ReadKey();
        }

        public static void SimulateWindowCreation()
        {
            var t = new SettingsWindows();
            settings.OnChanged += t.ChangeSettings;
        }
    }
}
