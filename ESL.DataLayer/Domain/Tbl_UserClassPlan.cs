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
    
    public partial class Tbl_UserClassPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_UserClassPlan()
        {
            this.Tbl_UserClassPlanPresence = new HashSet<Tbl_UserClassPlanPresence>();
        }
    
        public int UCP_ID { get; set; }
        public System.Guid UCP_Guid { get; set; }
        public int UCP_UserID { get; set; }
        public int UCP_CPID { get; set; }
        public Nullable<int> UCP_PaymentID { get; set; }
        public bool UCP_IsActive { get; set; }
        public System.DateTime UCP_CreationDate { get; set; }
        public System.DateTime UCP_ModifiedDate { get; set; }
        public bool UCP_IsDelete { get; set; }
    
        public virtual Tbl_ClassPlan Tbl_ClassPlan { get; set; }
        public virtual Tbl_Payment Tbl_Payment { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UserClassPlanPresence> Tbl_UserClassPlanPresence { get; set; }
    }
}