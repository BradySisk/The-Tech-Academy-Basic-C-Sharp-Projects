﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance6.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class masterEntities : DbContext
    {
        public masterEntities()
            : base("name=masterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Insuree> Insurees { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<tbl_Borrower> tbl_Borrower { get; set; }
        public virtual DbSet<tbl_class> tbl_class { get; set; }
        public virtual DbSet<tbl_habitat> tbl_habitat { get; set; }
        public virtual DbSet<tbl_order> tbl_order { get; set; }
        public virtual DbSet<tbl_Publisher> tbl_Publisher { get; set; }
        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }
        public virtual DbSet<spt_fallback_db> spt_fallback_db { get; set; }
        public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
        public virtual DbSet<spt_monitor> spt_monitor { get; set; }
    
        public virtual int Build_db_zoo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Build_db_zoo");
        }
    
        public virtual int sp_MScleanupmergepublisher()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MScleanupmergepublisher");
        }
    
        public virtual int sp_MSrepl_startup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MSrepl_startup");
        }
    }
}