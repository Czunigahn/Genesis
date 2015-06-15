//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Engineer.Net.Infraestructure.BoundedContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class EG_SRFSpcFabricList
    {
        public EG_SRFSpcFabricList()
        {
            this.EG_SRFSpcFabricWidthDetail = new HashSet<EG_SRFSpcFabricWidthDetail>();
        }
    
        public int Id { get; set; }
        public string SrfNo { get; set; }
        public string ComponentType { get; set; }
        public string FabricType { get; set; }
        public string Skuno { get; set; }
        public string GenericSkuno { get; set; }
        public string ReferencedSrfNo { get; set; }
        public Nullable<int> ReferencedFabricId { get; set; }
        public Nullable<int> ShrinkLength { get; set; }
        public Nullable<int> ShrinkWeight { get; set; }
        public Nullable<decimal> FabricWeight { get; set; }
    
        public virtual ICollection<EG_SRFSpcFabricWidthDetail> EG_SRFSpcFabricWidthDetail { get; set; }
    }
}
