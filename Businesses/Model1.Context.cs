﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Businesses
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BusinessesEntities : DbContext
    {
        public BusinessesEntities()
            : base("name=BusinessesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<countries> countries { get; set; }
        public virtual DbSet<departments> departments { get; set; }
        public virtual DbSet<dependents> dependents { get; set; }
        public virtual DbSet<employees> employees { get; set; }
        public virtual DbSet<jobs> jobs { get; set; }
        public virtual DbSet<locations> locations { get; set; }
        public virtual DbSet<regions> regions { get; set; }
    }
}
