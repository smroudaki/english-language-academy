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
    
    public partial class Tbl_UserExamRemotelyPlanAccess
    {
        public int UERPA_ID { get; set; }
        public System.Guid UERPA_Guid { get; set; }
        public int UERPA_UserID { get; set; }
        public int UERPA_ERPID { get; set; }
        public System.DateTime UERPA_Date { get; set; }
        public bool UERPA_IsActive { get; set; }
        public bool UERPA_IsDelete { get; set; }
    
        public virtual Tbl_ExamRemotelyPlan Tbl_ExamRemotelyPlan { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
    }
}