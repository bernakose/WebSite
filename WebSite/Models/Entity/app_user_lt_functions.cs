//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class app_user_lt_functions
    {
        public int Id { get; set; }
        public long user_id { get; set; }
        public long func_id { get; set; }
        public string transacting_user { get; set; }
    
        public virtual app_user_function app_user_function { get; set; }
        public virtual app_users app_users { get; set; }
    }
}
