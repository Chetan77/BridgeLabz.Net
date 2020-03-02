using System;
using System.Collections.Generic;
using System.Text;

namespace BillPughSingleton
{
    class Bridge
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Bridge() { }
        public Bridge(string name)
        {
            this.name = name;
        }

        private static class BridgeHold
        {
            public static Bridge bridge = new Bridge();
        }

        public static Bridge GetBridge()
        {
            return BridgeHold.bridge;
        }
    }
}
