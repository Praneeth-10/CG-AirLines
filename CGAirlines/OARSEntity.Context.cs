﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CGAirlines
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_OARSEntities : DbContext
    {
        public DB_OARSEntities()
            : base("name=DB_OARSEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdmin> tblAdmins { get; set; }
        public virtual DbSet<tblBooking> tblBookings { get; set; }
        public virtual DbSet<tblFlight> tblFlights { get; set; }
        public virtual DbSet<tblGuest> tblGuests { get; set; }
    }
}