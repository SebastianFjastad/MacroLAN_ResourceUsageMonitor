using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MLReporting.Domain.Model;

namespace MLReporting.Models
{
    public class UsageViewModel
    {
        #region constructor
        public UsageViewModel()
        {
            User = new UserRoleDim();
            VMs = new List<VirtualMachineDim>();
            VMUsages = new List<VirtualMachineBaseUsageHourlyFact>();
        }
        #endregion

        #region properties
        public UserRoleDim User { get; set; }

        public IEnumerable<UserRoleDim> Users { get; set; } 
        
        public IEnumerable<VirtualMachineDim> VMs { get; set; }
        
        public IEnumerable<VirtualMachineBaseUsageHourlyFact> VMUsages { get; set; }
        
        #endregion
    }
}