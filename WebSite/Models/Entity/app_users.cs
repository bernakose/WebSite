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
    
    public partial class app_users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public app_users()
        {
            this.app_user_lt_functions = new HashSet<app_user_lt_functions>();
        }
    
        public long Id { get; set; }
        public string username { get; set; }
        public string usersurname { get; set; }
        public string usertc { get; set; }
        public string password { get; set; }
        public string usermail { get; set; }
        public string userphone { get; set; }
        public long isSystemAdmin { get; set; }
        public int groupId { get; set; }
        public string avatarImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<app_user_lt_functions> app_user_lt_functions { get; set; }
    }
}
