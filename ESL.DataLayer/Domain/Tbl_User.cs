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
    
    public partial class Tbl_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_User()
        {
            this.Tbl_Page = new HashSet<Tbl_Page>();
            this.Tbl_Payment = new HashSet<Tbl_Payment>();
            this.Tbl_UserClassPlan = new HashSet<Tbl_UserClassPlan>();
            this.Tbl_UserExamRemotelyPlan = new HashSet<Tbl_UserExamRemotelyPlan>();
            this.Tbl_UserExamRemotelyPlanAccess = new HashSet<Tbl_UserExamRemotelyPlanAccess>();
            this.Tbl_UserExamInPersonPlan = new HashSet<Tbl_UserExamInPersonPlan>();
            this.Tbl_UserWorkshopPlan = new HashSet<Tbl_UserWorkshopPlan>();
            this.Tbl_Wallet = new HashSet<Tbl_Wallet>();
        }
    
        public int User_ID { get; set; }
        public System.Guid User_Guid { get; set; }
        public int User_RoleID { get; set; }
        public int User_GenderCodeID { get; set; }
        public Nullable<int> User_LevelCodeID { get; set; }
        public string User_Email { get; set; }
        public Nullable<bool> User_EmailConfirmed { get; set; }
        public string User_PasswordSalt { get; set; }
        public string User_PasswordHash { get; set; }
        public string User_FirstName { get; set; }
        public string User_lastName { get; set; }
        public string User_IdentityNumber { get; set; }
        public string User_Mobile { get; set; }
        public Nullable<System.DateTime> User_Birthday { get; set; }
        public bool User_IsBan { get; set; }
        public bool User_IsDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Page> Tbl_Page { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Payment> Tbl_Payment { get; set; }
        public virtual Tbl_Role Tbl_Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UserClassPlan> Tbl_UserClassPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UserExamRemotelyPlan> Tbl_UserExamRemotelyPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UserExamRemotelyPlanAccess> Tbl_UserExamRemotelyPlanAccess { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UserExamInPersonPlan> Tbl_UserExamInPersonPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_UserWorkshopPlan> Tbl_UserWorkshopPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Wallet> Tbl_Wallet { get; set; }
    }
}
