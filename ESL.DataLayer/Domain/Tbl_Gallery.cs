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
    
    public partial class Tbl_Gallery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Gallery()
        {
            this.Tbl_GalleryDocument = new HashSet<Tbl_GalleryDocument>();
        }
    
        public int Gallery_ID { get; set; }
        public System.Guid Gallery_Guid { get; set; }
        public string Gallery_Title { get; set; }
        public System.DateTime Gallery_CreationDate { get; set; }
        public bool Gallery_HasAlbum { get; set; }
        public bool Gallery_IsDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_GalleryDocument> Tbl_GalleryDocument { get; set; }
    }
}