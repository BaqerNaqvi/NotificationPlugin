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
    
    public partial class DocLabelMapping
    {
        public long DocLabelMappingId { get; set; }
        public long DocumentId { get; set; }
        public long LabelId { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual DocLabel DocLabel { get; set; }
    }
}