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
    
    public partial class EG_SRFWebHeader
    {
        public EG_SRFWebHeader()
        {
            this.EG_SRFAttachedFiles = new HashSet<EG_SRFAttachedFiles>();
            this.EG_SRFColorRequest = new HashSet<EG_SRFColorRequest>();
            this.EG_SrfDyeSpecialFinishes = new HashSet<EG_SrfDyeSpecialFinishes>();
            this.EG_SrfFabricSpecialFinishes = new HashSet<EG_SrfFabricSpecialFinishes>();
            this.EG_SRFSpcWidthList = new HashSet<EG_SRFSpcWidthList>();
        }
    
        public string SrfNo { get; set; }
        public string SrfNoReference { get; set; }
        public string Status { get; set; }
        public string Status2 { get; set; }
        public string Status3 { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateRelease { get; set; }
        public Nullable<System.DateTime> DateApr { get; set; }
        public Nullable<System.DateTime> DateDeliver { get; set; }
        public Nullable<System.DateTime> DateDeliverSche { get; set; }
        public string ReferenceIn { get; set; }
        public string ReferenceOut { get; set; }
        public string SubClient { get; set; }
        public string CutStyle { get; set; }
        public string ExportContainer { get; set; }
        public string ExportComments { get; set; }
        public string TestMethod { get; set; }
        public string TestSprint { get; set; }
        public string TestStandard { get; set; }
        public string Garment { get; set; }
        public string GarmenWash { get; set; }
        public string FabricEsp { get; set; }
        public string StyleMainComponet { get; set; }
        public string TypeTran { get; set; }
        public string SessionId { get; set; }
        public Nullable<short> YarnAvailable { get; set; }
        public string ScreenPrint { get; set; }
        public string CTL { get; set; }
        public string Blends { get; set; }
        public string SampleDevelopment { get; set; }
        public Nullable<System.DateTime> YarnETA { get; set; }
        public Nullable<short> CheckWeight { get; set; }
        public string SampleSize { get; set; }
        public string ApprovalComments { get; set; }
        public string GeneralComments { get; set; }
        public string AttachedFiles { get; set; }
        public Nullable<System.DateTime> DateExp { get; set; }
        public string SpecialFinish { get; set; }
        public string CustNo { get; set; }
        public string VoidComments { get; set; }
        public string IsPique { get; set; }
    
        public virtual ICollection<EG_SRFAttachedFiles> EG_SRFAttachedFiles { get; set; }
        public virtual ICollection<EG_SRFColorRequest> EG_SRFColorRequest { get; set; }
        public virtual ICollection<EG_SrfDyeSpecialFinishes> EG_SrfDyeSpecialFinishes { get; set; }
        public virtual ICollection<EG_SrfFabricSpecialFinishes> EG_SrfFabricSpecialFinishes { get; set; }
        public virtual ICollection<EG_SRFSpcWidthList> EG_SRFSpcWidthList { get; set; }
    }
}