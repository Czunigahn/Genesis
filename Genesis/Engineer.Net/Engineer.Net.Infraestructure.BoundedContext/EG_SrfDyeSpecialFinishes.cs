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
    
    public partial class EG_SrfDyeSpecialFinishes
    {
        public string SrfNo { get; set; }
        public string SpecialFinishID { get; set; }
    
        public virtual EG_SRFWebHeader EG_SRFWebHeader { get; set; }
    }
}
