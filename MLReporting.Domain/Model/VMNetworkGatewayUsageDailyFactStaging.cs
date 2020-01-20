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
    
    public partial class VMNetworkGatewayUsageDailyFactStaging
    {
        public long VMNetworkGatewayUsageDailyFactKey { get; set; }
        public int VMNetworkGatewayDimKey { get; set; }
        public int VMNetworkDimKey { get; set; }
        public int CloudDimKey { get; set; }
        public int UserRoleDimKey { get; set; }
        public int VMMServerDimKey { get; set; }
        public int TenantDimKey { get; set; }
        public int PlanDimKey { get; set; }
        public int SubscriptionDimKey { get; set; }
        public int DateKey { get; set; }
        public Nullable<double> GatewayIngress { get; set; }
        public Nullable<double> GatewayEgress { get; set; }
        public int DWInsertedId { get; set; }
        public int DWUpdatedId { get; set; }
        public bool DWIsDeleted { get; set; }
        public int DWPartitionKey { get; set; }
    
        public virtual CloudDim CloudDim { get; set; }
        public virtual DateDim DateDim { get; set; }
        public virtual PlanDim PlanDim { get; set; }
        public virtual SubscriptionDim SubscriptionDim { get; set; }
        public virtual TenantDim TenantDim { get; set; }
        public virtual UserRoleDim UserRoleDim { get; set; }
        public virtual VMMServerDim VMMServerDim { get; set; }
        public virtual VMNetworkDim VMNetworkDim { get; set; }
        public virtual VMNetworkGatewayDim VMNetworkGatewayDim { get; set; }
    }
}
