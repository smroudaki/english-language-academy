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
    
    public partial class Tbl_SubExamInPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_SubExamInPerson()
        {
            this.Tbl_ExamInPersonPlan = new HashSet<Tbl_ExamInPersonPlan>();
        }
    
        public int SEIP_ID { get; set; }
        public System.Guid SEIP_Guid { get; set; }
        public int SEIP_ExamID { get; set; }
        public string SEIP_Title { get; set; }
        public System.DateTime SEIP_CreationDate { get; set; }
        public System.DateTime SEIP_ModifiedDate { get; set; }
        public bool SEIP_IsDelete { get; set; }
    
        public virtual Tbl_ExamInPerson Tbl_ExamInPerson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ExamInPersonPlan> Tbl_ExamInPersonPlan { get; set; }
    }
}
