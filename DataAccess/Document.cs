//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            this.DocLabelMappings = new HashSet<DocLabelMapping>();
            this.DocumentLogs = new HashSet<DocumentLog>();
            this.DocumentSubcriptions = new HashSet<DocumentSubcription>();
        }
    
        public long DocumentId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ContentId { get; set; }
        public string SpaceContentId { get; set; }
        public string SpaceDocumentContentId { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<int> LikeCounter { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocLabelMapping> DocLabelMappings { get; set; }
        public virtual User Creator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentLog> DocumentLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentSubcription> DocumentSubcriptions { get; set; }
    }
}
