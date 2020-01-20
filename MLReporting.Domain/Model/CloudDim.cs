//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MLReporting.Domain.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CloudDim
    {
        public CloudDim()
        {
            this.CloudContainsVirtualMachineFacts = new HashSet<CloudContainsVirtualMachineFact>();
            this.SubscriptionCapacityMonthlyFacts = new HashSet<SubscriptionCapacityMonthlyFact>();
            this.UserRoleReferencesCloudFacts = new HashSet<UserRoleReferencesCloudFact>();
            this.VirtualMachineBaseUsageMonthlyFacts = new HashSet<VirtualMachineBaseUsageMonthlyFact>();
            this.VMNetworkGatewayUsageMonthlyFacts = new HashSet<VMNetworkGatewayUsageMonthlyFact>();
            this.VirtualMachineBaseUsageHourlyFacts = new HashSet<VirtualMachineBaseUsageHourlyFact>();
            this.SubscriptionCapacityDailyFacts = new HashSet<SubscriptionCapacityDailyFact>();
            this.SubscriptionCapacityDailyFactStagings = new HashSet<SubscriptionCapacityDailyFactStaging>();
            this.SubscriptionCapacityHourlyFacts = new HashSet<SubscriptionCapacityHourlyFact>();
            this.SubscriptionCapacityHourlyFactStagings = new HashSet<SubscriptionCapacityHourlyFactStaging>();
            this.VirtualMachineBaseUsageDailyFacts = new HashSet<VirtualMachineBaseUsageDailyFact>();
            this.VirtualMachineBaseUsageDailyFactStagings = new HashSet<VirtualMachineBaseUsageDailyFactStaging>();
            this.VirtualMachineBaseUsageHourlyFactStagings = new HashSet<VirtualMachineBaseUsageHourlyFactStaging>();
            this.VMNetworkGatewayUsageDailyFacts = new HashSet<VMNetworkGatewayUsageDailyFact>();
            this.VMNetworkGatewayUsageDailyFactStagings = new HashSet<VMNetworkGatewayUsageDailyFactStaging>();
            this.VMNetworkGatewayUsageHourlyFacts = new HashSet<VMNetworkGatewayUsageHourlyFact>();
            this.VMNetworkGatewayUsageHourlyFactStagings = new HashSet<VMNetworkGatewayUsageHourlyFactStaging>();
        }
    
        public int CloudDimKey { get; set; }
        public System.Guid BaseManagedEntityId { get; set; }
        public string VMMId { get; set; }
        public string MaximumVMCount { get; set; }
        public string MaximumVCPUCount { get; set; }
        public string CustomQuota { get; set; }
        public string MaximumStorage { get; set; }
        public string MaximumMemory { get; set; }
        public string VMMServer { get; set; }
        public string ClusterNames { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> DWInsertedId { get; set; }
        public Nullable<int> DWUpdatedId { get; set; }
        public Nullable<bool> DWIsDeleted { get; set; }
    
        public virtual ICollection<CloudContainsVirtualMachineFact> CloudContainsVirtualMachineFacts { get; set; }
        public virtual ICollection<SubscriptionCapacityMonthlyFact> SubscriptionCapacityMonthlyFacts { get; set; }
        public virtual ICollection<UserRoleReferencesCloudFact> UserRoleReferencesCloudFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageMonthlyFact> VirtualMachineBaseUsageMonthlyFacts { get; set; }
        public virtual ICollection<VMNetworkGatewayUsageMonthlyFact> VMNetworkGatewayUsageMonthlyFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageHourlyFact> VirtualMachineBaseUsageHourlyFacts { get; set; }
        public virtual ICollection<SubscriptionCapacityDailyFact> SubscriptionCapacityDailyFacts { get; set; }
        public virtual ICollection<SubscriptionCapacityDailyFactStaging> SubscriptionCapacityDailyFactStagings { get; set; }
        public virtual ICollection<SubscriptionCapacityHourlyFact> SubscriptionCapacityHourlyFacts { get; set; }
        public virtual ICollection<SubscriptionCapacityHourlyFactStaging> SubscriptionCapacityHourlyFactStagings { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageDailyFact> VirtualMachineBaseUsageDailyFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageDailyFactStaging> VirtualMachineBaseUsageDailyFactStagings { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageHourlyFactStaging> VirtualMachineBaseUsageHourlyFactStagings { get; set; }
        public virtual ICollection<VMNetworkGatewayUsageDailyFact> VMNetworkGatewayUsageDailyFacts { get; set; }
        public virtual ICollection<VMNetworkGatewayUsageDailyFactStaging> VMNetworkGatewayUsageDailyFactStagings { get; set; }
        public virtual ICollection<VMNetworkGatewayUsageHourlyFact> VMNetworkGatewayUsageHourlyFacts { get; set; }
        public virtual ICollection<VMNetworkGatewayUsageHourlyFactStaging> VMNetworkGatewayUsageHourlyFactStagings { get; set; }
    }
}
