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
    
    public partial class Tbl_UserClassPlanPresence
    {
        public int UCPP_ID { get; set; }
        public System.Guid UCPP_Guid { get; set; }
        public int UCPP_UCPID { get; set; }
        public int UCPP_PaymentID { get; set; }
        public bool UCPP_IsPresent { get; set; }
        public System.DateTime UCPP_Date { get; set; }
        public System.DateTime UCPP_CreationDate { get; set; }
        public System.DateTime UCPP_ModifiedDate { get; set; }
        public bool UCPP_IsDelete { get; set; }
    
        public virtual Tbl_Payment Tbl_Payment { get; set; }
        public virtual Tbl_UserClassPlan Tbl_UserClassPlan { get; set; }
    }
}
