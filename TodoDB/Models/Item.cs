//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TodoDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ListID { get; set; }
        public Nullable<System.DateTime> DueDateTime { get; set; }
        public string Details { get; set; }
    
        public virtual List List { get; set; }
    }
}
