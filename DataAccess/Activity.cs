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
    
    public partial class Activity
    {
        public long ActivityId { get; set; }
        public long ActivityTypeId { get; set; }
        public long UserId { get; set; }
        public System.DateTime ActivityDateTime { get; set; }
    
        public virtual ActivityType ActivityType { get; set; }
        public virtual User User { get; set; }
    }
}
