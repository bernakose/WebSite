﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebSiteEntities : DbContext
    {
        public WebSiteEntities()
            : base("name=WebSiteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<app_user_group> app_user_group { get; set; }
        public virtual DbSet<app_user_group_functions> app_user_group_functions { get; set; }
        public virtual DbSet<app_user_function> app_user_function { get; set; }
        public virtual DbSet<app_users> app_users { get; set; }
        public virtual DbSet<app_user_lt_functions> app_user_lt_functions { get; set; }
    }
}