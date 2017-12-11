using System;

namespace _9.MemoryLeak
{
    public class SettingsWindows
    {
        int[] t1;
        int[] t2;
        int[] t3;
        int[] t4;
        int[] t5;
        int[] t6;
        public SettingsWindows()
        {
            t1 = new int[500000]; t3 = new int[500000]; t4 = new int[500000]; t5 = new int[500000]; t6 = new int[500000];
        }
        public event EventHandler OnChange;

        public void ChangeSettings(object s, EventArgs args)
        {

        }
    }
}
