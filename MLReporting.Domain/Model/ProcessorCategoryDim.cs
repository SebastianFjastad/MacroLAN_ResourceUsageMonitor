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
    
    public partial class ProcessorCategoryDim
    {
        public ProcessorCategoryDim()
        {
            this.VMInventoryMonthlyFacts = new HashSet<VMInventoryMonthlyFact>();
        }
    
        public int ProcessorCategoryDimKey { get; set; }
        public int ProcessorCount { get; set; }
    
        public virtual ICollection<VMInventoryMonthlyFact> VMInventoryMonthlyFacts { get; set; }
    }
}
