using System;

namespace _1.DerivedClassVirtual
{
    internal class BaseData
    {
        private string data = null;

        public BaseData(string data)
        {
            this.data = data;

            // Below will call overriden InitializeState method, if present. Only if there is no override, BaseData.InitializeState() will be called.
            InitializeState();

            Console.WriteLine("BaseData created");
        }

        public virtual void InitializeState()
        {
            // some basic initialization logic
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

        /// <summary>
        /// This method will be called polymorphically by the base constructor instead of BaseData.InitializeState()!
        /// </summary>
        public override void InitializeState()
        {
            //if (source.Contains("someString"))    // source is empty until NetworkData constructor returns
            //{

            //}
        }
    }
}
