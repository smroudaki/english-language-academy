//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESL.DataLayer.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_PageTags
    {
        public int PT_ID { get; set; }
        public System.Guid PT_Guid { get; set; }
        public int PT_TagID { get; set; }
        public int PT_PageID { get; set; }
    
        public virtual Tbl_Page Tbl_Page { get; set; }
        public virtual Tbl_Tag Tbl_Tag { get; set; }
    }
}
