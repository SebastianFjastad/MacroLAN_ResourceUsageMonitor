using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLReporting.Domain.Model
{
    public partial class VirtualMachineBaseUsageHourlyFact
    {
        public string IpAddress { get; set; }
        public string NetworkName { get; set; }
    }
}
