﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitterClone_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DOTNETEntities : DbContext
    {
        public DOTNETEntities()
            : base("name=TwitterEntities")
        {
        }
    //string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Follower> Followers { get; set; }
        public virtual DbSet<Following> Followings { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Tweet> Tweets { get; set; }
    }
}
