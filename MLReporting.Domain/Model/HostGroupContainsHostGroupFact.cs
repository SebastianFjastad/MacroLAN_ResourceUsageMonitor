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
    
    public partial class HostGroupContainsHostGroupFact
    {
        public int HostGroupContainsHostGroupFactKey { get; set; }
        public System.Guid SourceEntityId { get; set; }
        public System.Guid TargetEntityId { get; set; }
        public System.DateTime TimeAdded { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public int HostGroupDimKey_Src { get; set; }
        public int HostGroupDimKey_Tgt { get; set; }
        public int DWInsertedId { get; set; }
        public int DWUpdatedId { get; set; }
        public System.DateTime DWValidFrom { get; set; }
        public System.DateTime DWValidTo { get; set; }
        public bool DWIsDeleted { get; set; }
    
        public virtual HostGroupDim HostGroupDim { get; set; }
        public virtual HostGroupDim HostGroupDim1 { get; set; }
    }
}
