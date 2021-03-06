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
    
    public partial class DateDim
    {
        public DateDim()
        {
            this.SubscriptionCapacityMonthlyFacts = new HashSet<SubscriptionCapacityMonthlyFact>();
            this.VirtualMachineBaseUsageMonthlyFacts = new HashSet<VirtualMachineBaseUsageMonthlyFact>();
            this.VMInventoryMonthlyFacts = new HashSet<VMInventoryMonthlyFact>();
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
    
        public int DateKey { get; set; }
        public System.DateTime CalendarDate { get; set; }
        public string DayOfWeek { get; set; }
        public short DayNumberInMonth { get; set; }
        public short WeekNumberInYear { get; set; }
        public short CalendarYearNumber { get; set; }
        public string CalendarYearName { get; set; }
        public short CalendarQuarterNumber { get; set; }
        public string CalendarQuarterName { get; set; }
        public short CalendarMonthNumber { get; set; }
        public string CalendarMonthName { get; set; }
        public string CalendarMonthAltName { get; set; }
        public short FiscalYearNumber { get; set; }
        public string FiscalYearName { get; set; }
        public short FiscalQuarterNumber { get; set; }
        public string FiscalQuarterName { get; set; }
        public short FiscalMonthNumber { get; set; }
        public string FiscalMonthName { get; set; }
        public string FiscalMonthAltName { get; set; }
        public byte IsHoliday { get; set; }
        public byte IsWeekDay { get; set; }
        public byte IsLastDayOfMonth { get; set; }
    
        public virtual ICollection<SubscriptionCapacityMonthlyFact> SubscriptionCapacityMonthlyFacts { get; set; }
        public virtual ICollection<VirtualMachineBaseUsageMonthlyFact> VirtualMachineBaseUsageMonthlyFacts { get; set; }
        public virtual ICollection<VMInventoryMonthlyFact> VMInventoryMonthlyFacts { get; set; }
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
