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
    
    public partial class Tbl_ExamInPersonPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_ExamInPersonPlan()
        {
            this.Tbl_UserExamInPersonPlan = new HashSet<Tbl_UserExamInPersonPlan>();
        }
    
        public int EIPP_ID { get; set; }
        public System.Guid EIPP_Guid { get; set; }
        public int EIPP_SEIPID { get; set; }
        public int EIPP_Capacity { get; set; }
        public string EIPP_Description { get; set; }
        public int EIPP_TotalMark { get; set; }
        public int EIPP_PassMark { get; set; }
        public int EIPP_Cost { get; set; }
        public string EIPP_Location { get; set; }
        public System.DateTime EIPP_Date { get; set; }
        public bool EIPP_IsActive { get; set; }
        public System.DateTime EIPP_CreationDate { get; set; }
        public System.DateTime EIPP_ModifiedDate { get; set; }
        public bool EIPP_IsDelete { get; set; }
    
        public virtual Tbl_SubExamInPerson Tbl_SubExamInPerson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UserExamInPersonPlan> Tbl_UserExamInPersonPlan { get; set; }
    }
}