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
    
    public partial class app_user_function
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public app_user_function()
        {
            this.app_user_lt_functions = new HashSet<app_user_lt_functions>();
        }
    
        public long func_id { get; set; }
        public string func_name { get; set; }
        public string tag { get; set; }
        public long up_func_id { get; set; }
        public string tooltip { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_user_lt_functions> app_user_lt_functions { get; set; }
    }
}