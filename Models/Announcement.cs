//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMSAcademy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Announcement
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public Nullable<System.DateTime> DatePosted { get; set; }
        public string MessageSummary { get; set; }
        public string Message { get; set; }
        public Nullable<bool> FrontPage { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Title { get; set; }
    }
}