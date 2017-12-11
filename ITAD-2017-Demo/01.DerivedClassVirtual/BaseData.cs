using System;

namespace _1.DerivedClassVirtual
{
    internal class BaseData
    {
        private string data = null;

        public BaseData(string data)
        {
            this.data = data;
            InitializeState();
            Console.WriteLine("BaseData created");
        }

        public virtual void InitializeState()
        {
            //basic initialization logic
        }
    }

    internal class NetworkData : BaseData
    {
        private string source = null;

        public NetworkData(string data, string source) : 
            base(data)
        {
            this.source = source;
            Console.WriteLine("NetworkData created");
        }

        public override void InitializeState()
        {
            //if (source.Contains("someString"))
            //{

            //}
        }
    }
}
