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
    
    public partial class EG_SRFColorRequest
    {
        public string ID { get; set; }
        public string SrfNo { get; set; }
        public string ColorCode { get; set; }
        public string CoralCode { get; set; }
        public string ColorStandard { get; set; }
        public string Size { get; set; }
        public string ColorWidth { get; set; }
        public string Height { get; set; }
        public string SubClient { get; set; }
        public Nullable<int> ColorMainQty { get; set; }
        public Nullable<int> ColorCompQty { get; set; }
        public string ColorDescp { get; set; }
        public string Status { get; set; }
        public string ComponentWidth { get; set; }
        public Nullable<int> FabricSubmition { get; set; }
        public string ClientInstructions { get; set; }
        public string ProcessInstructions { get; set; }
        public string Status1 { get; set; }
        public string Status2 { get; set; }
        public Nullable<System.DateTime> DateReq { get; set; }
        public Nullable<System.DateTime> DateAct { get; set; }
        public Nullable<System.DateTime> DateRel { get; set; }
        public Nullable<System.DateTime> DateExp { get; set; }
        public Nullable<System.DateTime> DateApr { get; set; }
        public string FabricType { get; set; }
        public string ComponentType { get; set; }
        public string CutStyle { get; set; }
        public string Skuno { get; set; }
        public Nullable<int> ShrinkLength { get; set; }
        public Nullable<int> ShrinkWeight { get; set; }
        public Nullable<decimal> FabricWeight { get; set; }
        public string VoidComments { get; set; }
    
        public virtual EG_SRFWebHeader EG_SRFWebHeader { get; set; }
    }
}