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
    
    public partial class EG_SRFSpcFabricWidthDetail
    {
        public int Id { get; set; }
        public int WidthId { get; set; }
        public int FabricId { get; set; }
        public string SrfNo { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public Nullable<decimal> RequestedPounds { get; set; }
    
        public virtual EG_SRFSpcFabricList EG_SRFSpcFabricList { get; set; }
        public virtual EG_SRFSpcWidthList EG_SRFSpcWidthList { get; set; }
    }
}
