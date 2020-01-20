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
    
    public partial class VirtualDiskDim
    {
        public VirtualDiskDim()
        {
            this.VirtualMachineContainsVirtualDiskFacts = new HashSet<VirtualMachineContainsVirtualDiskFact>();
        }
    
        public int VirtualDiskDimKey { get; set; }
        public System.Guid BaseManagedEntityId { get; set; }
        public string VMMId { get; set; }
        public string DriveType { get; set; }
        public string Path { get; set; }
        public string MaxSize { get; set; }
        public string CurrentSize { get; set; }
        public string Classification { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> DWInsertedId { get; set; }
        public Nullable<int> DWUpdatedId { get; set; }
        public Nullable<bool> DWIsDeleted { get; set; }
    
        public virtual ICollection<VirtualMachineContainsVirtualDiskFact> VirtualMachineContainsVirtualDiskFacts { get; set; }
    }
}
