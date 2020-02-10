using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms.InventoryManagement
{
    public class InventoryDetails
    {

        private List<Rice> rice = new List<Rice>();

        private List<Wheat> wheat = new List<Wheat>();

        private List<Pulses> pulses = new List<Pulses>();

        public List<Rice> Rice { get => this.rice; set => this.rice = value; }
        public List<Wheat> Wheat { get => this.wheat; set => this.wheat = value; }
        public List<Pulses> Pulses { get => this.pulses; set => this.pulses = value; }
    }
}
